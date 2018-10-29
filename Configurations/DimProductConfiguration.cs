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

namespace Configurations
{
    using Entities;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // DimProduct
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimProductConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DimProduct>
    {
        public DimProductConfiguration()
            : this("dbo")
        {
        }

        public DimProductConfiguration(string schema)
        {
            Property(x => x.ProductAlternateKey).IsOptional();
            Property(x => x.ProductSubcategoryKey).IsOptional();
            Property(x => x.WeightUnitMeasureCode).IsOptional().IsFixedLength();
            Property(x => x.SizeUnitMeasureCode).IsOptional().IsFixedLength();
            Property(x => x.StandardCost).IsOptional().HasPrecision(19,4);
            Property(x => x.SafetyStockLevel).IsOptional();
            Property(x => x.ReorderPoint).IsOptional();
            Property(x => x.ListPrice).IsOptional().HasPrecision(19,4);
            Property(x => x.Size).IsOptional();
            Property(x => x.SizeRange).IsOptional();
            Property(x => x.Weight).IsOptional();
            Property(x => x.DaysToManufacture).IsOptional();
            Property(x => x.ProductLine).IsOptional().IsFixedLength();
            Property(x => x.DealerPrice).IsOptional().HasPrecision(19,4);
            Property(x => x.Class).IsOptional().IsFixedLength();
            Property(x => x.Style).IsOptional().IsFixedLength();
            Property(x => x.ModelName).IsOptional();
            Property(x => x.LargePhoto).IsOptional();
            Property(x => x.EnglishDescription).IsOptional();
            Property(x => x.FrenchDescription).IsOptional();
            Property(x => x.ChineseDescription).IsOptional();
            Property(x => x.ArabicDescription).IsOptional();
            Property(x => x.HebrewDescription).IsOptional();
            Property(x => x.ThaiDescription).IsOptional();
            Property(x => x.GermanDescription).IsOptional();
            Property(x => x.JapaneseDescription).IsOptional();
            Property(x => x.TurkishDescription).IsOptional();
            Property(x => x.StartDate).IsOptional();
            Property(x => x.EndDate).IsOptional();
            Property(x => x.Status).IsOptional();

        }
    }

}
// </auto-generated>