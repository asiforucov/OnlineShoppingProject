using Core.Entities;
using Core.Interfaces;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementations
{
    public class ProductBrandRepository : Repository<ProductBrand>, IProductBrandRepository
    {
        public ProductBrandRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;
    }
}
