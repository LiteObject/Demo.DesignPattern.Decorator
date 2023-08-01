namespace Demo.DesignPattern.Decorator.ExampleOne
{
    /// <summary>
    /// The 'Product Component' abstract class
    /// </summary>
    public abstract class Product
    {
        public int Quantity { get; set; } = 1;

        public double UnitPrice { get; set; }

        public abstract double GetSubTotal();
    }
}
