--1. Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
Create View  view_product_order_Wu As
Select p.ProductID, p.ProductName, Sum(od.Quantity) [Total Quantity] 
From Products p Inner Join [Order Details] od On p.ProductID = od.ProductID
Group By p.ProductID, p.ProductName


Select * From view_product_order_Wu

Drop View view_product_order_Wu




--2.Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and total quantities of order as output parameter.
Create Proc sp_product_order_quantity_Wu
@product_id int,
@product_quantity int Output
As
Begin
Select @product_quantity = Sum(od.Quantity)
From [Order Details] od 
Where od.ProductID = @product_id
End


Declare @totoal_quantity int 
Exec sp_product_order_quantity_Wu 16,@totoal_quantity Out
Print @totoal_quantity

Drop  procedure sp_product_order_quantity_Wu


--3.Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities 
--that ordered most that product combined with the total quantity of that product ordered from that city as output.
Create Proc sp_product_order_city_wu
@product_name varchar(20)
As
Begin
Declare @product_id int
Select @product_id = p.ProductId From Products p Where @product_name = p.ProductName
Select Top 5 o.ShipCity, Sum(od.Quantity) [Total Quantity]
From Products p Inner Join [Order Details] od On p.ProductID = od.ProductID
Inner Join Orders o On od.OrderID = o.OrderID
Where p.ProductName = @product_name
Group By o.ShipCity
Order By [Total Quantity] Desc
End

Exec sp_product_order_city_wu 'Alice Mutton'

Drop Proc sp_product_order_city_wu



--4.Create 2 new tables “people_your_last_name” “city_your_last_name”. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
--Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. Create a view “Packers_your_name” lists all people from Green Bay. 
--If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.

Create Table city_wu(
	Id int,
	City varchar(20)

)

Create Table people_wu(
	Id int,
	Name varchar(20),
	City int
)
Insert into city_wu Values(1,'Seattle'),(2,'Green Bay')
Insert into people_wu Values(1,'Aaron Rodgers',2),(2,'Russell Wilson', 1),(3,'Jody Nelson',2)

Delete from city_wu Where City = 'Seattle'
Insert into city_wu Values(3,'Madison')
Update people_wu set City = 3 Where City = 1


Create View Packers_SeanWu 
As
Select *From people_wu Where City = 2

Drop Table city_wu
Drop Table people_wu
Drop View Packers_SeanWu


--5.Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” and 
--fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
Create Proc sp_birthday_employees_wu
As
Begin
Create Table birthday_employees_wu(
	Id int,
	FirstName varchar(20),
	LastName varchar(20),
	BrithDate datetime
)
Insert into birthday_employees_wu(Id, FirstName, LastName, BrithDate)
Select e.EmployeeID, e.FirstName,e.LastName,e.BirthDate
From Employees e
Where Month(e.BirthDate) = 2
End

Exec sp_birthday_employees_wu

Select *
From birthday_employees_wu

Drop proc sp_birthday_employees_wu

--6.How do you make sure two tables have the same data?

--Use Except

Select * From T1
Except
Select * From T2