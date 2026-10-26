Assignment 3: Exception Handling - Answers

Question 1: What is the purpose of the try and catch blocks?
Answer: 
- The try block encloses code that is prone to runtime errors or exceptions.
- The catch block intercepts and handles those exceptions gracefully, preventing the program from crashing and allowing it to display meaningful error messages instead.

Question 2: Explain the difference between throw and throws.
Answer: 
- throw is used explicitly inside a method body to throw a specific exception instance.
- throws is used in a method signature to declare that the method might throw certain exceptions, delegating the responsibility of handling them to the calling method.

Question 3: What is the purpose of the finally block?
Answer: 
- The finally block guarantees execution of critical code (such as closing Scanners, streams, or releasing resources) regardless of whether an exception was thrown, caught, or neither.

Question 4: Why is a custom exception useful in this application?
Answer: 
- A custom exception (such as InvalidRegistrationException) allows the program to enforce specific business logic rules (like age requirements, mark ranges, or subject limits) and throw tailored, domain-specific error messages.
