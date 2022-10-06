namespace Demo.DesignPattern.Decorator
{
    /// <summary>
    /// The 'Product Decorator' abstract class which maintains a reference to a 'Product Component' object
    /// </summary>
    public abstract class ProductDecorator : Product
    {
        protected readonly Product product;

        public ProductDecorator(Product product)
        {
            this.product = product;
        }

        public override double GetSubTotal()
        {
            return this.product.GetSubTotal();
        }
    }
}
