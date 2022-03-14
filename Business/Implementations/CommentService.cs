using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Comment;
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
        public async Task Create(CommentCreateViewModel commentViewModel)
        {
            var comment = new Comment()
            {
                Content = commentViewModel.Content,
                ProductId = commentViewModel.ProductId,
                ApplicationUserId = commentViewModel.UserId
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

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

       
    }
}
