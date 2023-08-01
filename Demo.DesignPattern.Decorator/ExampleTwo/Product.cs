namespace Demo.DesignPattern.Decorator.ExampleTwo
{
    // The ConcreteComponent is the basic implementation of the Product interface.
    public class Product : IProduct
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }

        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
