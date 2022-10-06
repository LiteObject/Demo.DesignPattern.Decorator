using Humanizer;

namespace Demo.DesignPattern.Decorator
{
    /// <summary>
    /// The 'Concrete Decorator' class that adds responsibilities to the component
    /// </summary>
    public class LineItem : ProductDecorator
    {
        public LineItem(Product product, double discountPercentage = 0) : base(product)
        {
            if (discountPercentage > 75)
            {
                throw new ArgumentException($"{nameof(DiscountPercentage).Humanize(LetterCasing.Sentence)} cannot be greater than 75.");
            }

            DiscountPercentage = discountPercentage;
        }

        public double DiscountPercentage { get; private set; }


        public double GetSubTotalAfterDiscount()
        {
            var subTotal = base.GetSubTotal();
            return subTotal - (subTotal * DiscountPercentage / 100);
        }
    }
}
