--1Q
SELECT DISTINCT e.City
FROM Employees e
JOIN Customers c ON e.City = c.City
ORDER BY e.City

--2Q
--using sub query
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN (SELECT DISTINCT e.City FROM Employees e)
ORDER BY c.City

--without using sub-query
SELECT DISTINCT c.City
FROM Customers c LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL
ORDER BY c.City

--3Q
SELECT p.ProductName, SUM(od.Quantity) AS TotalOrderQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName
ORDER BY TotalOrderQuantity DESC

--4Q
SELECT c.City, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY TotalProductsOrdered DESC, c.City

--5Q
--using union
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2
UNION
SELECT City
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2

--using sub-query and no union
SELECT DISTINCT City
FROM Customers
WHERE City IN (
    SELECT City
    FROM Customers
    GROUP BY City
    HAVING COUNT(CustomerID) >= 2
)
ORDER BY City

--6Q
SELECT c.City, COUNT(p.ProductID) As [Different kinds of orders]
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
GROUP BY c.City
HAVING COUNT(DISTINCT p.ProductID) >= 2
ORDER BY c.City

--7Q
SELECT c.CustomerID , c.CompanyName, c.City AS CustomerCity, o.ShipCity AS OrderShipCity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City NOT IN (o.ShipCity)
ORDER BY c.CustomerID

--8Q
SELECT TOP 5 p.ProductName,
    AVG(od.UnitPrice) AS AveragePrice,
    (
        SELECT TOP 1 c.City
        FROM Customers c
        JOIN Orders o ON c.CustomerID = o.CustomerID
        JOIN [Order Details] od2 ON o.OrderID = od2.OrderID
        WHERE od2.ProductID = p.ProductID
        GROUP BY c.City
        ORDER BY SUM(od2.Quantity) DESC
    ) AS [Most Popular Customer City]
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName, p.ProductID
ORDER BY SUM(od.Quantity) DESC


--9Q
--using subquery
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT o.ShipCity
    FROM Orders o
)
ORDER BY e.City

--without using sub-query
SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Orders o ON e.City = o.ShipCity
WHERE o.ShipCity IS NULL
ORDER BY e.City

--10Q
SELECT EmployeeCity, MostQuantityCity
FROM (SELECT TOP 1 e.City AS EmployeeCity, COUNT(o.OrderID) AS OrderCount
    FROM Employees e JOIN Orders o ON e.EmployeeID = o.EmployeeID
    GROUP BY e.City
    ORDER BY COUNT(o.OrderID) DESC) AS EmployeeCityResult,

    (SELECT TOP 1 c.City AS MostQuantityCity, SUM(od.Quantity) AS TotalQuantity
    FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY c.City
    ORDER BY SUM(od.Quantity) DESC) AS MostQuantityCityResult

--11Q
/*
There are two common methods to delete/ remove duplicate records from sql server.

METHOD 1: 
1. In the first method we sue to create a temporary table to store duplicate rows.
2. After inserting the duplicate records, deleting the duplicate records happen and finally the unique records 
will be inserted into the original table.
3. Finally temp table is dropped.
*/

--here is an script to delete the record
SELECT DISTINCT *
INTO duplicate_table
FROM original_table
GROUP BY key_value
HAVING COUNT(key_value) > 1

DELETE original_table
WHERE key_value
IN (SELECT key_value
FROM duplicate_table)

INSERT original_table
SELECT *
FROM duplicate_table

DROP TABLE duplicate_table

/*
METHOD 2: USING ROW_NUMBER
1. The query removes duplicate records from a table by assigning a sequential rank to each row within groups of the same key value 
and then deletes all rows except the first occurrence of each group.
2. Uses the ROW_NUMBER function to partition the data based on the key_value which may be one or more columns separated by commas.
3.Deletes all records that received a DupRank value that is greater than 1.
4.This value indicates that the records are duplicates.
*/
--Example script
DELETE T
FROM
(
SELECT *
, DupRank = ROW_NUMBER() OVER (
              PARTITION BY key_value
              ORDER BY (SELECT NULL)
            )
FROM original_table
) AS T
WHERE DupRank > 1
