using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public sealed class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
            
        }
    }
}