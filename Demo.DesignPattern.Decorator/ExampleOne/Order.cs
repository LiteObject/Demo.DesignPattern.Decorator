using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DesignPattern.Decorator.ExampleOne
{
    public class Order
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
