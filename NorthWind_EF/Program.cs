
using NorthWind_EF.Models;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

NorthwindContext db = new NorthwindContext();
int i = 1;
/*var result = db.Employees.ToList();
foreach (Employee emp in result)
{
    Console.WriteLine(emp.FirstName + "\t\t" + emp.LastName);
}*/

//1. SORU  sel categoryname from categories ord by category name
//var result = db.Categories.OrderBy(c => c.CategoryName).ToList();
//var result2 = db.Categories.Select(c => new
//{
//   c.CategoryName,
//   c.Description
//}).OrderBy(c => c.CategoryName);
//2.soru
/*var result3 = db.Employees.Select(e=> new 
{
    e.FirstName,
    e.LastName,
    e.HireDate,
}).OrderByDescending(e=>e.HireDate);*/
//3.soru

/*var result4 = db.Orders.Select(o=> new
{
    o.OrderId,
    o.OrderDate,
    o.ShippedDate,
    o.CustomerId,
    o.Freight
}).OrderByDescending(o=>o.Freight);


foreach (var order in result4)
{
    Console.WriteLine(order.OrderId + "\t\t" + order.OrderDate + "\t\t"+ order.ShippedDate+"\t\t"+order.CustomerId+"\t\t"+order.Freight);
}*/

//soru5
/*var result5 = db.Suppliers.Select(s => new 
{
    s.CompanyName,
    s.Fax,
    s.Phone,
    s.HomePage,
    s.Country
}).OrderByDescending(s=>s.Country).ThenBy(o=>o.CompanyName);
foreach(var o in result5)
{
    Console.WriteLine(o.CompanyName+"\t"+o.Fax+"\t"+o.Phone+"\t"+o.HomePage+"\t"+o.Country);
} */
//soru 6
/*var result6 = db.Customers.Select(c=> new 
{
    c.CompanyName, 
    c.ContactName,
    c.City
}).Where(c=> c.City.ToLower() == "buenos aires");
foreach(var c in result6)
{
    Console.WriteLine(c.CompanyName+"\t"+c.ContactName+"\t"+c.City);
}*/
//soru8
/*//DateTime dt4 = new DateTime(1997, 5, 19);
var res8 = db.Orders.Select(o=> new
{
    o.OrderDate,
    o.ShippedDate,
    o.CustomerId,
    o.Freight
}).Where(o=>o.OrderDate==DateTime.Parse("19-05-1997");
foreach(var o in res8)
{
    Console.WriteLine(o.OrderDate+"\t"+o.ShippedDate+"\t"+o.CustomerId+"\t"+o.Freight);
}
*/
//soru7
/*var s7 = db.Products.Select(p => new
{
    p.ProductName,
    p.UnitPrice,
    p.QuantityPerUnit,
    p.UnitsInStock
   }).Where(p=>p.UnitsInStock==0);
foreach(var p in s7)
{
    Console.WriteLine(p.ProductName+"\t"+p.UnitPrice+"\t"+p.QuantityPerUnit);
}*/
//Soru9
/*var s9 = db.Employees.Select(e=> new
{
    e.FirstName,
    e.LastName,
    e.Country
}).Where(e=> e.Country !="USA").OrderBy(e=>e.FirstName);
foreach(var e in s9)
{
    Console.WriteLine(e.FirstName + "\t" + e.LastName + "\t" + e.Country);
}*/
//soru10
/*var s10 = db.Orders.Select(o=> new
{
    o.EmployeeId,
    o.OrderId,
    o.CustomerId,
    o.RequiredDate,
    o.ShippedDate
}).Where(o=>o.ShippedDate>o.RequiredDate).OrderBy(o=>o.EmployeeId);
foreach (var o in s10)
{
Console.WriteLine(o.EmployeeId+"\t"+o.OrderId+"\t"+o.CustomerId+"\t"+o.RequiredDate+"\t"+o.ShippedDate);
}*/
//soru11
/*var s11 = db.Customers.Select(c => new
{
    c.City,
    c.CompanyName,
    c.ContactName
}).Where(c => c.City.StartsWith("A") || c.City.StartsWith("B")).OrderBy(c=>c.City);
foreach(var c in s11)
{
    Console.WriteLine(c.City+"\t"+c.CompanyName+"\t"+c.ContactName);
}*/
//SORU12
/*var s12 = db.Orders.Where(o=>o.Freight>500);
foreach(var o in s12)
{
    Console.WriteLine(o.Customer+"\t"+o.Freight);
}*/
//soru14
/*var s14 = db.Customers.Where(c => c.Fax != null);

int i = 1;
foreach (var c in s14)
{
    Console.WriteLine(i + " " + c.CompanyName);
    i++;
}*/
//soru18
/*
var s18 = db.Employees.Where(e=>e.BirthDate.Value.Year>1949 && e.BirthDate.Value.Year<1960);
int i = 1;
foreach(var e in s18)
{
    Console.WriteLine(i + " " + e.BirthDate);
    i++;
}*/
//soru19
/*var s19 = db.Products.Join(db.Suppliers,
    p => p.SupplierId,
    s => s.SupplierId, 
    (product, supplier) => 
    new
    {
        product.ProductName,
        supplier.CompanyName
    }
    ).Where(s=>s.CompanyName.ToLower()=="tokyo traders");
foreach(var s in s19)
{
    Console.WriteLine(s.ProductName + "\t" + s.CompanyName);
}*/


/*var q1 = db.Categories.Select(c => new
{
    c.CategoryName,
    c.Description,
}).OrderBy(c=> c.CategoryName);
foreach(var c in q1)
{
    Console.WriteLine(i + "\t"+c.CategoryName+"\t"+c.Description);
    i++;
}*/

// Q2 SELECT ContactName,CompanyName,ContactTitle,Phone FROM Customers ORDER BY Phone

/*var q2 =db.Customers.Select(c => new
{
    c.ContactName,
    c.CompanyName,
    c.ContactTitle,
    c.Phone
}).OrderBy(c=>c.Phone);
foreach(var c in q2)
{
    Console.WriteLine(i+"\t"+c.ContactTitle+"\t"+c.ContactName+"\t"+c.CompanyName+"\t"+c.Phone);
    i++;
} */

// Q3 SELECT FirstName,LastName,HireDate FROM Employees ORDER BY HireDate DESC

/*var q3 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.HireDate
}).OrderByDescending(e => e.HireDate);
foreach (var e in q3)
{
    Console.WriteLine(i + "\t" + e.FirstName + "\t" + e.LastName + "\t" + e.HireDate);
    i++;
}
*/

// Q4 SELECT * FROM Orders ORDER BY Freight DESC

/*var q4 = db.Orders.OrderByDescending(o => o.Freight);
foreach (var o in q4)
{
    Console.WriteLine(i + "\t" + o.Freight);
    i++;
}*/

// Q5 SELECT CompanyName,Fax,Phone,HomePage,Country FROM Suppliers  ORDER BY Country DESC , CompanyName ASC

/*var q5 = db.Suppliers.Select(s => new
{
    s.CompanyName,
    s.Fax,
    s.Phone,
    s.HomePage,
    s.Country
}).OrderByDescending(s=>s.Country).ThenBy(s=>s.CompanyName);
foreach(var s in q5)
{
    Console.WriteLine(i+"\t"+ s.CompanyName+"\t" + s.Phone+"\t"+s.HomePage+"\t"+s.Country);
    i++;
}*/

// Q6 SELECT CompanyName,ContactName,City FROM Customers WHERE LOWER(City) Like 'buenos aires'

/*var q6 = db.Customers.Select(c => new
{
    c.CompanyName,
    c.ContactName,
    c.City
}).Where(c=>c.City.ToLower()=="buenos aires").OrderBy(c=>c.CompanyName);
 foreach(var q in q6)
{
    Console.WriteLine(i + "\t" + q.ContactName + "\t"+q.CompanyName+"\t"+q.City);
}*/

// Q7 SELECT ProductName,UnitPrice,QuantityPerUnit,UnitsInStock FROM Products WHERE UnitsInStock=0

/*var q7 = db.Products.Select(p => new 
{
    p.ProductName,
    p.UnitPrice,
    p.QuantityPerUnit,
    p.UnitsInStock
}).Where(p => p.UnitsInStock == 0).OrderBy(p=>p.QuantityPerUnit);
foreach(var p in q7)
{
    Console.WriteLine(i + "\t" + p.ProductName + "\t" + p.UnitPrice + "\t"+p.QuantityPerUnit+"\t"+p.UnitsInStock);
    i++;
}*/

// Q8  SELECT OrderDate,ShippedDate,CustomerID,Freight FROM Orders WHERE OrderDate='1997-5-19'

/*var q8 = db.Orders.Select(o => new
{
    o.OrderDate,
    o.ShippedDate,
    o.CustomerId,
    o.Freight,
}).Where(o => o.OrderDate == DateTime.Parse("1997-5-19")).OrderBy(p => p.CustomerId);
foreach (var o in q8)
{
    Console.WriteLine(i + "\t" + o.OrderDate + "\t" + o.ShippedDate + "\t" + o.CustomerId + "\t" + o.Freight);
}*/

// Q9 SELECT FirstName,LastName,Country FROM Employees WHERE Country != 'USA'

/*var q9 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.Country
}).Where(e=>e.Country.ToUpper() != "USA");
foreach(var e in q9)
{
    Console.WriteLine(i+ "\t" + e.FirstName + "\t" + e.LastName+"\t" + e.Country);
    i++;
}*/

//Q10 SELECT EmployeeID,OrderID,CustomerID,RequiredDate,ShippedDate FROM Orders WHERE ShippedDate>RequiredDate ORDER BY EmployeeID

/*var q10 = db.Orders.Select(o => new
{
    o.OrderId,
    o.EmployeeId,
    o.CustomerId,
    o.RequiredDate,
    o.ShippedDate
}).Where(o => o.ShippedDate > o.RequiredDate).OrderBy(o => o.EmployeeId);
foreach (var o in q10)
{
    Console.WriteLine(i + "\t" + o.EmployeeId + "\t" + o.OrderId + "\t" + o.CustomerId + "\t" + o.RequiredDate + "\t" + o.ShippedDate);
    i++;
}*/

// Q11 SELECT City,CompanyName,ContactName FROM Customers WHERE City LIKE 'A%' OR City LIKE 'B%' ORDER BY City

/*var q11 = db.Customers.Select(c => new
{
    c.City,
    c.CompanyName,
    c.ContactName
}).Where(c => c.City.StartsWith("A") || c.City.StartsWith("B")).OrderBy(c => c.City);
foreach (var q in q11)
{
    Console.WriteLine(i + "\t" + q.City + "\t" + q.CompanyName + "\t" + q.ContactName);
    i++;
}*/

// Q12 SELECT * FROM Orders WHERE Freight >500 ORDER BY Freight DESC

/*var q12 = db.Orders.Where(o=>o.Freight>500).OrderByDescending(o=>o.Freight);
foreach(var order in q12)
{
    Console.WriteLine(i + "\t" + order.OrderId + "\t" + order.Employee + "\t" + order.Customer + "\t" + order.Freight);
    i++;
}*/

// Q13SELECT ProductName,UnitsInStock,UnitsOnOrder,ReorderLevel FROM Products WHERE ReorderLevel>UnitsInStock ORDER BY ReorderLevel DESC

/*var q13 = db.Products.Select(p => new
{
    p.ProductName,
    p.UnitsInStock,
    p.ReorderLevel,
    p.UnitsOnOrder
}).Where(p => p.ReorderLevel > p.UnitsInStock).OrderByDescending(p => p.ReorderLevel);
foreach (var p in q13)
{
    Console.WriteLine(i + "\t" + p.ProductName + "\t" + p.UnitsInStock +"\t"+ p.ReorderLevel + "\t" +p.UnitsOnOrder);
    i++;    
}*/

// Q14 SELECT CompanyName,ContactName,Fax FROM Customers WHERE Fax IS NOT null ORDER BY CompanyName 

/*var q14 = db.Customers.Select(c => new
{
    c.CompanyName,
    c.ContactName,
    c.Fax,
}).Where(c => c.Fax != null).OrderBy(c => c.CompanyName);
foreach (var c in q14)
{
    Console.WriteLine(i + "\t" + c.CompanyName + "\t" + c.ContactName + "\t" + c.Fax);
    i++;    
}*/

// Q15 SELECT FirstName,LastName FROM Employees WHERE ReportsTo IS null

/*var q15 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.ReportsTo
}).Where(e=> e.ReportsTo == null);
foreach(var e in q15)
{
    Console.WriteLine(i+"\t" + e.FirstName + "\t" + e.LastName);
}*/

// Q16  SELECT CompanyName,ContactName,Fax FROM Customers WHERE Fax IS NOT null ORDER BY CompanyName 
/*var q16 = db.Customers.Select(c => new
{
    c.CompanyName,
    c.ContactName,
    c.Fax,
}).Where(c => c.Fax != null).OrderBy(c => c.CompanyName).OrderBy(c => c.CompanyName);
foreach (var c in q16)
{
    Console.WriteLine(i + "\t" + c.CompanyName + "\t" + c.ContactName + "\t" + c.Fax);
    i++;
}*/

// Q17 SELECT City,CompanyName,ContactName FROM Customers WHERE City LIKE 'A%' OR City LIKE 'B%' ORDER BY ContactName DESC

/*var q17 = db.Customers.Select(c => new
{
    c.City,
    c.CompanyName,
    c.ContactName
}).Where(c => c.City.ToLower().StartsWith("a") || c.City.ToLower().StartsWith("b")).OrderByDescending(c => c.ContactName);
foreach(var c in q17)
{
    Console.WriteLine(i+"\t" +c.ContactName + "\t" +c.CompanyName + "\t" +c.City);
    i++;
}*/

// Q18 SELECT FirstName,LastName,BirthDate FROM Employees WHERE YEAR(BirthDate) < 1960 AND YEAR (BirthDate)>1949

/*var q18 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.BirthDate
}).Where(e => e.BirthDate.Value.Year > 1949 && e.BirthDate.Value.Year < 1960).OrderBy(e => e.FirstName);
foreach (var q in q18)
{
    Console.WriteLine(i + "\t" + q.FirstName + "\t" + q.LastName + "\t" + q.BirthDate);
    i++;
}*/

// Q19 SELECT p.ProductName,p.SupplierID,s.CompanyName
// FROM Products p
// JOIN Suppliers s ON p.SupplierID = s.SupplierID
// WHERE LOWER(s.CompanyName) = 'exotic liquids' OR LOWER(s.CompanyName) = 'grandma kelly''s homestead' OR LOWER(s.CompanyName)= 'tokyo traders'

/*var q19 = db.Products.Join(db.Suppliers,
    p => p.SupplierId,
    c => c.SupplierId,
    (Product, Supplier) => new
    {
        *//* UrunAdi =*//* // BU SEKILDE DE KULLANILABILIR ANCAK QUERY ATARKEN VERILEN ISIMLE CAGRILMASI GEREKIYOR 
        Product.ProductName,
        *//* UreticiId *//*
        Product.SupplierId,
        *//*SirketAdi = *//*
        Supplier.CompanyName,
    }
    ).Where(p => p.CompanyName.ToLower() == "exotic liquids" || p.CompanyName.ToLower() == "grandma kelly's homestead" || p.CompanyName.ToLower() == "tokyo traders").OrderBy(p => p.CompanyName);
foreach (var q in q19)
{
    Console.WriteLine(i + "\t" + q.CompanyName + "\t" + q.ProductName + "\t" + q.SupplierId);
    i++;
}*/

// Q20 SELECT ShipPostalCode,OrderID,OrderDate FROM Orders WHERE ShipPostalCode LIKE '02389%' 

/*var q20 = db.Orders.Select(o => new
{
    o.ShipPostalCode,
    o.OrderId,
    o.OrderDate
}).Where(o => o.ShipPostalCode.StartsWith("02389")).OrderBy(o => o.ShipPostalCode);
foreach (var o in q20)
{
    Console.WriteLine(i + "\t" + o.ShipPostalCode + "\t" + o.OrderId + "\t" + o.OrderDate);
    i++;
}*/

// Q21 SELECT ContactName,ContactTitle,CompanyName FROM Customers WHERE LOWER(ContactTitle)NOT LIKE '%sales%' ORDER BY ContactTitle

/*var q21 = db.Customers.Select(c => new
{
    c.ContactName,
    c.CompanyName,
    c.ContactTitle
}).Where(c => !c.ContactTitle.ToLower().Contains("sales"));
foreach (var c in q21)
{
    Console.WriteLine(i + "\t" + c.ContactName + "\t" + c.ContactTitle + "\t" + c.CompanyName);
    i++;
}*/

// Q22 SELECT FirstName,LastName,City FROM Employees WHERE UPPER(City) != 'SEATTLE' AND UPPER(Region)= 'WA' ORDER BY FirstName

/*var q22 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.City,
    e.Region
}).Where(e => e.City.ToUpper() != "SEATTLE" && e.Region.ToUpper() == "WA").OrderBy(e => e.FirstName);
foreach (var e in q22)
{
    Console.WriteLine(i + "\t" + e.FirstName + "\t" + e.LastName + "\t" + e.City);
    i++;
}*/

// Q23 SELECT CompanyName,ContactTitle,City,Country FROM Customers WHERE lower(Country) = 'mexico' OR lower(Country) = 'spain' AND lower(City) != 'madrid'

/*var q23 = db.Customers.Select(c => new
{
    c.CompanyName,
    c.ContactTitle,
    c.City,
    c.Country
}).Where(c => (c.Country.ToLower() == "mexico") || (c.Country.ToLower() == "spain" && c.City.ToLower() != "madrid")).OrderBy(c => c.Country);
foreach (var c in q23)
{
    Console.WriteLine(i + "\t" + c.CompanyName + "\t" + c.ContactTitle + "\t" + c.City + "\t" + c.Country);
    i++;
}*/

// Q24 SELECT FirstName + ' ' + LastName + ' can be reached at x' + Extension + '.' AS ContactInfo FROM Employees

/*var q24 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.Extension
});
foreach (var e in q24)
{
    Console.WriteLine(i + " " + e.FirstName + " " + e.LastName + " can be reached at x" + e.Extension + ".");
    i++;
}
*/

// Q25SELECT UnitsInStock,UnitPrice,UnitPrice*UnitsInStock AS TotalPrice,FLOOR(UnitPrice*UnitsInStock) AS TotalPriceRD ,CEILING(UnitsInStock*UnitPrice) AS TotalPriceRU
// FROM Products
// WHERE UnitsInStock != 0ORDER BY TotalPrice DESC

/*var q25 = db.Products.Select(p => new
{
    p.UnitsInStock,
    p.UnitPrice,
    TotalPrice = p.UnitPrice * p.UnitsInStock,
    TotalPriceRD = Math.Floor((decimal)(p.UnitPrice * p.UnitsInStock)),
    TotalPriceRU = Math.Ceiling((decimal)(p.UnitPrice * p.UnitsInStock)),
}).Where(p => p.UnitsInStock != 0).OrderByDescending(p => p.TotalPrice);
foreach (var p in q25)
{
    Console.WriteLine(i + " " + p.UnitsInStock + " " + p.UnitPrice + " " + p.TotalPrice + " " + p.TotalPriceRD + " " + p.TotalPriceRU);
    i++;
}*/

// Q26 SELECT DATEDIFF(DAY,HireDate,BirthDate)/365.0 AS HireAgeAccurate ,YEAR(HireDate)- YEAR(BirthDate) AS HireAgeInaccurate FROM Employees 

/*var q26 = db.Employees.Select(e => new 
{
    e.HireDate,
    e.BirthDate,
    HireAgeAccurate = (e.HireDate-e.BirthDate).Value.Days/365.0,
    HireAgeInaccurate = e.HireDate.Value.Year - e.BirthDate.Value.Year,
});
foreach(var e in q26)
{
Console.WriteLine(i+" " + e.HireAgeAccurate + " " + e.HireAgeInaccurate);
    i++;
}*/

// Q27 SELECT FirstName,LastName,DATENAME(MONTH,BirthDate) AS BirthMonth FROM Employees
// WHERE MONTH(BirthDate)=MONTH(GETDATE())-9 // BU 9 AYI HESAPLAMAK ICIN 

/*var q27 = db.Employees.Select(e => new
{
    e.FirstName,
    e.LastName,
    e.BirthDate,
    BirthMonth = e.BirthDate.Value.ToString("MMMM"),
}).Where(e => e.BirthDate.Value.Month == DateTime.Now.Month-9);
foreach (var e in q27)
{
    Console.WriteLine(i+ " " + e.FirstName + " " + e.LastName + " " + e.BirthMonth);
    i++;
}*/

// Q28 SELECT LOWER(ContactTitle) FROM Customers
/*var q28 = db.Customers.Select(c => c.ContactTitle.ToLower());
foreach(var c in q28)
{
    Console.WriteLine(i + " " + c);
    i++;
}*/
// Q30 SELECT ProductName FROM Products WHERE CategoryID IN(SELECT CategoryID FROM Categories WHERE UPPER(CategoryName) = 'SEAFOOD')

/*var q30 = db.Products.Join(db.Categories,
    p=>p.CategoryId,
    c=>c.CategoryId,
    (pr,ct)=> new
    {
        pr.ProductName,
        ct.CategoryName
    }).Where(p=>p.CategoryName.ToUpper() == "SEAFOOD");
foreach(var p in q30)
{
    Console.WriteLine(i+" " + p.ProductName);
    i++;
}*/

// Q31 SELECT s.CompanyName,p.ProductName,p.CategoryID FROM Suppliers s
// JOIN Products p ON s.SupplierID = p.SupplierID
// WHERE p.CategoryID = 8

/*var q31 = db.Suppliers.Join(db.Products,
    s => s.SupplierId,
    p => p.SupplierId,
    (sp, pr) => new
    {
        sp.CompanyName,
        pr.CategoryId,
        pr.ProductName,
    }
    ).Where(c => c.CategoryId == 8);
foreach (var c in q31)
{
    Console.WriteLine(i + " " + c.CompanyName + " " + c.ProductName + " " + c.CategoryId);
    i++;
}*/

// Q32 SELECT c.CategoryName,s.CompanyName,p.ProductName FROM Suppliers s
// JOIN Products pON s.SupplierID = p.SupplierID
// JOIN Categories cON p.CategoryID = c.CategoryID
// WHERE UPPER(CategoryName) = 'SEAFOOD'

/*var q32 = db.Suppliers.Join(db.Products,
    s => s.SupplierId,
    p => p.SupplierId,
    (sp, pr) => new
    {
        sp.CompanyName,
        pr.ProductName,
        pr.CategoryId,
    }
    ).Join(db.Categories,
    s => s.CategoryId,
    c => c.CategoryId,
    (sp, ct) => new
    {
        sp.CompanyName,
        sp.ProductName,
        ct.CategoryName
    }
   ).Where(s=>s.CategoryName.ToUpper()=="SEAFOOD");
foreach(var c in q32)
{
    Console.WriteLine(i+" " + c.CompanyName + " " + c.ProductName + " " + c.CategoryName);
    i++;    
}
*/

// Q33 SELECT o.OrderID,e.FirstName + ' ' + e.LastName AS EmployeeName FROM Orders o JOIN Employees e
// ON o.EmployeeID = e.EmployeeID
// WHERE ShippedDate>RequiredDate

/*var q33 = db.Orders.Join(db.Employees,
    o => o.EmployeeId,
    e => e.EmployeeId,
    (or, em) => new
    {
        or.OrderId,
        or.RequiredDate,
        or.ShippedDate,
        em.FirstName,
        em.LastName
    }
    ).Where(o => o.ShippedDate > o.RequiredDate).OrderBy(o=>o.LastName);
foreach (var o in q33)
{
    Console.WriteLine(i + " " + o.OrderId + "\t" + o.FirstName + " " + o.LastName + "\t" + o.RequiredDate + "\t" + o.ShippedDate);
    i++;
}*/
// Q34SELECT p.ProductName,SUM(o.Quantity) FROM [Order Details] o
// JOIN Products p
// ON o.ProductID = p.ProductID
// GROUP BY p.ProductNameHAVING SUM(o.Quantity)<200

/*var q34 = db.OrderDetails.Join(db.Products,
    o => o.ProductId,
    p => p.ProductId,
    (or, pr) => new
    {
        or.Quantity,
        pr.ProductName,
    }
    ).GroupBy(g => g.ProductName).Select(g => new
    {
        ProductName = g.Key,
        TotalUnits = g.Sum(o => o.Quantity)
    }).OrderBy(g => g.ProductName).Where(g => g.TotalUnits < 200);
foreach (var item in q34)
{
    Console.WriteLine(i + " " + item.ProductName + " " + item.TotalUnits);
    i++;
}*/


// Q35 SELECT c.CompanyName ,COUNT(o.OrderDate) AS NumOrders FROM Orders o JOIN Customers c
//ON o.CustomerID = c.CustomerID
//WHERE o.OrderDate >'1996-12-31'
//GROUP BY c.CompanyName
//HAVING COUNT(o.OrderDate)>15 ORDER BY NumOrders DESC

/*var q35 = db.Orders.Join(db.Customers,
    o => o.CustomerId,
    c => c.CustomerId,
    (or, cs) => new
    {
        cs.CompanyName,
        or.OrderDate,
    }
    ).Where(o => o.OrderDate > DateTime.Parse("1996-12-31"))
    .GroupBy(g => g.CompanyName)
    .Select(g => new
    {
        CompanyName = g.Key,
        NumOrders = g.Count(),
    })
    .Where(c => c.NumOrders > 15)
    .OrderByDescending(c => c.NumOrders);

foreach (var o in q35)
{
    Console.WriteLine(i + " " + o.CompanyName + " " + o.NumOrders);
}*/

// Q36 SELECT o.OrderID,c.CompanyName,(od.Quantity*od.UnitPrice*(1-od.Discount)) AS Total FROM Orders o
//JOIN Customers c
//ON o.CustomerID = c.CustomerID
//JOIN [Order Details] od
//ON od.OrderID = o.OrderID
//WHERE (od.UnitPrice*od.Quantity*(1-od.Discount)) > 10000

/*var q36 = db.Orders.Join(db.Customers,
    o => o.CustomerId,
    c => c.CustomerId,
    (o, c) => new
    {
        c.CustomerId,
        o.OrderId,
        c.CompanyName,
    }
    ).Join(db.OrderDetails,
    oc => oc.OrderId,
    o => o.OrderId,
    (oc, o) => new
    {
        oc.OrderId,
        oc.CompanyName,
        TotalPrice = ((decimal)o.Quantity) * ((decimal)o.UnitPrice) * ((decimal)(1 - o.Discount))
    }
    ).Where(o => o.TotalPrice > 10000).OrderByDescending(o => o.TotalPrice);

foreach (var o in q36)
{
    Console.WriteLine(i + " " + o.CompanyName + " " + o.OrderId + " " + o.TotalPrice);
    i++;
}*/