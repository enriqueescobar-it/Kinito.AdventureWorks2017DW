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

    // FactInternetSalesReason
    [Table("FactInternetSalesReason", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FactInternetSalesReason
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesOrderNumber", Order = 1, TypeName = "nvarchar")]
        [Index(@"PK_FactInternetSalesReason_SalesOrderNumber_SalesOrderLineNumber_SalesReasonKey", 1, IsUnique = true, IsClustered = true)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Key]
        [Display(Name = "Sales order number")]
        public string SalesOrderNumber { get; set; } // SalesOrderNumber (Primary key) (length: 20)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesOrderLineNumber", Order = 2, TypeName = "tinyint")]
        [Index(@"PK_FactInternetSalesReason_SalesOrderNumber_SalesOrderLineNumber_SalesReasonKey", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Sales order line number")]
        public byte SalesOrderLineNumber { get; set; } // SalesOrderLineNumber (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesReasonKey", Order = 3, TypeName = "int")]
        [Index(@"PK_FactInternetSalesReason_SalesOrderNumber_SalesOrderLineNumber_SalesReasonKey", 3, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Sales reason key")]
        public int SalesReasonKey { get; set; } // SalesReasonKey (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent FactInternetSale pointed by [FactInternetSalesReason].([SalesOrderNumber], [SalesOrderLineNumber]) (FK_FactInternetSalesReason_FactInternetSales)
        /// </summary>
        [ForeignKey("SalesOrderNumber, SalesOrderLineNumber"), Required] public virtual FactInternetSale FactInternetSale { get; set; } // FK_FactInternetSalesReason_FactInternetSales

        /// <summary>
        /// Parent DimSalesReason pointed by [FactInternetSalesReason].([SalesReasonKey]) (FK_FactInternetSalesReason_DimSalesReason)
        /// </summary>
        [ForeignKey("SalesReasonKey"), Required] public virtual DimSalesReason DimSalesReason { get; set; } // FK_FactInternetSalesReason_DimSalesReason
    }

}
// </auto-generated>