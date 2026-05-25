# 🟣 Interface Segregation Principle (ISP)

The Interface Segregation Principle (ISP) is the fourth principle of SOLID and states:

       “Clients should not be forced to depend upon interfaces that they do not use.”

In practice, this means that large and generic interfaces should be split into smaller and more specific ones, allowing classes to implement only the behaviors they truly need.
 
## ❌ Before — Legacy Code Violating ISP

In the example below, the IWorker interface forces every implementation to support behaviors such as eating and sleeping.

🚨 Problems

This design introduces several issues:

- The interface is too broad.
- RobotWorker is forced to implement methods it does not need.
- The code contains unnecessary NotImplementedException.
- Violates the Interface Segregation Principle.
- Increases coupling and reduces maintainability.

## ✅ After — Applying the Interface Segregation Principle

To fix the problem, we split the large interface into smaller and more focused interfaces.

## 🎯 Real Benefits of Applying ISP

Applying ISP brings several practical advantages:

✅ Lower Coupling

Classes depend only on behaviors they actually use.

✅ Better Maintainability

Smaller interfaces are easier to understand and evolve.

✅ Improved Flexibility

New implementations can be created without unnecessary methods.

✅ Cleaner Code

No more fake implementations or NotImplementedException.

✅ Better Testability

Focused interfaces simplify mocking and unit testing.

✅ Higher Readability

The code communicates responsibilities more clearly.

## 🧠 Conclusion
The Interface Segregation Principle helps create cleaner, more maintainable, and more flexible systems.

Instead of creating large “god interfaces”, ISP encourages splitting contracts into small and cohesive behaviors.

This prevents classes from being forced to implement functionality they do not need, resulting in a more scalable and professional architecture.