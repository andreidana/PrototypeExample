# PrototypeExample

**Definition** Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype

**Applicability**

- When a system should be independent of how its products are created, composed and represented AND:
- When the classes to instantiate are specified at run-time, for example by dynamic loading OR
- To avoid building a class hierarchy of factories that parallels the class hierarchy or products OR
- When instances of a class can have one of only a few different combinations of state.

**Consequences**

- Hides concrete product classes from the client
- Adding and removing products at run-time
- Specifying new objects by varying values
- Specifying new objects by varying structure
- Reduced subclassing
- Configuring an application with classes dynamically


**Related Patterns**

- [Abstract Factory](https://github.com/andreidana/AbstractFactoryExample)
- Composite
- Decorator