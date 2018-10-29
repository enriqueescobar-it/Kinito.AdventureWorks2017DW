// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // FactResellerSales
    [Table("FactResellerSales", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FactResellerSale
    {
        [Column(@"ProductKey", Order = 1, TypeName = "int")]
        [Required]
        [Display(Name = "Product key")]
        public int ProductKey { get; set; } // ProductKey

        [Column(@"OrderDateKey", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Order date key")]
        public int OrderDateKey { get; set; } // OrderDateKey

        [Column(@"DueDateKey", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Due date key")]
        public int DueDateKey { get; set; } // DueDateKey

        [Column(@"ShipDateKey", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Ship date key")]
        public int ShipDateKey { get; set; } // ShipDateKey

        [Column(@"ResellerKey", Order = 5, TypeName = "int")]
        [Required]
        [Display(Name = "Reseller key")]
        public int ResellerKey { get; set; } // ResellerKey

        [Column(@"EmployeeKey", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Employee key")]
        public int EmployeeKey { get; set; } // EmployeeKey

        [Column(@"PromotionKey", Order = 7, TypeName = "int")]
        [Required]
        [Display(Name = "Promotion key")]
        public int PromotionKey { get; set; } // PromotionKey

        [Column(@"CurrencyKey", Order = 8, TypeName = "int")]
        [Required]
        [Display(Name = "Currency key")]
        public int CurrencyKey { get; set; } // CurrencyKey

        [Column(@"SalesTerritoryKey", Order = 9, TypeName = "int")]
        [Required]
        [Display(Name = "Sales territory key")]
        public int SalesTerritoryKey { get; set; } // SalesTerritoryKey

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesOrderNumber", Order = 10, TypeName = "nvarchar")]
        [Index(@"PK_FactResellerSales_SalesOrderNumber_SalesOrderLineNumber", 1, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Key]
        [Display(Name = "Sales order number")]
        public string SalesOrderNumber { get; set; } // SalesOrderNumber (Primary key) (length: 20)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesOrderLineNumber", Order = 11, TypeName = "tinyint")]
        [Index(@"PK_FactResellerSales_SalesOrderNumber_SalesOrderLineNumber", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Sales order line number")]
        public byte SalesOrderLineNumber { get; set; } // SalesOrderLineNumber (Primary key)

        [Column(@"RevisionNumber", Order = 12, TypeName = "tinyint")]
        [Display(Name = "Revision number")]
        public byte? RevisionNumber { get; set; } // RevisionNumber

        [Column(@"OrderQuantity", Order = 13, TypeName = "smallint")]
        [Display(Name = "Order quantity")]
        public short? OrderQuantity { get; set; } // OrderQuantity

        [Column(@"UnitPrice", Order = 14, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Unit price")]
        public decimal? UnitPrice { get; set; } // UnitPrice

        [Column(@"ExtendedAmount", Order = 15, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Extended amount")]
        public decimal? ExtendedAmount { get; set; } // ExtendedAmount

        [Column(@"UnitPriceDiscountPct", Order = 16, TypeName = "float")]
        [Display(Name = "Unit price discount pct")]
        public double? UnitPriceDiscountPct { get; set; } // UnitPriceDiscountPct

        [Column(@"DiscountAmount", Order = 17, TypeName = "float")]
        [Display(Name = "Discount amount")]
        public double? DiscountAmount { get; set; } // DiscountAmount

        [Column(@"ProductStandardCost", Order = 18, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Product standard cost")]
        public decimal? ProductStandardCost { get; set; } // ProductStandardCost

        [Column(@"TotalProductCost", Order = 19, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Total product cost")]
        public decimal? TotalProductCost { get; set; } // TotalProductCost

        [Column(@"SalesAmount", Order = 20, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales amount")]
        public decimal? SalesAmount { get; set; } // SalesAmount

        [Column(@"TaxAmt", Order = 21, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Tax amt")]
        public decimal? TaxAmt { get; set; } // TaxAmt

        [Column(@"Freight", Order = 22, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Freight")]
        public decimal? Freight { get; set; } // Freight

        [Column(@"CarrierTrackingNumber", Order = 23, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Carrier tracking number")]
        public string CarrierTrackingNumber { get; set; } // CarrierTrackingNumber (length: 25)

        [Column(@"CustomerPONumber", Order = 24, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Customer pon umber")]
        public string CustomerPoNumber { get; set; } // CustomerPONumber (length: 25)

        [Column(@"OrderDate", Order = 25, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Order date")]
        public System.DateTime? OrderDate { get; set; } // OrderDate

        [Column(@"DueDate", Order = 26, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Due date")]
        public System.DateTime? DueDate { get; set; } // DueDate

        [Column(@"ShipDate", Order = 27, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Ship date")]
        public System.DateTime? ShipDate { get; set; } // ShipDate

        // Foreign keys

        /// <summary>
        /// Parent DimCurrency pointed by [FactResellerSales].([CurrencyKey]) (FK_FactResellerSales_DimCurrency)
        /// </summary>
        [ForeignKey("CurrencyKey"), Required] public virtual DimCurrency DimCurrency { get; set; } // FK_FactResellerSales_DimCurrency

        /// <summary>
        /// Parent DimDate pointed by [FactResellerSales].([DueDateKey]) (FK_FactResellerSales_DimDate1)
        /// </summary>
        [ForeignKey("DueDateKey"), Required] public virtual DimDate DimDate_DueDateKey { get; set; } // FK_FactResellerSales_DimDate1

        /// <summary>
        /// Parent DimEmployee pointed by [FactResellerSales].([EmployeeKey]) (FK_FactResellerSales_DimEmployee)
        /// </summary>
        [ForeignKey("EmployeeKey"), Required] public virtual DimEmployee DimEmployee { get; set; } // FK_FactResellerSales_DimEmployee

        /// <summary>
        /// Parent DimDate pointed by [FactResellerSales].([OrderDateKey]) (FK_FactResellerSales_DimDate)
        /// </summary>
        [ForeignKey("OrderDateKey"), Required] public virtual DimDate DimDate_OrderDateKey { get; set; } // FK_FactResellerSales_DimDate

        /// <summary>
        /// Parent DimProduct pointed by [FactResellerSales].([ProductKey]) (FK_FactResellerSales_DimProduct)
        /// </summary>
        [ForeignKey("ProductKey"), Required] public virtual DimProduct DimProduct { get; set; } // FK_FactResellerSales_DimProduct

        /// <summary>
        /// Parent DimPromotion pointed by [FactResellerSales].([PromotionKey]) (FK_FactResellerSales_DimPromotion)
        /// </summary>
        [ForeignKey("PromotionKey"), Required] public virtual DimPromotion DimPromotion { get; set; } // FK_FactResellerSales_DimPromotion

        /// <summary>
        /// Parent DimReseller pointed by [FactResellerSales].([ResellerKey]) (FK_FactResellerSales_DimReseller)
        /// </summary>
        [ForeignKey("ResellerKey"), Required] public virtual DimReseller DimReseller { get; set; } // FK_FactResellerSales_DimReseller

        /// <summary>
        /// Parent DimSalesTerritory pointed by [FactResellerSales].([SalesTerritoryKey]) (FK_FactResellerSales_DimSalesTerritory)
        /// </summary>
        [ForeignKey("SalesTerritoryKey"), Required] public virtual DimSalesTerritory DimSalesTerritory { get; set; } // FK_FactResellerSales_DimSalesTerritory

        /// <summary>
        /// Parent DimDate pointed by [FactResellerSales].([ShipDateKey]) (FK_FactResellerSales_DimDate2)
        /// </summary>
        [ForeignKey("ShipDateKey"), Required] public virtual DimDate DimDate_ShipDateKey { get; set; } // FK_FactResellerSales_DimDate2
    }

}
// </auto-generated>