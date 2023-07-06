//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mobile_Storage
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string UnitName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string ProductBarcode { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string SizeName { get; set; }
        public string ColorName { get; set; }
        public string ModelName { get; set; }
        public string VariantName { get; set; }
        public double OldPrice { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set; }
        public string WarehouseList { get; set; }
        public Nullable<double> stock { get; set; }
        public double TotalPurchase { get; set; }
        public Nullable<System.DateTime> LastPurchaseDate { get; set; }
        public string LastPurchaseSupplier { get; set; }
        public double TotalSales { get; set; }
        public System.DateTime LastSalesDate { get; set; }
        public string LastSalesCustomer { get; set; }
        public byte[] ImagePath { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
