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

    // DimCustomer
    [Table("DimCustomer", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimCustomer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"CustomerKey", Order = 1, TypeName = "int")]
        [Index(@"PK_DimCustomer_CustomerKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Customer key")]
        public int CustomerKey { get; set; } // CustomerKey (Primary key)

        [Column(@"GeographyKey", Order = 2, TypeName = "int")]
        [Display(Name = "Geography key")]
        public int? GeographyKey { get; set; } // GeographyKey

        [Column(@"CustomerAlternateKey", Order = 3, TypeName = "nvarchar")]
        [Index(@"IX_DimCustomer_CustomerAlternateKey", 1, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Customer alternate key")]
        public string CustomerAlternateKey { get; set; } // CustomerAlternateKey (length: 15)

        [Column(@"Title", Order = 4, TypeName = "nvarchar")]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 8)

        [Column(@"FirstName", Order = 5, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 50)

        [Column(@"MiddleName", Order = 6, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        [Column(@"LastName", Order = 7, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 50)

        [Column(@"NameStyle", Order = 8, TypeName = "bit")]
        [Display(Name = "Name style")]
        public bool? NameStyle { get; set; } // NameStyle

        [Column(@"BirthDate", Order = 9, TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public System.DateTime? BirthDate { get; set; } // BirthDate

        [Column(@"MaritalStatus", Order = 10, TypeName = "nchar")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Marital status")]
        public string MaritalStatus { get; set; } // MaritalStatus (length: 1)

        [Column(@"Suffix", Order = 11, TypeName = "nvarchar")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Suffix")]
        public string Suffix { get; set; } // Suffix (length: 10)

        [Column(@"Gender", Order = 12, TypeName = "nvarchar")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Gender")]
        public string Gender { get; set; } // Gender (length: 1)

        [Column(@"EmailAddress", Order = 13, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; } // EmailAddress (length: 50)

        [Column(@"YearlyIncome", Order = 14, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Yearly income")]
        public decimal? YearlyIncome { get; set; } // YearlyIncome

        [Column(@"TotalChildren", Order = 15, TypeName = "tinyint")]
        [Display(Name = "Total children")]
        public byte? TotalChildren { get; set; } // TotalChildren

        [Column(@"NumberChildrenAtHome", Order = 16, TypeName = "tinyint")]
        [Display(Name = "Number children at home")]
        public byte? NumberChildrenAtHome { get; set; } // NumberChildrenAtHome

        [Column(@"EnglishEducation", Order = 17, TypeName = "nvarchar")]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "English education")]
        public string EnglishEducation { get; set; } // EnglishEducation (length: 40)

        [Column(@"SpanishEducation", Order = 18, TypeName = "nvarchar")]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Spanish education")]
        public string SpanishEducation { get; set; } // SpanishEducation (length: 40)

        [Column(@"FrenchEducation", Order = 19, TypeName = "nvarchar")]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "French education")]
        public string FrenchEducation { get; set; } // FrenchEducation (length: 40)

        [Column(@"EnglishOccupation", Order = 20, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "English occupation")]
        public string EnglishOccupation { get; set; } // EnglishOccupation (length: 100)

        [Column(@"SpanishOccupation", Order = 21, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Spanish occupation")]
        public string SpanishOccupation { get; set; } // SpanishOccupation (length: 100)

        [Column(@"FrenchOccupation", Order = 22, TypeName = "nvarchar")]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "French occupation")]
        public string FrenchOccupation { get; set; } // FrenchOccupation (length: 100)

        [Column(@"HouseOwnerFlag", Order = 23, TypeName = "nchar")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "House owner flag")]
        public string HouseOwnerFlag { get; set; } // HouseOwnerFlag (length: 1)

        [Column(@"NumberCarsOwned", Order = 24, TypeName = "tinyint")]
        [Display(Name = "Number cars owned")]
        public byte? NumberCarsOwned { get; set; } // NumberCarsOwned

        [Column(@"AddressLine1", Order = 25, TypeName = "nvarchar")]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; } // AddressLine1 (length: 120)

        [Column(@"AddressLine2", Order = 26, TypeName = "nvarchar")]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; } // AddressLine2 (length: 120)

        [Column(@"Phone", Order = 27, TypeName = "nvarchar")]
        [MaxLength(20)]
        [StringLength(20)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone (length: 20)

        [Column(@"DateFirstPurchase", Order = 28, TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Date first purchase")]
        public System.DateTime? DateFirstPurchase { get; set; } // DateFirstPurchase

        [Column(@"CommuteDistance", Order = 29, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Commute distance")]
        public string CommuteDistance { get; set; } // CommuteDistance (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child FactInternetSales where [FactInternetSales].[CustomerKey] point to this entity (FK_FactInternetSales_DimCustomer)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactInternetSale> FactInternetSales { get; set; } // FactInternetSales.FK_FactInternetSales_DimCustomer
        /// <summary>
        /// Child FactSurveyResponses where [FactSurveyResponse].[CustomerKey] point to this entity (FK_FactSurveyResponse_CustomerKey)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactSurveyResponse> FactSurveyResponses { get; set; } // FactSurveyResponse.FK_FactSurveyResponse_CustomerKey

        // Foreign keys

        /// <summary>
        /// Parent DimGeography pointed by [DimCustomer].([GeographyKey]) (FK_DimCustomer_DimGeography)
        /// </summary>
        [ForeignKey("GeographyKey")] public virtual DimGeography DimGeography { get; set; } // FK_DimCustomer_DimGeography

        public DimCustomer()
        {
            FactInternetSales = new System.Collections.Generic.List<FactInternetSale>();
            FactSurveyResponses = new System.Collections.Generic.List<FactSurveyResponse>();
        }
    }

}
// </auto-generated>
