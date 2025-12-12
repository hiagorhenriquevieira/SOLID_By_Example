# 🟣 Open/Closed Principle (OCP)

The Open/Closed Principle (OCP) states:

       "Software entities should be open for extension, but closed for modification." — Bertrand Meyer

This means you should be able to add new behavior to the system without modifying existing code.
In other words:

- Existing code is stable and protected.

- New behavior is added through extension, usually by abstractions (interfaces or base classes).
 
## ❌ Before — Legacy Code Violating OCP

In the legacy example, the price calculator class contained multiple if/else blocks to determine which discount to apply:

- For every new discount, a developer had to change the existing class.
- The class kept growing endlessly.
- Each new discount risked breaking older ones.
- The code became harder to test and maintain.

This is a classic violation of the Open/Closed Principle.

## ✅ After — Applying the Open/Closed Principle

The solution uses polymorphism:

1. We created an interface: IDiscount.
2. Each discount type became its own class, responsible only for its own logic.
3. The PriceCalculator now receives any IDiscount implementation and never needs to be modified again.

This makes the system:

- Closed for modification
  The calculator will never need to be edited again.

- Open for extension
  New discounts can be added by simply creating new classes.

## 🎯 Real Benefits of Applying OCP
🟢 1. Infinite extensibility

New discounts? Black Friday, cashback, loyalty program…
→ Create a new class.
→ No changes to existing code.

🟢 2. Easier maintenance

Each discount rule lives in its own class.

Less risk of side effects or regressions.

🟢 3. Better testability

Each discount can be tested in isolation.
The calculator can be tested with mocks or stubs.

🟢 4. Improved readability

- No more giant if/else methods.
- The architecture becomes clean and modular.

🟢 5. Reduced coupling

The calculator knows nothing about discount rules — and it doesn't need to.

It simply delegates the calculation to the abstraction (IDiscount).

🟢 6. More flexible architecture

Integrating with:

- Dependency Injection
- Factory patterns
- Runtime strategy selection

…becomes easy without changing any core code.


## 🧠 Conclusion

Applying the Open/Closed Principle:

- Increases system stability
- Makes maintenance simpler
- Reduces regression risks
- Organizes the codebase
- Allows the system to grow without fear

OCP is one of the most important SOLID principles because it avoids constantly modifying already tested and stable code, improving software quality as a whole.