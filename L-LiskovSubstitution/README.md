# 🟣 Liskov Substitution Principle (LSP)
📌 What is the Liskov Substitution Principle?

The Liskov Substitution Principle (LSP) states that:

       Objects of a superclass should be replaceable with objects of its subclasses without breaking the correctness of the application.

In practice, this means:

-  derived class must fully honor the behavior expected by the base class
- Client code should not need to know which concrete implementation it is using
- Inheritance should preserve behavior contracts, not only structure
 
## ❌ Before — Legacy Code Violating LSP

Imagine a banking system where every bank account is expected to allow withdrawals. At first glance, this seems correct.

- The Problem
   - Client code trusts the contract defined by BankAccount:
   - Now replacing the base class with a derived class causes the system to fail:

🚨 Runtime Exception
The derived class changes the expected behavior of the base class.
This means:

- BankAccount promises that withdrawals are supported
- SalaryAccount breaks that promise
- Client code becomes dependent on concrete implementations

This is a direct violation of the Liskov Substitution Principle.

## ✅ After — Applying the Liskov Substitution Principle

The refactor starts with a simple question:

      Should every bank account support withdrawals?

The answer is no.

Therefore, the withdrawal behavior should not belong to the base abstraction.

Now:

- Only accounts that truly support withdrawals can be used
- Invalid substitutions are impossible
- Errors are prevented at compile time instead of runtime

## 🎯 Real Benefits of Applying LSP

✅ More predictable code behavior
✅ Safer inheritance hierarchy
✅ Better domain modeling
✅ Fewer runtime exceptions
✅ Clear and reliable contracts
✅ Reduced coupling between client code and implementations
✅ Easier maintenance and scalability

## 🧠 Conclusion

The Liskov Substitution Principle teaches us that inheritance is not just about:

     “is-a” relationships

It is mainly about:

     honoring behavioral contracts.

If a derived class needs to throw exceptions, disable features, or change expected behavior from the base class, it is usually a sign that:

- the inheritance hierarchy is incorrect
- the abstraction was poorly designed
- responsibilities should be separated

Applying LSP results in software that is more reliable, extensible, and easier to maintain.