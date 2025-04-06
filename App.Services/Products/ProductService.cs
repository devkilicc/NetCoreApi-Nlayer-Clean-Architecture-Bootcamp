using App.Repositories.Products;

namespace App.Services.Products
{
    internal class ProductService(IProductRepository productRepository) : IProductService
    {

    }
}
