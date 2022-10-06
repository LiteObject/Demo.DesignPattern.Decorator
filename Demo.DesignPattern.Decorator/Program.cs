namespace Demo.DesignPattern.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 'Concrete Component' TShirt
            TShirt tshirt = new(TShirt.ShirtSize.Large)
            {
                UnitPrice = 5,
                Quantity = 2
            };

            // Basically a line item - which is a Concrete Decorator with discount logic - represents a product
            LineItem lineItem = new(tshirt, 50);

            Order order = new();
            order.LineItems.Add(lineItem);

            Console.WriteLine("Your total is: {0}", order.GetTotal());
        }

        class Order
        {
            public List<LineItem> LineItems { get; set; } = new();

            public double GetTotal()
            {
                double total = 0;
                LineItems.ForEach(l => total += l.GetSubTotalAfterDiscount());
                return total;
            }
        }
    }
}