--1.How many products can you find in the Production.Product table?
Select Count(*)
From Production.Product 

--2.Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.
Select Count(*)
From Production.Product
Where ProductSubcategoryID is Not Null


--3.How many Products reside in each SubCategory? Write a query to display the results with the following titles.ProductSubcategoryID CountedProducts
Select ProductSubcategoryID, Count(ProductSubcategoryID) [ProductSubcategoryID CountedProducts]
From Production.Product
Where ProductSubcategoryID Is Not Null
Group By ProductSubcategoryID


--4.How many products that do not have a product subcategory.
Select Count(*)
From Production.Product
Where ProductSubcategoryID Is Null


--5.Write a query to list the sum of products quantity in the Production.ProductInventory table.
Select Sum(Quantity)
From Production.ProductInventory


--6.Write a query to list the sum of products in the Production.ProductInventory table and LocationID 
--set to 40 and limit the result to include just summarized quantities less than 100.
Select ProductID, Sum(Quantity) [The Sum]
From Production.ProductInventory
Where LocationID = 40
Group By ProductID
Having Sum(Quantity) < 100


--7. Write a query to list the sum of products with the shelf information in the Production.ProductInventory 
--table and LocationID set to 40 and limit the result to include just summarized quantities less than 100
Select Shelf, ProductID,  Sum(Quantity) [The Sum]
From Production.ProductInventory
Where LocationID = 40
Group By  Shelf,ProductID
Having Sum(Quantity) < 100



--8.Write the query to list the average quantity for products where column LocationID has the value of 10 from the table Production.ProductInventory table.
Select AVG(Quantity)
From Production.ProductInventory
Where LocationID = 10


--9.Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory
Select ProductID, Shelf, AVG(Quantity) [TheAvg]
From Production.ProductInventory
Group By ProductID, Shelf


--10.Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A in the column Shelf from the table Production.ProductInventory
Select ProductID, Shelf, AVG(Quantity) [TheAvg]
From Production.ProductInventory
Where Shelf <> 'N/A'
Group By ProductID, Shelf


--11.List the members (rows) and average list price in the Production.Product table. This should be grouped independently over the Color and the Class column. 
--Exclude the rows where Color or Class are null.
Select Color, Class, Count(*) [The Count], Avg(ListPrice) [AvgPrice]
From Production.Product
Where Color Is Not Null And Class Is Not Null
Group By Color, Class



--12.Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. 
--Join them and produce a result set similar to the following
Select Distinct c.Name [Country], s.Name [Province]
From Person.StateProvince s Inner Join Person.CountryRegion c
On s.CountryRegionCode = c.CountryRegionCode


--13.Write a query that lists the country and province names from person. CountryRegion and person. 
--StateProvince tables and list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.
Select Distinct c.Name [Country], s.Name [Province]
From Person.StateProvince s Inner Join Person.CountryRegion c
On s.CountryRegionCode = c.CountryRegionCode
Where c.Name In ('Germany','Canada')



-- Using Northwnd Database: (Use aliases for all the Joins)
--14.List all Products that has been sold at least once in last 25 years.
Select Distinct p.ProductName
From Products p Inner Join [Order Details] od
On p.ProductID = od.ProductID
Inner Join Orders o
On o.OrderID = od.OrderID
Where o.OrderDate Between '1995-10-21' and '2020-10-21'


--15.List top 5 locations (Zip Code) where the products sold most.
Select Top 5 ShipPostalCode
From Orders
Group by ShipPostalCode 
Order by Count(ShipPostalCode) Desc


--16.List top 5 locations (Zip Code) where the products sold most in last 25 years.
Select Top 5 ShipPostalCode
From Orders
Where OrderDate Between '1995-10-21' and '2020-10-21'
group by ShipPostalCode
order by count(ShipPostalCode) Desc



--17.List all city names and number of customers in that city.    
Select Distinct City, Count(CustomerID) [Number of Customers]
From Customers
Group By City



--18.List city names which have more than 2 customers, and number of customers in that city
Select Distinct City, Count(CustomerID) [Number of Customers]
From Customers
Group By City
Having Count(CustomerID) > 2


--19.List the names of customers who placed orders after 1/1/98 with order date.
Select Distinct c.ContactName
From Orders o Inner Join Customers c
On o.CustomerID = c.CustomerID
where OrderDate between '1998-01-01' and '2020-10-21'


--20.List the names of all customers with most recent order dates
Select c.ContactName, Max(o.OrderDate)
From Customers c Inner Join Orders o
On c.CustomerID = o.CustomerID
Group By c.ContactName



--21.Display the names of all customers  along with the  count of products they bought
Select c.ContactName, Count(o.OrderID) [Count of Products]
From Customers c Inner Join Orders o
On c.CustomerID = o.CustomerID
Group By c.ContactName


--22.Display the customer ids who bought more than 100 Products with count of products.
Select c.ContactName, Sum(od.Quantity) [Count of Products]
From Customers c Inner Join Orders o
On c.CustomerID = o.CustomerID
Inner Join [Order Details] od
On o.OrderID = od.OrderID
Group By c.ContactName
Having Sum(od.Quantity) > 100



--23.  List all of the possible ways that suppliers can ship their products. Display the results as below
Select su.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
From Suppliers su Cross Join  Shippers sh 



--24.Display the products order each day. Show Order date and Product Name.
Select Distinct o.OrderDate, p.ProductName
From Products p Inner Join [Order Details] od
On p.ProductID = od.ProductID
Inner Join Orders o
On od.OrderID = o.OrderID



--25.Displays pairs of employees who have the same job title.
Select *
From Employees e Inner Join Employees m
On e.Title = m.Title



--26.Display all the Managers who have more than 2 employees reporting to them.
Select e.EmployeeID, e.FirstName + ' ' + e.LastName [Employee Name], e.Title, count(m.ReportsTo) [Total]
From Employees e Inner Join Employees m
On e.EmployeeID = m.ReportsTo
Where e.Title Like '%Manager%'
Group By e.EmployeeID, e.FirstName, e.LastName, e.Title
Having count(m.ReportsTo) > 2



--27.Display the customers and suppliers by city. The results should have the following columns
Select city, CompanyName [Name], ContactName, 'Customer' as Type From Customers
Union
Select city, CompanyName [Name], ContactName, 'Supplier' as Type  From Suppliers
