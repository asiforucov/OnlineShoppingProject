using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork
    {
        public ICommentRepository commentRepository { get; }
        public IProductRepository productRepository { get; }
        public IGenderCategoryRepository genderCategoryRepository { get;  }
        public IProductCategoryRepository productCategoryRepository { get;  }
        public IProductColorRepository productColorRepository { get;  }
        public IProductImageRepository productImageRepository { get;  }
        public IProductBrandRepository productSizeRepository { get;  }
        public ISliderRepository sliderRepository { get;  }
        public IAccountRepository accountRepository { get;  }
        public IOrderRepository orderRepository { get;  }
        public IProductBFOSRepository productBFOSRepository { get;  }
        Task SaveAsync();
    }
}
