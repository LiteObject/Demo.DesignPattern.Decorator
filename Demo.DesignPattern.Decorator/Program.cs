using Demo.DesignPattern.Decorator.ExampleOne;
using Demo.DesignPattern.Decorator.ExampleTwo;

namespace Demo.DesignPattern.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***************************************************************************************** 
             * EXAMPLE 1: 
             *****************************************************************************************/

            // Create 'Concrete Component' T-Shirt
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

            /***************************************************************************************** 
             * EXAMPLE 2: 
             *****************************************************************************************/

            ExampleTwo.Product product = new("Shirt", "A nice shirt", 50.00M);
            Console.WriteLine($"{product.Name}: {product.Description}, Price: {product.Price:C}");

            BuyOneGetOneFreeDecorator offerProduct = new(product);
            Console.WriteLine($"{offerProduct.Name}: {offerProduct.Description}, Price: {offerProduct.Price:C}");
        }
    }
}