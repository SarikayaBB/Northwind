
using NorthWind_EF.Models;
using System.Reflection.Metadata.Ecma335;

NorthwindContext db = new NorthwindContext();

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
var s19 = db.Products.Join(db.Suppliers,
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
}