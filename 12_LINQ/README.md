# LINQ
 https://learn.epam.com/myLearning/program?groupGuid=d8951fce-b848-42aa-99c1-606b443aed19&tab=panels

Questions for the self-check:
1.	What is LINQ? What is it used for?
2.	When are query expressions executed? What is materialization in LINQ? Name query methods which lead to query execution.
3.	What is query syntax? What is the method syntax?
4.	When is query syntax converted to method calls?
5.	If query expression syntax does not have some operations, for example Count or Max, how to combine query syntax with method calls?
6.	Which are basic LINQ query operations?
7.	How do you transform data with LINQ?
8.	What is LINQ to Objects?
9.	Can you project a query to an anonymous type?



You are given a solution (LINQ.zip) containing the task project and the tests. Your task is to implement methods in LinqTask class following instructions from the list below until the tests are green.

Queries:

1. Select the customers whose total turnover (the sum of all orders) exceeds a certain value.

2. For each customer make a list of suppliers located in the same country and the same city. Compose queries with and without grouping.

3. Find all customers with the sum of all orders that exceed a certain value.

4. Select the clients, including the date of their first order.

5. Repeat the previous query but order the result by year, month, turnover (descending) and customer name.

6. Select the clients which either have:
    <ol type="a">
      <li>non-digit postal code</li>
      <li>undefined region</li>
      <li>operator code in the phone is not specified (does not contain parentheses)</li>
    </ol>

7. Group the products by category, then by availability in stock with ordering by cost.

8. Group the products by “cheap”, “average” and “expensive” following the rules:
    <ol type="a">
      <li>From 0 to cheap inclusive</li>
      <li>From cheap exclusive to average inclusive</li>
      <li>From average exclusive to expensive inclusive</li>
    </ol>

9. Calculate the average profitability of each city (average amount of orders per customer) and average rate (average number of orders per customer from each city).

10. Build a string of unique supplier country names, sorted first by length and then by country.

### NB! Scoreboard:
- 1-3 stars – 5 green tests.
- 4 stars - 8 green tests.
- 5 stars - all tests are green.