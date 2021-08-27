select p.productName [ürün adı], sum(od.UnitPrice*od.Quantity)[Kazanılan Toplam Miktar] 
from Orders o 
inner join (Products p 
			inner join [Order Details] od on p.ProductID=od.ProductID) 
on o.OrderID=od.OrderID group by p.ProductName; 