using Web_DI.Models;

namespace Web_DI.Services
{
    public class ProductService : IProductService
    {
        public Product GetProduct()
        {
            var product = new Product()
            {
                Id = GetHashCode(),
                Name = "Coffee",
                Price = 1000.50,
                Amount = 20
            };
            return product;
        }
    }
}
