# Object-Oriented Programming (OOP) in C#

## What is OOP?
OOP is a programming paradigm based on **objects** (instances of classes) that contain data (fields) and behavior (methods).

---

## 4 Pillars of OOP

### 1. Encapsulation
Hiding internal data and exposing only necessary parts via public methods/properties.

```csharp
public class BankAccount
{
    private decimal balance; // hidden data

    public decimal GetBalance() => balance;
    public void Deposit(decimal amount)
    {
        if (amount > 0) balance += amount;
    }
}
```

### 2. Inheritance
A class (child) can inherit members from another class (parent). Promotes code reuse.

```csharp
public class Animal
{
    public void Eat() => Console.WriteLine("Eating...");
}

public class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking...");
}
```

### 3. Polymorphism
Same method name behaves differently based on the object. Two types:
- **Compile-time** (Method Overloading)
- **Runtime** (Method Overriding with `virtual`/`override`)

```csharp
// Overloading
public int Add(int a, int b) => a + b;
public double Add(double a, double b) => a + b;

// Overriding
public class Shape { public virtual void Draw() => Console.WriteLine("Shape"); }
public class Circle : Shape { public override void Draw() => Console.WriteLine("Circle"); }
```

### 4. Abstraction
Hiding complexity and showing only essential features. Achieved via **abstract classes** and **interfaces**.

```csharp
public abstract class Vehicle
{
    public abstract void Start();
}

public interface IPrintable
{
    void Print();
}
```

---

## Class vs Object

| Class | Object |
|-------|--------|
| Blueprint / template | Instance of a class |
| Defined once | Created many times |
| No memory allocated | Memory allocated with `new` |

```csharp
public class Car { public string Model { get; set; } }  // Class
Car myCar = new Car();  // Object (instance)
```

---

## Access Modifiers

| Modifier | Access Level |
|----------|-------------|
| `public` | Anywhere |
| `private` | Same class only |
| `protected` | Same class + derived classes |
| `internal` | Same assembly only |
| `protected internal` | Same assembly + derived classes |
| `private protected` | Same class + derived classes in same assembly |

---

## Constructors & Destructor

```csharp
public class Person
{
    public string Name { get; set; }

    // Default constructor
    public Person() { Name = "Unknown"; }

    // Parameterized constructor
    public Person(string name) { Name = name; }

    // Static constructor (runs once)
    static Person() { Console.WriteLine("Static ctor"); }

    // Copy constructor
    public Person(Person p) { Name = p.Name; }

    // Destructor
    ~Person() { Console.WriteLine("Cleanup"); }
}
```

---

## Static Members

- Belong to the class, not instances
- Accessed via class name: `ClassName.Member`

```csharp
public class MathUtility
{
    public static double Pi = 3.14;
    public static int Add(int a, int b) => a + b;
}
```

---

## Abstract Class vs Interface

| Feature | Abstract Class | Interface |
|---------|---------------|-----------|
| Default implementation | Yes | Yes (C# 8+) |
| Fields | Yes | No |
| Constructors | Yes | No |
| Multiple inheritance | No | Yes |
| Access modifiers | Yes | All public |

**When to use what?**
- **Abstract class**: Shared base logic + some implementation
- **Interface**: Contract/capability (e.g., `IComparable`, `IDisposable`)

---

## Method Overloading vs Overriding

| Overloading | Overriding |
|-------------|-----------|
| Same name, different parameters | Same name, same parameters |
| Compile-time polymorphism | Runtime polymorphism |
| No `virtual`/`override` needed | Needs `virtual`/`override` keywords |
| Can be in same class | Must be in derived class |

---

## SOLID Principles

| Letter | Principle | Meaning |
|--------|-----------|---------|
| **S** | Single Responsibility | One class = one responsibility |
| **O** | Open/Closed | Open for extension, closed for modification |
| **L** | Liskov Substitution | Derived class must be substitutable for base |
| **I** | Interface Segregation | Many specific interfaces > one general |
| **D** | Dependency Inversion | Depend on abstractions, not concretions |

---

## Key OOP Concepts in C#

### Properties
```csharp
public string Name { get; set; }           // Auto property
public string Name { get; private set; }   // Read-only outside
private string _name;                      // Full property
public string Name { get => _name; set => _name = value; }
```

### Extension Methods
```csharp
public static class StringExtensions
{
    public static bool IsPalindrome(this string str) =>
        str == new string(str.Reverse().ToArray());
}
// Usage: "madam".IsPalindrome();
```

### Sealed Class
Prevents inheritance: `public sealed class FinalClass { }`

### Partial Class
Split a class across multiple files: `partial class MyClass { }`

### Record (C# 9+)
Immutable reference type for data: `public record Person(string Name, int Age);`

---

## Common OOP Interview Keywords

- **Cohesion**: How focused a class is (high cohesion = good)
- **Coupling**: How dependent classes are (loose coupling = good)
- **DRY**: Don't Repeat Yourself
- **YAGNI**: You Aren't Gonna Need It
- **Composition over Inheritance**: Prefer HAS-A over IS-A

---

## Quick Summary

```
OOP = Classes + Objects + 4 Pillars

Encapsulation  → Hide data (private fields, public methods)
Inheritance    → Reuse code (base → derived)
Polymorphism   → One name, many forms (overloading/overriding)
Abstraction    → Hide complexity (abstract classes/interfaces)

SOLID → 5 design principles for maintainable code
```
