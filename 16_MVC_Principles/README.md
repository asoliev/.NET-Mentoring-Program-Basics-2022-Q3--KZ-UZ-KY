# MVC_Principles
 https://learn.epam.com/myLearning/program?groupGuid=d8951fce-b848-42aa-99c1-606b443aed19

## Description
You should create a website that enables operations with the Northwind Database (script with DB structure and test data can be found here - https://github.com/microsoft/sql-server-samples/blob/master/samples/databases/northwind-pubs/instnwnd.sql) .

### Task 1: Base site

Create a web site with the following pages:

1. The Home page that contains a welcome message and links to other pages

2. The Categories page that shows a list of categories without images

3. The Products page that shows a table with the products

4. The table contains all product fields

5. Instead of the references to Category and Supplier, their names should be shown

Note: All configuration parameters (connection strings, etc.) can remain in the code (hardcoded)

### Task 2: Startup and configuration

Add a configuration feature that supports two parameters:

1. Database connection string

2. Maximum (M) number of products shown on the Product page (show only first M products, others – ignored; if M == 0, then show all products)

### Task 3: Edit forms and Server-side validation

Add edit forms (New and Update) for the Products:

1. Related entities (such as Category) should be presented as a dropdown list

2. Add server-side validation for edited products (not less than 3 different rules)

### NB! Scoreboard:

1-3 stars – Task 1 was completed.
4 stars – Tasks 1-2 were completed.
5 stars – Tasks 1-3 were completed