namespace Demo.DesignPattern.Decorator.ExampleTwo
{
    // The abstract Decorator class defines the interface for the decorator objects.
    // It implements the Product interface and holds a reference to the Product object
    // that it will add functionality to.
    public abstract class ProductDecorator : IProduct
    {
        protected IProduct _product;

        public ProductDecorator(IProduct product)
        {
            _product = product;
        }

        public virtual string Name => _product.Name;
        public virtual string Description => _product.Description;
        public virtual decimal Price => _product.Price;
    }
}
