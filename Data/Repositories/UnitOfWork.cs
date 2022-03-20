using Core;
using Core.Interfaces;
using Data.DAL;
using Data.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private ICommentRepository _commentRepository;
        private IGenderCategoryRepository _genderCategoryRepository;
        private IProductCategoryRepository _productCategoryRepository;
        private IProductColorRepository _productColorRepository;
        private IProductImageRepository _productImageRepository;
        private IProductRepository _productRepository;
        private IProductBrandRepository _productBrandRepository;
        private ISliderRepository _sliderRepository;
        private IAccountRepository _accountRepository;
        private IOrderRepository _orderRepository;
        private ISaleRepository _saleRepository;
        private IProductBFOSRepository _productBFOSRepository;



        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public ICommentRepository commentRepository => _commentRepository = _commentRepository ?? new CommentRepository(_context);
        public IProductRepository productRepository => _productRepository = _productRepository ?? new ProductRepository(_context);

        public IGenderCategoryRepository genderCategoryRepository => _genderCategoryRepository = _genderCategoryRepository ?? new GenderCategoryRepository(_context);

        public IProductCategoryRepository productCategoryRepository => _productCategoryRepository = _productCategoryRepository ?? new ProductCategoryRepository(_context);

        public IProductColorRepository productColorRepository => _productColorRepository = _productColorRepository ?? new ProductColorRepository(_context);

        public IProductImageRepository productImageRepository => _productImageRepository = _productImageRepository ?? new ProductImageRepository(_context);

        public IProductBrandRepository productSizeRepository => _productBrandRepository = _productBrandRepository ?? new ProductBrandRepository(_context);
        public ISliderRepository sliderRepository => _sliderRepository = _sliderRepository ?? new SliderRepository(_context);

        public IProductBFOSRepository productBFOSRepository => _productBFOSRepository = _productBFOSRepository ?? new ProductBFOSRepository(_context);

        public IAccountRepository accountRepository => _accountRepository = _accountRepository ?? new AccountRepository(_context); 
        public IOrderRepository orderRepository => _orderRepository = _orderRepository ?? new OrderRepository(_context);

        public ISaleRepository saleRepository => _saleRepository = _saleRepository ?? new SaleRepository(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        
    }
}
