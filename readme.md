# An Example of Decorator Design Pattern with C#

## What is Decorator?
>The Decorator design pattern attaches additional responsibilities to an object dynamically. This pattern provide a flexible alternative to subclassing for extending functionality.



```mermaid
classDiagram
    IComponent <|-- ConcreteComponent   
    IComponent <|-- Decorator
    IComponent <--* Decorator:Ref to Component
        
    class IComponent { 
        <<Interface>>
        +Operation()
    }
    
    class ConcreteComponent {                
        +Operation()
    }

    class Decorator {
        <<Abstract>>
        -Component
        +Operation()
    }

    Decorator <|-- ConcreteDecoratorA
    Decorator <|-- ConcreteDecoratorB

    class ConcreteDecoratorA {      
        -AddedState
        +Operation()        
    }

    class ConcreteDecoratorB {      
        +Operation()
        +AddedBehavior()
    }
```
* Component: 
  - Defines the interface for objects that can have responsibilities added to them dynamically
  - Usually an abstract class or interface
* ConcreteComponent: 
  - Defines an object to which additional responsibilities can be attached
  - Inherits or implements the Component class/interface
* Decorator: 
  - Maintains a reference to a Component object
  - Usually an abstract class
  - Inherits or implements the Component class/interface
* ConcreteDecorator: 
  - Adds responsibilities to the component
  - Inherits the Decorator