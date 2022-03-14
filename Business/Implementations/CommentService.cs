using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductDetail;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Create(ProductDetailVM commentViewModel)
        {
            var comment = new Comment()
            {
                Content = commentViewModel.Content,
                ProductId = commentViewModel.ProductId,
                UserName = commentViewModel.UserName
            };

            await _unitOfWork.commentRepository.CreateAsync(comment);
            await _unitOfWork.SaveAsync();
        }



        public async Task<Comment> Get(int id)
        {
            return await _unitOfWork.commentRepository.Get(c => c.Id == id);
        }



        public async Task<List<Comment>> GetAllAsync()
        {
            return await _unitOfWork.commentRepository.GetAllAsync();
        }

        public async Task Remove(int id)
        {
            var comment = await _unitOfWork.commentRepository.Get(p => p.IsDelete == false&& p.Id ==id);
            comment.IsDelete = true;
             _unitOfWork.commentRepository.Update(comment);
            await _unitOfWork.SaveAsync();
        }



        public async Task<List<Comment>> GetbyPid(int id)
        {
            var pids = await _unitOfWork
                .commentRepository
                .GetAllAsync(p => p.ProductId == id && p.IsDelete == false);
            return pids;
        }
    }
}
