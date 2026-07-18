# C# & .NET Interview Questions

## Table of Contents
- [Basic Questions](#-basic-questions)
- [OOP Questions](#-oop-questions)
- [Intermediate Questions](#-intermediate-questions)
- [Advanced Questions](#-advanced-questions)
- [ASP.NET Core Questions](#-aspnet-core-questions)
- [SQL / Database Questions](#-sql--database-questions)
- [Coding Challenges](#-coding-challenges)

---

## 🔹 Basic Questions

### Q1. What is C#?
**A.** C# is a modern, type-safe, object-oriented programming language developed by Microsoft for building applications on the .NET platform.

### Q2. Difference between `int` and `int?`
**A.** `int` is non-nullable (cannot be null). `int?` is nullable (can hold null). `int?` is syntactic sugar for `Nullable<int>`.

### Q3. What is the difference between `ref` and `out`?
| `ref` | `out` |
|-------|-------|
| Variable must be initialized before passing | Variable need not be initialized |
| Value can be read inside method | Cannot read inside method before assigning |
| Used for both input and output | Used only for output |

### Q4. Explain `var` vs `dynamic`
**A.** `var` is statically typed (type decided at compile time). `dynamic` is dynamically typed (type checked at runtime).

### Q5. What is the difference between `const` and `readonly`?
**A.** `const` is compile-time constant (implicitly static). `readonly` is runtime constant (can be set in constructor, can be instance-level).

### Q6. What is boxing and unboxing?
**A.** Boxing = converting value type to object (e.g., `object o = 10;`). Unboxing = converting object back to value type (`int i = (int)o;`). Boxing/unboxing impacts performance.

### Q7. Difference between `Array` and `ArrayList`
**A.** Array is fixed-size, strongly typed. ArrayList is dynamic-size, stores objects (no type safety). Use `List<T>` instead of ArrayList.

### Q8. What is `StringBuilder`?
**A.** Mutable string class in `System.Text`. Use when doing many string manipulations (better performance than `string` which is immutable).

### Q9. What is `using` statement?
**A.** Ensures `IDisposable` objects are properly disposed. Equivalent to try-finally with `Dispose()` call.

### Q10. Value types vs Reference types?
**A.** Value types (struct, int, bool) store data directly on stack. Reference types (class, string, array) store reference to data on heap.

---

## 🔹 OOP Questions

### Q11. What are the 4 pillars of OOP?
**A.** Encapsulation (hide data), Inheritance (reuse code), Polymorphism (one name many forms), Abstraction (hide complexity).

### Q12. Difference between Abstract Class and Interface?
| Abstract Class | Interface |
|---------------|-----------|
| Can have fields + constructors | No fields/constructors |
| Can have implementation | All members public by default |
| Single inheritance only | Multiple inheritance supported |
| `abstract class A { }` | `interface I { }` |

### Q13. What is method overloading?
**A.** Same method name with different parameters (compile-time polymorphism). e.g., `Add(int, int)` and `Add(double, double)`.

### Q14. What is method overriding?
**A.** Redefining a base class method in derived class using `override` keyword (runtime polymorphism). Base method must be `virtual`/`abstract`.

### Q15. What is a sealed class?
**A.** A class that cannot be inherited. Use `sealed class MyClass { }`.

### Q16. What is a static class?
**A.** Cannot be instantiated, contains only static members. Example: `Console`, `Math`, `Convert`.

### Q17. What is the difference between `is` and `as`?
**A.** `is` checks type compatibility (returns bool). `as` performs safe cast (returns null if fails). `as` only works with reference types.

### Q18. What are extension methods?
**A.** Methods that add new functionality to existing types without modifying them. Must be in a static class, use `this` keyword on first parameter.

### Q19. What is a record in C# 9+?
**A.** Immutable reference type with value-based equality. `public record Person(string Name, int Age);`

### Q20. Explain SOLID principles briefly.
- **S**: Single Responsibility - class should have one reason to change
- **O**: Open/Closed - open for extension, closed for modification
- **L**: Liskov Substitution - derived class can replace base class
- **I**: Interface Segregation - many small interfaces > one big interface
- **D**: Dependency Inversion - depend on abstractions, not concretions

---

## 🔹 Intermediate Questions

### Q21. What is LINQ?
**A.** Language Integrated Query - allows querying collections, databases, XML using SQL-like syntax. Two forms: Query syntax and Method syntax (lambda).

### Q22. What is the difference between `First()` and `FirstOrDefault()`?
**A.** `First()` throws exception if no match found. `FirstOrDefault()` returns default value (null for ref types, 0 for value types).

### Q23. Difference between `IEnumerable` and `IQueryable`
**A.** `IEnumerable` works in-memory (client-side). `IQueryable` works with external data sources (database), builds expression tree.

### Q24. What is async/await?
**A.** Async/await enables asynchronous programming. `async` marks method as asynchronous. `await` suspends method until task completes (non-blocking).

### Q25. What is the difference between `Task` and `Thread`?
**A.** `Task` is a higher-level abstraction, uses thread pool, supports async/await. `Thread` is lower-level, creates OS thread directly.

### Q26. What is a delegate?
**A.** Type-safe function pointer that holds reference to a method(s). Built-in delegates: `Func` (returns value), `Action` (returns void).

### Q27. What is an event?
**A.** Wrapper around a delegate. Provides publish-subscribe pattern. Only the defining class can raise the event.

### Q28. What is garbage collection in .NET?
**A.** Automatic memory management. GC reclaims memory of unreachable objects. Runs on generations (0, 1, 2). Use `IDisposable` for unmanaged resources.

### Q29. Difference between `throw` and `throw ex`?
**A.** `throw` preserves original stack trace. `throw ex` resets stack trace from catch point (loses original error location).

### Q30. What are generics and why use them?
**A.** Generics allow type-safe code without specifying type upfront. Benefits: type safety, performance (no boxing), code reuse.

---

## 🔹 Advanced Questions

### Q31. What is Dependency Injection (DI)?
**A.** Design pattern where dependencies are provided (injected) from outside rather than created internally. Built into ASP.NET Core.

### Q32. What are the DI container lifetimes?
| Lifetime | Description |
|----------|-------------|
| `Transient` | New instance every time |
| `Scoped` | Same instance per request |
| `Singleton` | Same instance for entire app |

### Q33. What is reflection?
**A.** Ability to inspect and interact with types at runtime (get methods, properties, create instances dynamically).

### Q34. What are attributes in C#?
**A.** Metadata tags that add declarative info to code. Examples: `[Serializable]`, `[Obsolete]`, `[Authorize]`.

### Q35. What is the difference between `IEnumerable`, `ICollection`, `IList`?
- `IEnumerable` - can iterate only (most basic)
- `ICollection` - adds Count, Add, Remove, Clear
- `IList` - adds indexer, Insert, RemoveAt

### Q36. What is the yield keyword?
**A.** Used in iterator blocks. Returns elements one-by-one without creating a temporary collection. Creates state machine behind the scenes.

### Q37. What is the difference between managed and unmanaged code?
**A.** Managed code runs under CLR (garbage collected, type-safe). Unmanaged code runs directly on OS (C++, Windows API).

### Q38. What is the Global Assembly Cache (GAC)?
**A.** Machine-wide code cache for shared .NET assemblies. Allows multiple apps to share the same DLL version.

### Q39. What is a deadlock?
**A.** Two or more threads waiting for each other to release resources. Use proper locking order, `Monitor.TryEnter`, or `SemaphoreSlim` to avoid.

### Q40. What is the difference between `String` and `string`?
**A.** No difference. `string` is an alias for `System.String`. Same with `int`/`System.Int32`, `bool`/`System.Boolean`.

---

## 🔹 ASP.NET Core Questions

### Q41. What is ASP.NET Core?
**A.** Cross-platform, high-performance framework for building web apps, APIs, and microservices. Runs on Windows, macOS, Linux.

### Q42. Explain the middleware pipeline.
**A.** Middleware are components that handle requests/responses in a pipeline. Each middleware can process, modify, or short-circuit the request.

### Q43. What is the difference between AddSingleton, AddScoped, AddTransient?
**A.** (See Q32) Singleton = one instance globally. Scoped = one per HTTP request. Transient = new instance every injection.

### Q44. What is Entity Framework Core?
**A.** ORM (Object-Relational Mapper) for .NET. Allows working with databases using C# objects. Supports Code-First and Database-First approaches.

### Q45. What is the difference between ASP.NET MVC and ASP.NET Web API?
**A.** MVC returns Views (HTML). Web API returns data (JSON/XML). In ASP.NET Core, both are merged into one framework (Controller with attributes).

---

## 🔹 SQL / Database Questions

### Q46. Difference between `INNER JOIN` and `LEFT JOIN`?
**A.** INNER JOIN = matching rows from both tables. LEFT JOIN = all rows from left table + matching from right (non-matching = NULL).

### Q47. What is an index?
**A.** Database structure for fast data retrieval. Clustered index = physical order. Non-clustered index = separate structure with pointers.

### Q48. Difference between `WHERE` and `HAVING`?
**A.** WHERE filters rows before grouping. HAVING filters groups after GROUP BY.

### Q49. What is a primary key vs foreign key?
**A.** Primary Key = unique identifier for each row. Foreign Key = field that references Primary Key of another table (enforces referential integrity).

### Q50. What is SQL injection and how to prevent it?
**A.** Attack where malicious SQL is injected. Prevent by: using parameterized queries / EF Core (never concatenate user input into SQL strings).

---

## 🔹 Coding Challenges

### Q51. Reverse a string
```csharp
string Reverse(string s) => new string(s.Reverse().ToArray());
```

### Q52. Check if string is palindrome
```csharp
bool IsPalindrome(string s) => s == new string(s.Reverse().ToArray());
```

### Q53. Find the largest number in an array
```csharp
int Max(int[] arr) => arr.Max();
```

### Q54. Check if a number is prime
```csharp
bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0) return false;
    return true;
}
```

### Q55. FizzBuzz
```csharp
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0) Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0) Console.WriteLine("Fizz");
    else if (i % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(i);
}
```

### Q56. Remove duplicates from array
```csharp
int[] RemoveDupes(int[] arr) => arr.Distinct().ToArray();
```

### Q57. Count character occurrences in string
```csharp
var counts = "hello".GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
```

### Q58. Binary search
```csharp
int BinarySearch(int[] arr, int target)
{
    int left = 0, right = arr.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) return mid;
        if (arr[mid] < target) left = mid + 1;
        else right = mid - 1;
    }
    return -1;
}
```

### Q59. Factorial (recursive)
```csharp
int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
```

### Q60. Swap two numbers without temp variable
```csharp
void Swap(ref int a, ref int b) { a ^= b; b ^= a; a ^= b; }
// Or: a = a + b; b = a - b; a = a - b;
```

---

## Tips for Interview

### During Interview
- **Think out loud** - explain your approach before coding
- **Ask clarifying questions** - don't assume requirements
- **Start with brute force** - then optimize
- **Handle edge cases** - null, empty, large inputs
- **Test your code** - walk through a simple example

### Common Topics to Master
1. OOP + SOLID Principles
2. LINQ + Collections
3. Async/Await + Threading
4. Dependency Injection
5. Entity Framework
6. SQL queries + Joins
7. Design Patterns (Singleton, Factory, Repository)
8. REST API principles
9. Unit Testing (xUnit/NUnit)
10. Git basics

### Before Interview
- Review your own projects (can explain architecture decisions)
- Practice coding on LeetCode / HackerRank
- Prepare examples of past challenges and solutions
- Have questions ready for the interviewer
