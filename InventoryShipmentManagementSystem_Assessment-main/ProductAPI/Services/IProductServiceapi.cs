using ProductAPI.Model;
namespace ProductAPI.Services
{
    public interface IProductServiceapi
    {
        
            List<Product> GetAllProduct(bool? isActive);

            Product? GetProductByID(int id);

            Product AddProduct(AddUpdateProductcs obj);

            Product? UpdateProduct(int id, AddUpdateProductcs obj);

            bool DeleteProductByID(int id);
        

    }
}
