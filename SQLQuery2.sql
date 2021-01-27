
--Select
--ANSII
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers 

Select * from Customers where City= 'Berlin'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by ProductName

select * from Products order by UnitPrice asc --ascending=artan

select * from Products order by UnitPrice desc --descending=azalan

select * from Products where CategoryID=1 order by UnitPrice desc --descending=azalan

select * from Products order by CategoryID, ProductName

select count(*) Adet from Products where CategoryID=2

select count(*) from Categories

--hangi kategoride kaç farklı ürün var 
select CategoryID, count(*) from Products group by CategoryID 

--ürün sayısı 10dan az olan kategorileri listele
select CategoryID, count(*) from Products group by CategoryID having count(*) < 10

--önce where çalışır- sayısı 10dan küçük ve fiyatı 20den fazla olan 
select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*) < 10

--inner Join= sadece  tabloda eşleşen dataları getirir
select * from Products inner join Categories on Products.CategoryID= Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID= Categories.CategoryID


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on Products.CategoryID= Categories.CategoryID where Products.UnitPrice>10

--solda olup sağda olmayanları da getir (ürünlerde var ama satışı yok)
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

select * from Products p inner join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID = od.OrderID

--hiç ürün almayan müşteriler
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

--DTO=Data Transformation object
