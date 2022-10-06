namespace Demo.DesignPattern.Decorator
{
    /// <summary>
    /// The 'TShirt Concrete Component' class implements 'Product Component' abstract class    
    /// </summary>
    public class TShirt : Product
    {
        public enum ShirtSize
        {
            Small,
            Medium,
            Large,
            XLarge
        }

        public ShirtSize Size { get; set; }

        public TShirt(ShirtSize size = ShirtSize.Medium)
        {
            Size = size;
        }

        public override double GetSubTotal()
        {
            var subTotal = Size switch
            {
                ShirtSize.XLarge => (UnitPrice * Quantity) + 2.50,
                _ => UnitPrice * Quantity,
            };

            return subTotal;
        }
    }
}
