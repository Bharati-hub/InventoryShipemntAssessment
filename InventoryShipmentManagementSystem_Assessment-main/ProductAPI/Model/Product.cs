namespace ProductAPI.Model
{
    public class Product
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        
        public bool isActive { get; set; } = true;


    }
}
