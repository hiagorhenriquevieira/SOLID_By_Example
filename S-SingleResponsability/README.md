# S-SingleResponsability
A class should have one, only one, reason to change.
------ 
##📘 What is SRP?

The Single Responsibility Principle states that:

| A class, module, or function should have only one reason to change, meaning it should have one clear responsibility.

This helps keep your code:

- Easier to maintain

- Easier to test

- Less fragile

- More reusable

- More modular

##❌ Before (Violation of SRP)

In the Antes/ folder, you will find a class that:

- Handles business logic

- Calculates totals

- Logs information

- Sends notifications

- Saves data to a database

All in a single file.
This makes the code tightly coupled and hard to extend.

##🔍 How to Identify SRP Violations

A class might violate SRP when it:

- Has an “AND” in the responsibility description

    - Handles logic AND persistence
 
- When your code has more than one context

- Has methods unrelated to each other

- Is described as “God class” or “Manager class”

If a class has multiple reasons to change, SRP is being violated.

##📌 Why SRP Matters

✔ Reduces bugs
✔ Improves readability
✔ Allows unit testing isolated behaviors
✔ Improves modularity
✔ Makes the system more flexible to future changes
✔ Reduces coupling

##📚 Related Principles

- OCP — Changes become safer when responsibilities are isolated

- DIP — SRP complements dependency inversion naturally

- ISP — Smaller interfaces often force SRP