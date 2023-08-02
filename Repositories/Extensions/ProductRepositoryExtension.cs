using Entities.Models;

namespace RepositoriesçExtensions
{
    public static class ProductRepositoryExtension
    {
        public static IQueryable<Product> FilteredByCategoryId(this IQueryable<Product> products, int? CategoryId)
        {
            if (CategoryId is null)
            {
                return products;
            }
            else
            {
                return products.Where(prd => prd.CategoryId.Equals(CategoryId));
            }
        }

        public static IQueryable<Product> FilteredBySearchTerm(this IQueryable<Product> products, String? SearchTerm)
        {
            if (string.IsNullOrWhiteSpace(SearchTerm))
            {
                return products;
            }
            else
            {
                return products.Where(prd => prd.ProductName.ToLower().Contains(SearchTerm.ToLower()));
            }
        }
        public static IQueryable<Product> FilteredByPrice(this IQueryable<Product> products, int minPrice, int maxPrice, bool isValidPrice)
        {
            if (!isValidPrice)
            {
                return products;
            }
            else
            {
                return products.Where(prd => prd.Price >= minPrice && prd.Price <= maxPrice);
            }
        }

        public static IQueryable<Product> GetLastNProducts(this IQueryable<Product> products, int n)
        {
            return products.OrderByDescending(prd => prd.CategoryId).Take(n);
        }

        public static IQueryable<Product> ToPaginate(this IQueryable<Product> products, int pageNumber,int pageSize)
        {
            return products
                .Skip(((pageNumber-1)*pageSize))
                .Take(pageSize);
        }
    }
}