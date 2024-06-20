--1Q
SELECT COUNT(ProductID) AS [number of products]
FROM Production.Product

--2Q
SELECT COUNT(*) As  [number of products in ProductSubcategory that are not null]
FROM Production.Product 
WHERE ProductSubcategoryID IS NOT NULL

--3Q
SELECT ProductSubcategoryID, COUNT(ProductID) AS CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL
GROUP BY ProductSubcategoryID
ORDER BY ProductSubcategoryID

--4Q
SELECT COUNT(*) As  [number of products in ProductSubcategory that are null]
FROM Production.Product 
WHERE ProductSubcategoryID IS NULL

--5Q
SELECT SUM(Quantity) As [Sum of Product Quantity]
FROM Production.ProductInventory

--6Q
SELECT ProductID, SUM(Quantity) As [Sum]
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--7Q
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY Shelf, ProductID
HAVING SUM(Quantity) < 100

--8Q
SELECT AVG(Quantity) AS [Avg Quantity for products]
FROM Production.ProductInventory
WHERE LocationID = 10

--9Q
SELECT ProductID, Shelf, AVG(Quantity) AS [Avg Quantity for products]
FROM Production.ProductInventory
GROUP BY ProductID, Shelf

--10Q
SELECT ProductID, Shelf, AVG(Quantity) AS [Avg Quantity for products]
FROM Production.ProductInventory
WHERE Shelf <> 'N/A'
GROUP BY ProductID, Shelf

--11Q
SELECT Color, Class, COUNT(*) AS [count], AVG(ListPrice) AS [Avg Price]
FROM Production.Product
WHERE Color IS NOT NULL AND Class IS NOT NULL
GROUP BY Color, Class

--12Q
SELECT a.Name AS Country, b.Name AS Province
FROM Person.CountryRegion a JOIN Person.StateProvince b ON a.CountryRegionCode = b.CountryRegionCode
ORDER BY a.Name, b.Name

--13Q
SELECT a.Name AS Country, b.Name AS Province
FROM Person.CountryRegion a JOIN Person.StateProvince b ON a.CountryRegionCode = b.CountryRegionCode
WHERE a.Name IN ('Germany','Canada')
ORDER BY a.Name, b.Name

--14Q
SELECT DISTINCT p.ProductName
FROM dbo.Products p INNER JOIN dbo.[Order Details] o ON p.ProductID = o.ProductID INNER JOIN Orders ord ON o.OrderID = ord.OrderID
WHERE ord.OrderDate >= DATEADD(YEAR, -27, GETDATE());

--15Q
SELECT TOP 5 o.ShipPostalCode, COUNT(od.OrderID) AS [total order]
FROM dbo.[Order Details] od JOIN Orders o ON o.OrderID = od.OrderID
GROUP BY o.ShipPostalCode
ORDER BY [total order] DESC

--16Q
SELECT TOP 5 o.ShipPostalCode, COUNT(od.OrderID) AS [total order]
FROM dbo.[Order Details] od JOIN Orders o ON o.OrderID = od.OrderID
WHERE o.OrderDate >= DATEADD(YEAR, -27, GETDATE())
GROUP BY o.ShipPostalCode
ORDER BY [total order] DESC

--17Q
SELECT ShipCity, COUNT(CustomerID) AS [No of customers]
FROM dbo.Orders
GROUP BY ShipCity

--18Q
SELECT ShipCity, COUNT(CustomerID) AS [No of customers]
FROM dbo.Orders
GROUP BY ShipCity
HAVING COUNT(CustomerID) > 2 

--19Q
SELECT c.ContactName, o.OrderDate
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderDate > '1998-01-01'

--20Q
SELECT c.ContactName, o.MostRecentOrderDate
FROM dbo.Customers c
JOIN(   SELECT CustomerID, MAX(OrderDate) AS MostRecentOrderDate
        FROM dbo.Orders
        GROUP BY CustomerID
    ) o ON c.CustomerID = o.CustomerID

--21Q
SELECT c.ContactName, COUNT(od.OrderID) AS ProductCount
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.ContactName

--22Q
SELECT c.CustomerID, COUNT(od.OrderID) AS ProductCount
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING COUNT(od.OrderID)>100

--23Q


--24Q


--25Q
SELECT e1.EmployeeID AS Employee1ID, e1.FirstName AS Employee1Name, e2.EmployeeID AS Employee2ID,
e2.FirstName AS Employee2Name, e1.Title 
FROM dbo.Employees e1 JOIN dbo.Employees e2 ON e1.Title = e2.Title
WHERE e1.EmployeeID < e2.EmployeeID

--26Q
SELECT Manager.EmployeeID, Manager.FirstName AS ManagerName, COUNT(DISTINCT e.EmployeeID) AS NumberOfEmployees
FROM Employees Manager JOIN Employees e ON Manager.EmployeeID = e.ReportsTo
WHERE Manager.ReportsTo IS NULL
GROUP BY Manager.EmployeeID, Manager.FirstName
HAVING COUNT(DISTINCT e.EmployeeID) > 2

--27Q
