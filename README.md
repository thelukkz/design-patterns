design-patterns

Creational Design Patterns: 
1. Abstract Factory Pattern:
   
![abstract factory pattern diagram](./Diagrams/abstractFactoryPattern.png)

   + provide an inferface for creating families of related or dependent objects without specifying concrete classes
   + objects can be grouped into a hierarchy that encapsulates distinct platforms consisting of a suite of related objects
   + calling code works with abstract interfaces and classes and does not need to know the exact types of the objects created by the factory

2. Builder Pattern

![abstract factory pattern diagram](./Diagrams/builderPattern.png)

   + separete the construction of a complex object from its representation so thaht you can use the same construction process for different types of objects
   + parse a complex representation and create one of several target objects out of it