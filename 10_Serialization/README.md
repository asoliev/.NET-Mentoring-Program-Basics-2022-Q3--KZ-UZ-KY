# Serialization
https://learn.epam.com/myLearning/program?groupGuid=b4184d1c-6350-42d6-bacc-43814944979a

Questions for the self-check:
1.	What is serialization?
2.	Give examples where serialization is used?
3.	When binary/XML/Json serialization need to be used? What are the main advantages of binary/XML/Json serialization?
4.	When is custom serialization needed? How can custom serialization be implemented?

### Task1:
Create an empty solution. Add three Console applications for three subtasks:
- Binary serialization
- XML serialization
- Json serialization

On all subtasks create class Employee with string EmpoyeeName and class Department with string DepartmentName and list of Employees.
On the Main method serialize a Department object, write the serialized object to the file, and deserialize it from the file.
Add some attributes to control how properties are serialized for XML and Json formats.

### Task2:
Create a new Console application. Create one simple class with two properties. By implementing ISerializable provide your own binary serialization mechanism.

### Task3:
Create a new Console application. Create Employee and Department classes from Task1 and implement Deep Cloning using serialization. Make sure that cloned objects are completely independent.

### NB! Scoreboard:
- 1-3 stars – Task1 was implemented
- 4 stars – Tasks 1 and 2 were implemented.
- 5 stars – All three tasks were implemented.