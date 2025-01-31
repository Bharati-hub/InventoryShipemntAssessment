using ProductAPI.Model;
namespace ProductAPI.Services
{
    public class Productservices: IProductServiceapi
    {
        private readonly List<Product> _ProductList;
        public Productservices()
        {
            _ProductList = new List<Product>()
            {

                new Product(){
                Id = 1,
                Name = "Test",

                Quantity =2,
                    Price=45,
                isActive = true,
                }
            };
    }

        public List<Product> GetAllProduct(bool? isActive)
        {
            return isActive == null ? _ProductList : _ProductList.Where(product => product.isActive == isActive).ToList();
        }

        public Product? GetProductByID(int id)
        {
            return _ProductList.FirstOrDefault(product => product.Id == id);
        }


        public Product AddProduct(AddUpdateProductcs obj)
        {
            var addProduct = new Product()
            {
                Id = _ProductList.Max(product => product.Id) + 1,
                Name = obj.Name,
               Quantity=obj.Quantity,
               Price=obj.Price,
                isActive = obj.isActive,
            };

            _ProductList.Add(addProduct);

            return addProduct;
        }

        public Product? UpdateProduct(int id, AddUpdateProductcs obj)
        {
            var productIndex = _ProductList.FindIndex(index => index.Id == id);
            if (productIndex > 0)
            {
                var product = _ProductList[productIndex];

                product.Name = obj.Name;
                product.Quantity = obj.Quantity;
                product.Price = obj.Price;
                product.isActive = obj.isActive;

                _ProductList[productIndex] = product;

                return product;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteProductByID(int id)
        {
            var productIndex = _ProductList.FindIndex(index => index.Id == id);
            if (productIndex >= 0)
            {
                _ProductList.RemoveAt(productIndex);
            }
            return productIndex >= 0;
        }

    }

    }

