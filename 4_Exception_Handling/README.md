# Exception-Handling
 https://learn.epam.com/myLearning/program?groupGuid=b4184d1c-6350-42d6-bacc-43814944979a

Questions for the self-check:
1.	What is the purpose of Exception Handling in C#?
2.	Can a try block have multiple catch blocks?
3.	Describe a flow how exceptions are handled?
4.	What is the base class from which all exceptions are derived?
5.	What is the difference between Exception and Inner Exception?
6.	What is the difference between throw ex; and throw; statements?
7.	What is the purpose of finally statement?
8.	What predefined .NET Exceptions do you know?
9.	Is there a way to create a custom exception?

### Task 1:

Open Program class under Task1 project and implement a method that prints the first character of each entered input line. Use exception handling mechanism to validate input for empty string.

### Task 2:

Open NumberParser class under Task2 project and implement Parse method to convert a string value to integer.

It is NOT allowed to use int.Parse(), int.TryParse() or any other built-in conversion methods.

Error handling should be implemented. All unit tests should pass successfully.

### Task 3 (Optional):

Open UserTaskController and UserTaskService classes under Task3 project and change code-based error handling to exception-based one. If you notice any violations of open/close principle, fix them.

No changes in the code under DoNotChange folder are expected. All unit tests should pass successfully.
