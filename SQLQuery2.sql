--Select
--SELECT * FROM Customers 
--SELECT ContactName, CompanyName, City FROM Customers
--ANSII
SELECT ContactName Adi, CompanyName SirketAdi, City Sehir FROM Customers --alias kullanımı

SELECT * FROM Customers WHERE City = 'London'

--Case Insensitive
sElEcT * FROM Products WHERE CategoryID=1 OR CategoryID=3
sElEcT * FROM Products WHERE CategoryID=1 AND UnitPrice>=10
--<> 10'dan farklı olanlar örneğin

--SELECT * FROM Products ORDER BY CategoryID, ProductName

SELECT * FROM Products ORDER BY UnitPrice asc --ascending artan
SELECT * FROM Products ORDER BY UnitPrice desc --descending düşen

SELECT * FROM Products WHERE CategoryID=1 ORDER BY UnitPrice desc --descending düşen

SELECT COUNT(*) FROM Products

--SELECT COUNT(*), ProductName FROM Products bu hata verir mantık hatalı zaten

SELECT COUNT(*) Adet FROM Products WHERE CategoryID = 2 --bu kategoride kaç "Adet" ürün var

SELECT CategoryId, COUNT(*) FROM Products WHERE UnitPrice>20 GROUP BY CategoryID HAVING COUNT(*)<10

SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID

--DTO Data Transformation Object

SELECT * FROM Products p LEFT JOIN [Order Details] od
ON p.ProductID = od.ProductID
--INNER JOIN Orders o
--ON o.OrderID = od.OrderID bu şekilde tabloları bağlaya bağlaya gidebiliyoruz

SELECT * FROM Customers c LEFT JOIN Orders o
ON c.CustomerID = o.CustomerID
WHERE o.CustomerID is null

