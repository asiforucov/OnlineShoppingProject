﻿using Business.ViewModels.Comment;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment> Get(int id);
        Task Create(CommentCreateViewModel commentViewModel);
        Task Update(int id, CommentUpdateViewModel commentViewModel);
        Task Remove(int id);
    }
}