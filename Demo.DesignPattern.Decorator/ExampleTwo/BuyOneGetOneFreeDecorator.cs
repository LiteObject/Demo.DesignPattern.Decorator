namespace Demo.DesignPattern.Decorator.ExampleTwo
{
    // The BuyOneGetOneFreeDecorator adds a buy-one-get-one-free offer to the product.
    public class BuyOneGetOneFreeDecorator : ProductDecorator
    {
        public BuyOneGetOneFreeDecorator(IProduct product) : base(product)
        {
        }

        public override decimal Price => _product.Price / 2;
    }
}
