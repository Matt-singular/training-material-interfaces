### 1. What is an interface?
A contract that defines a set of behaviours or capabilities without implementing them.

Abstractions that define the methods, properties etc. that must be implemented.

Facilitate loose coupling between components of a system by allowing interactions to take place through interfaces rather than implementations.

### 2. Some coding examples
#### Example 1
##### No interfaces
The services are tightly coupled here, meaning changes to the Add Operation would likely also require changes to the Calculator.  This is [bad practice](#^SOLID2) and can make refactoring in real-world systems a difficult process.

![[Resources/Calculator-Basic.svg]]

#### Example 2
##### Basic Interface Usage
The services are loosely coupled since the Calculator relies on an interface.  The actual underlying add operation service can change completely without needing any changes to the calculator. 

![[Resources/Calculator-AddOperationBasic.svg]]

#### Example 3
##### Strategy Design pattern
Interfaces are much more powerful than I have given them credit as they also facilitate many different design patterns.

![[Resources/Calculator-StrategyPattern.svg]]

### 3. Some coding terminology and Principles
There are some fundamental object-oriented programming (OOP) concepts/principles where interfaces play a pivotal role.

We have actually indirectly covered these in the examples we showed above. 
#### (a) Polymorphism
This concept simply refers to the ability to treat a subtype as a member of the basetype.
For example:
```csharp
public interface IVehicle;
public class PetrolCar : IVehicle;
public class DieselCar : IVehicle;
public class ElectricCar : IVehicle;

var vehicles = new List<IVehicle>();
vehciles.Add(new PetrolCar());
vehciles.Add(new DieselCar());
vehciles.Add(new ElecricCar());
```

#### (b) The "Single responsibility" (**S**OLID) principle
Each class should have a single responsibility and shouldn't change for reasons unrelated to it.

When a service depends on another concrete service, it often takes on additional responsibilities related to managing that dependency.

By relying on interfaces, you separate concerns and ensure that each class or module has a single responsibility, promoting better maintainability and readability.

#### (c) The "Open/Closed" (S**O**LID) principle
Open for extension, but closed for modification. 

When a service directly depends on concrete implementations, any change to those implementations may require modifications to the dependent services. ^SOLID2

By depending on interfaces, you can introduce new implementations without modifying existing code.

(think back to [Example 3](#Example%203) and how easy it would be to introduce new operations without having to modify existing functionality)

#### (d) The "Interface Segregation" (SOL**I**D) principle
You should rely on many tailored interfaces rather than one monolithic one.

By designing interfaces that are tailored the needs of specific modules, you avoid forcing them to depend on methods they don't use.

Through Interface Segregation, you ensure that clients only need need to know about the methods relevant to their functionality, promoting clarity and reducing coupling.

#### (e) The "Dependency inversion" (SOLI**D**) principle
Encourages depending on abstractions rather than concrete implementations.

Interfaces serve as the abstractions that high-level modules depend on, while low-level modules implement them.

By creating interfaces, you invert the dependency direction, allowing high-level modules to remain unaffected by changes in low-level modules.

Dependency injection frameworks leverage interfaces to inject dependencies into classes, facilitating loose coupling and enabling easier testing and maintenance.

### 4. More on interfaces
* A class can inherit from multiple interfaces
* An interface can inherit from one or more interfaces
