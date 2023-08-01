namespace Demo.DesignPattern.Decorator.ExampleTwo
{
    // The PercentageDiscountDecorator adds a percentage discount to the product's price.
    public class PercentageDiscountDecorator : ProductDecorator
    {
        private readonly decimal _discountPercentage;

        public PercentageDiscountDecorator(IProduct product, decimal discountPercentage) : base(product)
        {
            _discountPercentage = discountPercentage;
        }

        public override decimal Price => _product.Price * (1 - _discountPercentage / 100);
    }
}
