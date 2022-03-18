--1.List all cities that have both Employees and Customers.
Select Distinct City
From Customers
Where City In(Select City From Employees)

Select Distinct c.City
From Customers c Inner Join Employees e
On c.City = e.City

--2List all cities that have Customers but no Employee.
--a.      Use sub-query
Select Distinct City
From Customers
Where City Not In(Select City From Employees)

--b.      Do not use sub-query
Select Distinct c.City
From Customers c Left Join Employees e
On c.City = e.City


--3.  List all products and their total order quantities throughout all orders.
Select p.ProductName, Sum(od.Quantity) [Total]
From Orders o Left Join [Order Details] od
On o.OrderID = od.OrderID
Left Join Products p
On od.ProductID = p.ProductID
Group By p.ProductName
Order By Total Asc


--4.  List all Customer Cities and total products ordered by that city.
Select c.City, Sum(od.Quantity) [Total Products]
From Customers c Inner Join Orders o
On c.CustomerID = o.CustomerID
Inner Join [Order Details] od
On o.OrderID = od.OrderID
Group By c.City


--5. List all Customer Cities that have at least two customers.
--a.      Use union
Select c.City From Customers c Group By c.City Having COUNT(c.City) > 2
Union
Select cu.City From Customers cu Group By cu.City Having COUNT(cu.City) = 2

--b.      Use sub-query and no union
Select Distinct c.City
From Customers c
Where c.City In(Select cu.City From Customers cu Group By cu.City Having Count(cu.City) >= 2)


--6.List all Customer Cities that have ordered at least two different kinds of products.
Select Distinct c.City
From Customers c Inner Join Orders o
On c.CustomerID = o.CustomerID
Inner Join [Order Details] od
On o.OrderID = od.OrderID
Group By c.City
Having count(od.ProductID) > 2



--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities.
Select *
From Customers c
Where c.City Not In(Select o.Shipcity From Orders o Inner Join Customers c On o.ShipCity=c.City)


--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
With cte_TopFive
as(
Select  t.ShipCity, t.ProductName, t.ProductID, t.Average
From(Select Top 5 o.ShipCity, p.ProductName, od.ProductID, Sum(od.Quantity) total, Avg(od.UnitPrice) Average From Orders o Inner Join [Order Details] od On o.OrderID = od.OrderID
Inner Join Products p On p.ProductID = od.ProductID
Group By o.ShipCity,p.ProductName, od.ProductID
Order By total Desc
)t)
Select * From cte_TopFive;


--9.List all cities that have never ordered something but we have employees there.
--a.      Use sub-query
Select e.City
From Employees e
Where e.City Not In(Select c.City From Customers c Inner Join Orders o On c.CustomerID=o.CustomerID)

--b.      Do not use sub-query
Select e.City
From Employees e Left Join Customers c
On e.City = c.City
Where c.City is Null


--10.List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
Select * From
(Select Top 1 e.City, Count(o.OrderId) [Total] From Employees e Inner Join Orders o On e.EmployeeID = o.EmployeeID Group By e.City ) dt
Inner Join
(Select Top 1 c.City, Count(od.Quantity) [Total Qty] From Customers c Inner Join Orders o On c.CustomerID = o.CustomerID 
Inner join [Order Details] od On o.OrderID = od.OrderID Group By c.City ) dtt
On dt.City = dtt.City



--11.How do you remove the duplicates record of a table?
--Using Group By or Row_Number then use DELETE statment to remove duplicates