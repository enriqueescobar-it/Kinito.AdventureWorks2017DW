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

    // DimEmployee
    [Table("DimEmployee", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimEmployee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"EmployeeKey", Order = 1, TypeName = "int")]
        [Index(@"PK_DimEmployee_EmployeeKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Employee key")]
        public int EmployeeKey { get; set; } // EmployeeKey (Primary key)

        [Column(@"ParentEmployeeKey", Order = 2, TypeName = "int")]
        [Display(Name = "Parent employee key")]
        public int? ParentEmployeeKey { get; set; } // ParentEmployeeKey

        [Column(@"EmployeeNationalIDAlternateKey", Order = 3, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Employee national ida lternate key")]
        public string EmployeeNationalIdAlternateKey { get; set; } // EmployeeNationalIDAlternateKey (length: 15)

        [Column(@"ParentEmployeeNationalIDAlternateKey", Order = 4, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Parent employee national ida lternate key")]
        public string ParentEmployeeNationalIdAlternateKey { get; set; } // ParentEmployeeNationalIDAlternateKey (length: 15)

        [Column(@"SalesTerritoryKey", Order = 5, TypeName = "int")]
        [Display(Name = "Sales territory key")]
        public int? SalesTerritoryKey { get; set; } // SalesTerritoryKey

        [Column(@"FirstName", Order = 6, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; } // FirstName (length: 50)

        [Column(@"LastName", Order = 7, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; } // LastName (length: 50)

        [Column(@"MiddleName", Order = 8, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; } // MiddleName (length: 50)

        [Column(@"NameStyle", Order = 9, TypeName = "bit")]
        [Required]
        [Display(Name = "Name style")]
        public bool NameStyle { get; set; } // NameStyle

        [Column(@"Title", Order = 10, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; } // Title (length: 50)

        [Column(@"HireDate", Order = 11, TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Hire date")]
        public System.DateTime? HireDate { get; set; } // HireDate

        [Column(@"BirthDate", Order = 12, TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Birth date")]
        public System.DateTime? BirthDate { get; set; } // BirthDate

        [Column(@"LoginID", Order = 13, TypeName = "nvarchar")]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Login ID")]
        public string LoginId { get; set; } // LoginID (length: 256)

        [Column(@"EmailAddress", Order = 14, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string EmailAddress { get; set; } // EmailAddress (length: 50)

        [Column(@"Phone", Order = 15, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone (length: 25)

        [Column(@"MaritalStatus", Order = 16, TypeName = "nchar")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Marital status")]
        public string MaritalStatus { get; set; } // MaritalStatus (length: 1)

        [Column(@"EmergencyContactName", Order = 17, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Emergency contact name")]
        public string EmergencyContactName { get; set; } // EmergencyContactName (length: 50)

        [Column(@"EmergencyContactPhone", Order = 18, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Emergency contact phone")]
        public string EmergencyContactPhone { get; set; } // EmergencyContactPhone (length: 25)

        [Column(@"SalariedFlag", Order = 19, TypeName = "bit")]
        [Display(Name = "Salaried flag")]
        public bool? SalariedFlag { get; set; } // SalariedFlag

        [Column(@"Gender", Order = 20, TypeName = "nchar")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Gender")]
        public string Gender { get; set; } // Gender (length: 1)

        [Column(@"PayFrequency", Order = 21, TypeName = "tinyint")]
        [Display(Name = "Pay frequency")]
        public byte? PayFrequency { get; set; } // PayFrequency

        [Column(@"BaseRate", Order = 22, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Base rate")]
        public decimal? BaseRate { get; set; } // BaseRate

        [Column(@"VacationHours", Order = 23, TypeName = "smallint")]
        [Display(Name = "Vacation hours")]
        public short? VacationHours { get; set; } // VacationHours

        [Column(@"SickLeaveHours", Order = 24, TypeName = "smallint")]
        [Display(Name = "Sick leave hours")]
        public short? SickLeaveHours { get; set; } // SickLeaveHours

        [Column(@"CurrentFlag", Order = 25, TypeName = "bit")]
        [Required]
        [Display(Name = "Current flag")]
        public bool CurrentFlag { get; set; } // CurrentFlag

        [Column(@"SalesPersonFlag", Order = 26, TypeName = "bit")]
        [Required]
        [Display(Name = "Sales person flag")]
        public bool SalesPersonFlag { get; set; } // SalesPersonFlag

        [Column(@"DepartmentName", Order = 27, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Department name")]
        public string DepartmentName { get; set; } // DepartmentName (length: 50)

        [Column(@"StartDate", Order = 28, TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "Start date")]
        public System.DateTime? StartDate { get; set; } // StartDate

        [Column(@"EndDate", Order = 29, TypeName = "date")]
        [DataType(DataType.Date)]
        [Display(Name = "End date")]
        public System.DateTime? EndDate { get; set; } // EndDate

        [Column(@"Status", Order = 30, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Status")]
        public string Status { get; set; } // Status (length: 50)

        [Column(@"EmployeePhoto", Order = 31, TypeName = "varbinary(max)")]
        [Display(Name = "Employee photo")]
        public byte[] EmployeePhoto { get; set; } // EmployeePhoto

        // Reverse navigation

        /// <summary>
        /// Child DimEmployees where [DimEmployee].[ParentEmployeeKey] point to this entity (FK_DimEmployee_DimEmployee)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DimEmployee> DimEmployees { get; set; } // DimEmployee.FK_DimEmployee_DimEmployee
        /// <summary>
        /// Child FactResellerSales where [FactResellerSales].[EmployeeKey] point to this entity (FK_FactResellerSales_DimEmployee)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactResellerSale> FactResellerSales { get; set; } // FactResellerSales.FK_FactResellerSales_DimEmployee
        /// <summary>
        /// Child FactSalesQuotas where [FactSalesQuota].[EmployeeKey] point to this entity (FK_FactSalesQuota_DimEmployee)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactSalesQuota> FactSalesQuotas { get; set; } // FactSalesQuota.FK_FactSalesQuota_DimEmployee

        // Foreign keys

        /// <summary>
        /// Parent DimEmployee pointed by [DimEmployee].([ParentEmployeeKey]) (FK_DimEmployee_DimEmployee)
        /// </summary>
        [ForeignKey("ParentEmployeeKey")] public virtual DimEmployee DimEmployee_ParentEmployeeKey { get; set; } // FK_DimEmployee_DimEmployee

        /// <summary>
        /// Parent DimSalesTerritory pointed by [DimEmployee].([SalesTerritoryKey]) (FK_DimEmployee_DimSalesTerritory)
        /// </summary>
        [ForeignKey("SalesTerritoryKey")] public virtual DimSalesTerritory DimSalesTerritory { get; set; } // FK_DimEmployee_DimSalesTerritory

        public DimEmployee()
        {
            DimEmployees = new System.Collections.Generic.List<DimEmployee>();
            FactResellerSales = new System.Collections.Generic.List<FactResellerSale>();
            FactSalesQuotas = new System.Collections.Generic.List<FactSalesQuota>();
        }
    }

}
// </auto-generated>
