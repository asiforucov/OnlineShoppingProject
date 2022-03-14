using Business.ViewModels.Comment;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.ViewModels.ProductDetail;

namespace Business.Interfaces
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment> Get(int id);
        Task Create(ProductDetailVM productDetailVm);
        Task Remove(int id);
        Task<List<Comment>> GetbyPid(int id);
    }
}
