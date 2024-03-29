design-patterns

Creational Design Patterns: 
1. Abstract Factory Pattern:
   
![abstract factory pattern diagram](./Diagrams/abstractFactoryPattern.png)

   + provide an inferface for creating families of related or dependent objects without specifying concrete classes
   + objects can be grouped into a hierarchy that encapsulates distinct platforms consisting of a suite of related objects
   + calling code works with abstract interfaces and classes and does not need to know the exact types of the objects created by the factory

2. Builder Pattern

![builder pattern diagram](./Diagrams/builderPattern.png)

   + separete the construction of a complex object from its representation so thaht you can use the same construction process for different types of objects
   + parse a complex representation and create one of several target objects out of it

3. Factory Method Pattern

   + define an interface for creating objects, but you want to let subclasses decide which class to instantiate
   + decuple requesting objects from creating objects
   + calling code doesn't need to know what types of objects are created

![factory method pattern diagram](./Diagrams/factoryMethodPattern.png)
![factory method pattern diagram](./Diagrams/factoryMethodPattern2.png)

4. Prototype Pattern
   
   + use a prototype object instance for creating new objects, by copying the prototype
   + constructing a new object from zero takes a lot of time and effort
   + move construction logic away from the calling code

![prototype pattern diagram](./Diagrams/prototypePattern.png)

5. Singleton Pattern

   + ensure that a class has only one instance
   + provide global access to that single instance
   + make use of lazy initialization, also sometimes called just-in-time initialisation

![singleton pattern diagram](./Diagrams/singletonPattern.png)

Structural Design Patterns:
6. Adapter Pattern

   + Convert the interface of one class into another
   + Wrap an existing class with new interface
   + Introduce a legacy component into a new system

![adapter pattern diagram](./Diagrams/adapterPattern.png)

7. Bridge Pattern

   + Combine two or more orthogonal class hierarchies
   + Bind an implementation to a class at runtime
   + Clean up a proliferation of classes resulting from an interface coupled with lots of implementations
   + Share an implementation among multiple objects

![bridge pattern diagram](./Diagrams/bridgePattern.png)

8. Composite Pattern

   + You need a tree structure to represent a part hierarchy
   + You want to compose objects out of one or more child objects
   + You want clients to treat individual objects and compositions of objects in exactly the same way

![composite pattern diagram](./Diagrams/compositePattern.png)

9. Decorator Pattern

   + Attach functionality to an object dynamically
   + You are unable to use subclassing

![decorator pattern diagram](./Diagrams/decoratorPattern.png)

10. Facade Pattern

   + Provide a unified high-level interface to a set of low-level interfaces in a subsystem
   + Make the subsystem easier to use
   + Wrap a complicated subsystem with a simpler interface

![facade pattern diagram](./Diagrams/facadePattern.png)

11. Flyweight Pattern

   + Support a very large numbers of fine-grained objects
   + Requirement: the state information of each object can be retrieved on demand

![flyweight pattern diagram](./Diagrams/flyweightPattern.png)

12. Proxy Pattern

   + You want to provide a surrogate or placeholder for another object

![proxy pattern diagram](./Diagrams/proxyPattern.png)