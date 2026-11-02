1. Open SQL Server Management Studio (or an equivalent SQL Management Software)
2. Connect to Northwind DB (Same DB as you used in Geek Week)
3. Write a query that shows each employee’s first name and the number of orders they have placed. Group the results by employee’s first name.

Please add your SQL query below AND add explanation of the query: 

```

[Insert Code Here]
```
SELECT 
    FirstName, 
    COUNT(OrderID) AS NumberOfOrders
FROM 
    Employees
INNER JOIN 
    Orders ON Employees.EmployeeID = Orders.EmployeeID
GROUP BY 
    FirstName;

```
[Insert Explanation Here]
```Explanation of the Query:
- SELECT FirstName, COUNT(OrderID): This selects the employee's first name and counts the total number of unique orders associated with them. The COUNT() function is given an alias 'NumberOfOrders' to make the output easy to read.
- FROM Employees INNER JOIN Orders: The employee information lives in the 'Employees' table, while the order details live in the 'Orders' table. We use an INNER JOIN to link these two tables together.
- ON Employees.EmployeeID = Orders.EmployeeID: This specifies the matching key between both tables, ensuring each order is correctly mapped to the specific employee who placed it.
- GROUP BY FirstName: Because we are using an aggregate function (COUNT), we use the GROUP BY clause to aggregate the order counts individually for each unique employee first name.


4. For submission commit and push this .md file to Github
