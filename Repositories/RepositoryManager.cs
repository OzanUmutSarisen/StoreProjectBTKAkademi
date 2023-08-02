using Repositories.Contracts;

namespace Repositories
{
    public class NewBaseType
    {
        public void Save()
        {

        }
    }

    public class RepositoryManager : NewBaseType, IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOrderRepository _orderRepository;

        public RepositoryManager(ICategoryRepository categoryRepository, IProductRepository productRepository, RepositoryContext context, IOrderRepository orderRepository)
        {
            _productRepository = productRepository;
            _context = context;
            _categoryRepository = categoryRepository;
            _orderRepository = orderRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public IOrderRepository Order => _orderRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}