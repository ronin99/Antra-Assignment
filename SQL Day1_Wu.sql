--1.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, with no filter
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p


--2.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, excludes the rows that ListPrice is 0
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.ListPrice != 0


--3.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are NULL for the Color column
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color IS  NULL


--4.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the Color column.
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color IS Not NULL


--5.Write a query that retrieves the columns ProductID, Name, Color and ListPrice from the Production.Product table, the rows that are not NULL for the column Color, 
--and the column ListPrice has a value greater than zero
Select p.ProductID, p.Name, p.Color, p.ListPrice
From Production.Product p
Where p.Color IS Not NULL AND p.ListPrice > 0

--6.Write a query that concatenates the columns Name and Color from the Production.Product table by excluding the rows that are null for color.
Select p.Name + ' ' + p.Color  as [Name And Color]
From Production.Product p
Where p.Color IS Not Null


--7.Write a query that generates the following result set  from Production.Product:
Select 'NAME: ' + p.Name + ' -- COLOR: ' + p.Color  as [Name And Color]
From Production.Product p
Where p.Color Between 'Black' AND 'Silver'  AND p.Name  LIKE '%Crankarm%' or p.Name Like '%Chainring%'

--8.Write a query to retrieve the to the columns ProductID and Name from the Production.Product table filtered by ProductID from 400 to 500
Select p.ProductID, p.Name
From Production.Product p
Where p.ProductID Between 400 And 500


--9.Write a query to retrieve the to the columns  ProductID, Name and color from the Production.Product table restricted to the colors black and blue
Select p.ProductID, p.Name, p.Color
From Production.Product p
Where p.Color Between 'Black' AND 'Blue' 


--10.Write a query to get a result set on products that begins with the letter S. 
Select p.ProductID, p.Name, p.Color
From Production.Product p
Where p.Name LIKE 'S%'


--11.Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
--Your result set should look something like the following. Order the result set by the Name column.
Select p.ProductID, p.Name, p.ListPrice
From Production.Product p
Where p.Name LIKE 'S%' Order By Name


--12. Write a query that retrieves the columns Name and ListPrice from the Production.Product table. 
--Your result set should look something like the following. Order the result set by the Name column. The products name should start with either 'A' or 'S'
Select p.Name, p.ListPrice
From Production.Product p
Where p.name Like 'A%' Or p.Name Like 'S%' Order By Name

--13.Write a query so you retrieve rows that have a Name that begins with the letters SPO, but is then not followed by the letter K. 
--After this zero or more letters can exists. Order the result set by the Name column.
Select p.Name, p.ListPrice
From Production.Product p
Where p.Name Like 'SPO[^K]%' Order By Name

--14.Write a query that retrieves unique colors from the table Production.Product. Order the results  in descending  manner
Select Distinct p.Color
From Production.Product p 
Order By Color Desc

--15.Write a query that retrieves the unique combination of columns ProductSubcategoryID and Color from the Production.Product table. 
--Format and sort so the result set accordingly to the following. We do not want any rows that are NULL.in any of the two columns in the result.
Select Distinct p.Color, p.ProductSubcategoryID
From Production.Product p 
Where p.Color is NOT NULL and p.ProductSubcategoryID is Not NULL