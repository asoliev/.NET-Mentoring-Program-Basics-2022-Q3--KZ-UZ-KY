# ADO.NET-Fundamentals
 https://learn.epam.com/myLearning/program?groupGuid=d8951fce-b848-42aa-99c1-606b443aed19&tab=panels

Questions for the self-check:
1.	What is ADO.NET?
2.	Explain the difference between terms: connected model and disconnected model?
3.	When do we need to use a DataReader and a DataSet?
4.	What do we need to use data providers for?
5.	What do we need to use transactions for?

Database scheme:

![image](https://user-images.githubusercontent.com/91322310/209474539-b8588d5f-397b-48d5-ba6b-985e8e430098.png)

Statuses: NotStarted, Loading, InProgress, Arrived, Unloading, Cancelled, Done.

### Functional requirements:
Create library and linked test library which cover following requirements:
1.	Ability to perform CRUD operations on product.
2.	Ability to perform CRUD operations on order.
3.	Ability to fetch all products.
4.	Ability to fetch orders (consider filtration by month, status, year or specific product, use stored procedure).
5.	Ability to delete orders in bulk (on the same conditions as in item 4).

### NB! Scoreboard:
- 1-3 stars – DB, Library and test library with the requested functionality was created.
- 4 stars - Connected and disconnected models were used.
- 5 stars - Transaction for bulk delete requirement was used.