﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess.RepositoryConstTexts
{
    internal class SqlText
    {
        internal const string ConnectionString = "server=192.168.56.101;Database=Northwind;User Id=sa;Password=sjmnwt480;";
        internal const string getAllCategories = "select * from Categories";
        internal const string findSingleCategory = "select * from Categories where CategoryID = @CategoryID";
        internal const string addCategory = @"
insert into Categories
(CategoryName,Description)
values
(@CategoryName,@Description)";
        internal const string updateCategory = @"
update Categories
set CategoryName = @CategoryName,
    Description = @Description
where CategoryID = @CategoryID
";
        internal const string removeCategory = "delete Categories where CategoryID = @CategoryID";
        internal const string getAllShippers = "select * from Shippers";
        internal const string findSingleShipper = "select * from Shippers where ShipperID = @ShipperID";
        internal const string addShipper = @"
insert into Shippers
(CompanyName,Phone)
values
(@CompanyName,@Phone)";
        internal const string updateShipper = @"
update Shippers
set CompanyName = @CompanyName,
    Phone = @Phone
where ShipperID = @ShipperID
";
        internal const string removeShipper = "delete Shippers where ShipperID = @ShipperID";
        internal const string getAllSuppliers = "select * from Suppliers";
        internal const string findSingleSupplier = "select * from Suppliers where SupplierID = @SupplierID";
        internal const string addSupplier = @"
insert into Suppliers (
         CompanyName ,
         ContactName ,
         ContactTitle ,
         Address ,
         City ,
         Region, 
         PostalCode, 
         Country ,
         Phone ,
         Fax
)
values (
        @CompanyName ,
        @ContactName ,
        @ContactTitle ,
        @Address ,
        @City ,
        @Region, 
        @PostalCode, 
        @Country ,
        @Phone ,
        @Fax 
)";
        internal const string updateSupplier = @"
update Suppliers
set      CompanyName = @CompanyName,
         ContactName = @ContactName,
         ContactTitle = @ContactTitle,
         Address = @Address,
         City = @City,
         Region = @Region,
         PostalCode = @PostalCode,
         Country = @Country,
         Phone = @Phone,
         Fax = @Fax
where SupplierID = @SupplierID
";
        internal const string removeSupplier = "delete Suppliers where SupplierID = @SupplierID";
        internal const string getAllProducts = "select * from Products";
        internal const string findSingleProduct = "select * from Products where ProductID = @ProductID";
        internal const string addProduct = @"
insert into Products (
        ProductName ,
        CategoryID ,
        SupplierID ,
        UnitPrice ,
        QuantityPerUnit ,
        UnitsInStock ,
        UnitsOnOrder ,
        ReorderLevel ,
        Discontinued
)
values (
        @ProductName, 
        @CategoryID,
        @SupplierID,
        @UnitPrice,
        @QuantityPerUnit,
        @UnitsInStock,
        @UnitsOnOrder,
        @ReorderLevel,
        @Discontinued
)";
        internal const string updateProduct = @"
update products
set     ProductName = @ProductName, 
        CategoryID = @CategoryID,
        SupplierID = @SupplierID,
        UnitPrice = @UnitPrice,
        QuantityPerUnit = @QuantityPerUnit,
        UnitsInStock  = @UnitsInStock,
        UnitsOnOrder = @UnitsOnOrder,
        ReorderLevel  = @ReorderLevel,
        Discontinued  = @Discontinued
where ProductID = @ProductID
";
        internal const string removeProduct = "delete Products where ProductID = @ProductID";
        internal const string getAllEmployees = "select * from Employees";
        internal const string findSingleEmployee = "select * from Employees where EmployeeID = @EmployeeID";
        internal const string addEmployee = @"
insert into Employees (
         LastName,
         FirstName,
         Title,
         TitleOfCourtesy,
         BirthDate,
         HireDate,
         Address,
         City,
         Region,
         PostalCode,
         Country,
         HomePhone,
         Extension,
         Notes,
         ReportsTo
)
values (
         @LastName,
         @FirstName,
         @Title,
         @TitleOfCourtesy,
         @BirthDate,
         @HireDate,
         @Address,
         @City,
         @Region,
         @PostalCode,
         @Country,
         @HomePhone,
         @Extension,
         @Notes,
         @ReportsTo
)";
        internal const string updateEmployee = @"
update Employees
set      FirstName = @FirstName,
         LastName = @LastName,
         Title = @Title,
         TitleOfCourtesy = @TitleOfCourtesy,
         BirthDate = @BirthDate,
         HireDate = @HireDate,
         Address = @Address,
         City = @City,
         Region = @Region,
         PostalCode = @PostalCode,
         Country = @Country,
         HomePhone = @HomePhone,
         Extension = @Extension,
         Notes = @Notes,
         ReportsTo = @ReportsTo
where EmployeeID = @EmployeeID
";
        internal const string removeEmployee = "delete Employees where EmployeeID = @EmployeeID";
        internal const string getAllCustomers = "select * from Customers";
        internal const string findSingleCustomer = "select * from Customers where CustomerID = @CustomerID";
        internal const string addCustomer = @"
insert into Customers (
         CustomerID,
         CompanyName ,
         ContactName ,
         ContactTitle ,
         Address ,
         City ,
         Region, 
         PostalCode, 
         Country ,
         Phone ,
         Fax
)
values (
        @CustomerID,
        @CompanyName ,
        @ContactName ,
        @ContactTitle ,
        @Address ,
        @City ,
        @Region, 
        @PostalCode, 
        @Country ,
        @Phone ,
        @Fax 
)";
        internal const string updateCustomer = @"
update Customers
set      CompanyName = @CompanyName,
         ContactName = @ContactName,
         ContactTitle = @ContactTitle,
         Address = @Address,
         City = @City,
         Region = @Region,
         PostalCode = @PostalCode,
         Country = @Country,
         Phone = @Phone,
         Fax = @Fax
where CustomerID = @CustomerID
";
        internal const string removeCustomer = "delete Customers where CustomerID = @CustomerID";
        internal const string getAllOrders = "select * from Orders";
        internal const string findSingleOrder = @"
select * from Orders
where OrderID = @OrderID";
        /// <summary>
        /// with select @@IDENTITY returns OrderID
        /// </summary>
        internal const string addOrder = @"
INSERT INTO [dbo].[Orders]
           (
            [CustomerID],[EmployeeID],[OrderDate],[RequiredDate],[ShippedDate],[ShipVia],[Freight]
           ,[ShipName],[ShipAddress],[ShipCity],[ShipRegion],[ShipPostalCode],[ShipCountry])
     VALUES
           (
            @CustomerID,@EmployeeID,@OrderDate,@RequiredDate,@ShippedDate,@ShipVia,@Freight,
            @ShipName,@ShipAddress,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipCountry
            )
            select @@IDENTITY
";
        internal const string addOrderDetail = @"
INSERT INTO [dbo].[Order Details]
            (
            [OrderID],[ProductID],[UnitPrice],[Quantity],[Discount]
            )
     VALUES
            (
            @OrderID,@ProductID,@UnitPrice,@Quantity,@Discount
            )
";
        internal const string updateOrder = @"
UPDATE [dbo].[Orders]
SET [CustomerID] = @CustomerID,
    [EmployeeID] = @EmployeeID,
    [OrderDate] = @OrderDate,
    [RequiredDate] = @RequiredDate,
    [ShippedDate] = @ShippedDate,
    [ShipVia] = @ShipVia,
    [Freight] = @Freight,
    [ShipName] = @ShipName,
    [ShipAddress] = @ShipAddress,
    [ShipCity] = @ShipCity,
    [ShipRegion] = @ShipRegion,
    [ShipPostalCode] = @ShipPostalCode,
    [ShipCountry] = @ShipCountry
WHERE OrderID = @OrderID";
        internal const string removeOrder = "delete Orders where OrderID = @OrderID";
    }
}
