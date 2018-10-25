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

    // DimPromotion
    [Table("DimPromotion", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimPromotion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"PromotionKey", Order = 1, TypeName = "int")]
        [Index(@"PK_DimPromotion_PromotionKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Promotion key")]
        public int PromotionKey { get; set; } // PromotionKey (Primary key)

        [Column(@"PromotionAlternateKey", Order = 2, TypeName = "int")]
        [Index(@"AK_DimPromotion_PromotionAlternateKey", 1, IsUnique = true, IsClustered = false)]
        [Display(Name = "Promotion alternate key")]
        public int? PromotionAlternateKey { get; set; } // PromotionAlternateKey

        [Column(@"EnglishPromotionName", Order = 3, TypeName = "nvarchar")]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "English promotion name")]
        public string EnglishPromotionName { get; set; } // EnglishPromotionName (length: 255)

        [Column(@"SpanishPromotionName", Order = 4, TypeName = "nvarchar")]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Spanish promotion name")]
        public string SpanishPromotionName { get; set; } // SpanishPromotionName (length: 255)

        [Column(@"FrenchPromotionName", Order = 5, TypeName = "nvarchar")]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "French promotion name")]
        public string FrenchPromotionName { get; set; } // FrenchPromotionName (length: 255)

        [Column(@"DiscountPct", Order = 6, TypeName = "float")]
        [Display(Name = "Discount pct")]
        public double? DiscountPct { get; set; } // DiscountPct

        [Column(@"EnglishPromotionType", Order = 7, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "English promotion type")]
        public string EnglishPromotionType { get; set; } // EnglishPromotionType (length: 50)

        [Column(@"SpanishPromotionType", Order = 8, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Spanish promotion type")]
        public string SpanishPromotionType { get; set; } // SpanishPromotionType (length: 50)

        [Column(@"FrenchPromotionType", Order = 9, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "French promotion type")]
        public string FrenchPromotionType { get; set; } // FrenchPromotionType (length: 50)

        [Column(@"EnglishPromotionCategory", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "English promotion category")]
        public string EnglishPromotionCategory { get; set; } // EnglishPromotionCategory (length: 50)

        [Column(@"SpanishPromotionCategory", Order = 11, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Spanish promotion category")]
        public string SpanishPromotionCategory { get; set; } // SpanishPromotionCategory (length: 50)

        [Column(@"FrenchPromotionCategory", Order = 12, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "French promotion category")]
        public string FrenchPromotionCategory { get; set; } // FrenchPromotionCategory (length: 50)

        [Column(@"StartDate", Order = 13, TypeName = "datetime")]
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start date")]
        public System.DateTime StartDate { get; set; } // StartDate

        [Column(@"EndDate", Order = 14, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "End date")]
        public System.DateTime? EndDate { get; set; } // EndDate

        [Column(@"MinQty", Order = 15, TypeName = "int")]
        [Display(Name = "Min qty")]
        public int? MinQty { get; set; } // MinQty

        [Column(@"MaxQty", Order = 16, TypeName = "int")]
        [Display(Name = "Max qty")]
        public int? MaxQty { get; set; } // MaxQty

        // Reverse navigation

        /// <summary>
        /// Child FactInternetSales where [FactInternetSales].[PromotionKey] point to this entity (FK_FactInternetSales_DimPromotion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactInternetSale> FactInternetSales { get; set; } // FactInternetSales.FK_FactInternetSales_DimPromotion
        /// <summary>
        /// Child FactResellerSales where [FactResellerSales].[PromotionKey] point to this entity (FK_FactResellerSales_DimPromotion)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactResellerSale> FactResellerSales { get; set; } // FactResellerSales.FK_FactResellerSales_DimPromotion

        public DimPromotion()
        {
            FactInternetSales = new System.Collections.Generic.List<FactInternetSale>();
            FactResellerSales = new System.Collections.Generic.List<FactResellerSale>();
        }
    }

}
// </auto-generated>
