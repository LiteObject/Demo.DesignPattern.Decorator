using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DesignPattern.Decorator.ExampleTwo
{
    // The Component interface defines the basic information and
    // operations that can be performed on the products.
    public interface IProduct
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
    }
}
