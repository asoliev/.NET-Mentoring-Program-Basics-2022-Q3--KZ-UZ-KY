# SqlFundamentals

Questions for the self-check:
1.	What is the difference between primary and secondary keys? How many primary keys are available for the table? How many secondary keys are available for the table?
2.	What is the difference between clustered and non-clustered indexes?
3.	What is a transaction?
4.	What is a trigger? How to create a trigger?
5.	What is the difference between INNER JOIN, RIGHT JOIN and LEFT JOIN?
6.	What is a stored procedure? How to create a SP?
7.	What is a view? How to create a view? What is the difference between view and table?

### Task 1:
Create a SQL DB project in VS2019 with the structure of the following tables:
-	Person
    1.	Id, int, not NULL, PK
    2.	FirstName, nvarchar(50), not NULL
    3.	LastName, nvarchar(50), not NULL
-	Address
    1.	Id, int, not NULL, PK
    2.	Street, nvarchar(50), not NULL
    3.	City, nvarchar(20), NULL
    4.	State, nvarchar(50), NULL
    5.	ZipCode, nvarchar(50), NULL
-	Employee
    1.	Id, int, not NULL, PK
    2.	AddressId, int, not NULL, FK (Address.Id)
    3.	PersonId, int, not NULL, FK (Person.Id)
    4.	CompanyName, nvarchar(20), not NULL
    5.	Position, nvarchar(30), NULL
    6.	EmployeeName, nvarchar(100), NULL
-	Company
    1.	Id, int, not NULL, PK
    2.	Name, nvarchar(20), not NULL
    3.	AddressId, int, not NULL, FK (Address.Id)

Publish DB into SQL Server with default information (create Script.postdeploy*.sql and fill once all tables with the appropriate data)

### Task 2:
Create ‘EmployeeInfo’ view to show data with the following structure that is sorted by ‘CompanyName, City’ ASC:
- EmployeeId,
- EmployeeFullName (EmployeeName (if not null) or ‘{FirstName} {LastName}’),
- EmployeeFullAddress(‘{ZipCode}_{State}, {City}-{Street}’)
- EmployeeCompanyInfo(‘{CompanyName}({Position})’)

### Task 3:
Create a stored procedure to insert Employee info into DB with the following params:
1.	EmployeeName(optional)
2.	FirstName(optional)
3.	LastName(optional)
4.	CompanyName(required)
5.	Position(optional)
6.	Street(required)
7.	City(optional)
8.	State(optional)
9.	ZipCode(optional)

And the following conditions:
1.	At least one field (either EmployeeName  or FirstName or LastName) should be not be:
    1.	NULL
    2.	empty string
    3.	contains only ‘space’ symbols
2.	CompanyName should be truncated if length is more than 20 symbols

### Task 4:
Create a trigger for Employee table on insert new Row that will create a new Company with an Address (The address should be copied from the employee’s address).

### NB! Scoreboard:
- 1-4 stars – Task 1-3 were implemented.
- 5 stars – Task 4 task was implemented.