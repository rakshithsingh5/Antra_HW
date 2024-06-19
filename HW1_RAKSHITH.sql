--1Q
SELECT ProductID, [Name], Color, ListPrice
FROM Production.Product

--2Q
SELECT ProductID, [Name], Color, ListPrice
FROM Production.Product
WHERE ListPrice != 0

--3Q
SELECT ProductID, [Name], Color, ListPrice
FROM Production.Product
WHERE Color IS NULL

--4Q
SELECT ProductID, [Name], Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--5Q
SELECT ProductID, [Name], Color, ListPrice
FROM Production.Product
WHERE Color IS NOT NULL AND ListPrice > 0

--6Q
SELECT [Name] +' & '+  Color AS [Name and color]
FROM Production.Product
WHERE Color IS NOT NULL

--7Q
SELECT TOP 6 'NAME: '+ [NAME] +' -- '+ 'COLOR: '+ Color AS [Name and color]
FROM Production.Product
WHERE Color IS NOT NULL

--8Q
SELECT ProductID, [Name]
FROM Production.Product
WHERE ProductID BETWEEN 400 and 500

--9Q
SELECT ProductID, [Name], Color
FROM Production.Product
WHERE Color IN ('black', 'blue')

--10Q
SELECT [Name]
FROM Production.Product
WHERE [Name] LIKE 'S%'

--11Q
SELECT TOP 6 [Name], ListPrice
FROM Production.Product
WHERE [NAME] LIKE 'S%'
ORDER BY [Name]

--12Q
SELECT TOP 5 [Name], ListPrice
FROM Production.Product
WHERE [Name] LIKE 'S%' OR Name LIKE 'A%'
ORDER BY [Name]

--13Q
SELECT [Name], ListPrice
FROM Production.Product
WHERE [Name] LIKE 'SPO[^K]%'
ORDER BY [Name]

--14Q
SELECT DISTINCT Color
FROM Production.Product
WHERE Color IS NOT NULL
ORDER BY Color DESC

--15Q
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE Color IS NOT NULL AND ProductSubcategoryID IS NOT NULL
ORDER BY ProductSubcategoryID, Color
