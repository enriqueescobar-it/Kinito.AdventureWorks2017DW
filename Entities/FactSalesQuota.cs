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

    // FactSalesQuota
    [Table("FactSalesQuota", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FactSalesQuota
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"SalesQuotaKey", Order = 1, TypeName = "int")]
        [Index(@"PK_FactSalesQuota_SalesQuotaKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Sales quota key")]
        public int SalesQuotaKey { get; set; } // SalesQuotaKey (Primary key)

        [Column(@"EmployeeKey", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Employee key")]
        public int EmployeeKey { get; set; } // EmployeeKey

        [Column(@"DateKey", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Date key")]
        public int DateKey { get; set; } // DateKey

        [Column(@"CalendarYear", Order = 4, TypeName = "smallint")]
        [Required]
        [Display(Name = "Calendar year")]
        public short CalendarYear { get; set; } // CalendarYear

        [Column(@"CalendarQuarter", Order = 5, TypeName = "tinyint")]
        [Required]
        [Display(Name = "Calendar quarter")]
        public byte CalendarQuarter { get; set; } // CalendarQuarter

        [Column(@"SalesAmountQuota", Order = 6, TypeName = "money")]
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sales amount quota")]
        public decimal SalesAmountQuota { get; set; } // SalesAmountQuota

        [Column(@"Date", Order = 7, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public System.DateTime? Date { get; set; } // Date

        // Foreign keys

        /// <summary>
        /// Parent DimDate pointed by [FactSalesQuota].([DateKey]) (FK_FactSalesQuota_DimDate)
        /// </summary>
        [ForeignKey("DateKey"), Required] public virtual DimDate DimDate { get; set; } // FK_FactSalesQuota_DimDate

        /// <summary>
        /// Parent DimEmployee pointed by [FactSalesQuota].([EmployeeKey]) (FK_FactSalesQuota_DimEmployee)
        /// </summary>
        [ForeignKey("EmployeeKey"), Required] public virtual DimEmployee DimEmployee { get; set; } // FK_FactSalesQuota_DimEmployee
    }

}
// </auto-generated>
