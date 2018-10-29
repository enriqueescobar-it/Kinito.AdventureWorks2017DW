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


namespace Context
{
    using Configurations;
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AdventureWorksDWDbContext : System.Data.Entity.DbContext, IAdventureWorksDWDbContext
    {
        public System.Data.Entity.DbSet<DatabaseLog> DatabaseLogs { get; set; } // DatabaseLog
        public System.Data.Entity.DbSet<DimAccount> DimAccounts { get; set; } // DimAccount
        public System.Data.Entity.DbSet<DimCurrency> DimCurrencies { get; set; } // DimCurrency
        public System.Data.Entity.DbSet<DimCustomer> DimCustomers { get; set; } // DimCustomer
        public System.Data.Entity.DbSet<DimDate> DimDates { get; set; } // DimDate
        public System.Data.Entity.DbSet<DimDepartmentGroup> DimDepartmentGroups { get; set; } // DimDepartmentGroup
        public System.Data.Entity.DbSet<DimEmployee> DimEmployees { get; set; } // DimEmployee
        public System.Data.Entity.DbSet<DimGeography> DimGeographies { get; set; } // DimGeography
        public System.Data.Entity.DbSet<DimOrganization> DimOrganizations { get; set; } // DimOrganization
        public System.Data.Entity.DbSet<DimProduct> DimProducts { get; set; } // DimProduct
        public System.Data.Entity.DbSet<DimProductCategory> DimProductCategories { get; set; } // DimProductCategory
        public System.Data.Entity.DbSet<DimProductSubcategory> DimProductSubcategories { get; set; } // DimProductSubcategory
        public System.Data.Entity.DbSet<DimPromotion> DimPromotions { get; set; } // DimPromotion
        public System.Data.Entity.DbSet<DimReseller> DimResellers { get; set; } // DimReseller
        public System.Data.Entity.DbSet<DimSalesReason> DimSalesReasons { get; set; } // DimSalesReason
        public System.Data.Entity.DbSet<DimSalesTerritory> DimSalesTerritories { get; set; } // DimSalesTerritory
        public System.Data.Entity.DbSet<DimScenario> DimScenarios { get; set; } // DimScenario
        public System.Data.Entity.DbSet<FactAdditionalInternationalProductDescription> FactAdditionalInternationalProductDescriptions { get; set; } // FactAdditionalInternationalProductDescription
        public System.Data.Entity.DbSet<FactCallCenter> FactCallCenters { get; set; } // FactCallCenter
        public System.Data.Entity.DbSet<FactCurrencyRate> FactCurrencyRates { get; set; } // FactCurrencyRate
        public System.Data.Entity.DbSet<FactFinance> FactFinances { get; set; } // FactFinance
        public System.Data.Entity.DbSet<FactInternetSale> FactInternetSales { get; set; } // FactInternetSales
        public System.Data.Entity.DbSet<FactInternetSalesReason> FactInternetSalesReasons { get; set; } // FactInternetSalesReason
        public System.Data.Entity.DbSet<FactProductInventory> FactProductInventories { get; set; } // FactProductInventory
        public System.Data.Entity.DbSet<FactResellerSale> FactResellerSales { get; set; } // FactResellerSales
        public System.Data.Entity.DbSet<FactSalesQuota> FactSalesQuotas { get; set; } // FactSalesQuota
        public System.Data.Entity.DbSet<FactSurveyResponse> FactSurveyResponses { get; set; } // FactSurveyResponse
        public System.Data.Entity.DbSet<ProspectiveBuyer> ProspectiveBuyers { get; set; } // ProspectiveBuyer
        public System.Data.Entity.DbSet<VAssocSeqLineItem> VAssocSeqLineItems { get; set; } // vAssocSeqLineItems
        public System.Data.Entity.DbSet<VAssocSeqOrder> VAssocSeqOrders { get; set; } // vAssocSeqOrders
        public System.Data.Entity.DbSet<VDmPrep> VDmPreps { get; set; } // vDMPrep
        public System.Data.Entity.DbSet<VTargetMail> VTargetMails { get; set; } // vTargetMail
        public System.Data.Entity.DbSet<VTimeSery> VTimeSeries { get; set; } // vTimeSeries

        static AdventureWorksDWDbContext()
        {
            System.Data.Entity.Database.SetInitializer<AdventureWorksDWDbContext>(null);
        }

        public AdventureWorksDWDbContext()
            : base("Name=AdventureWorksDWConnectionString")
        {
        }

        public AdventureWorksDWDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public AdventureWorksDWDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public AdventureWorksDWDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public AdventureWorksDWDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new DatabaseLogConfiguration());
            modelBuilder.Configurations.Add(new DimAccountConfiguration());
            modelBuilder.Configurations.Add(new DimCurrencyConfiguration());
            modelBuilder.Configurations.Add(new DimCustomerConfiguration());
            modelBuilder.Configurations.Add(new DimDateConfiguration());
            modelBuilder.Configurations.Add(new DimDepartmentGroupConfiguration());
            modelBuilder.Configurations.Add(new DimEmployeeConfiguration());
            modelBuilder.Configurations.Add(new DimGeographyConfiguration());
            modelBuilder.Configurations.Add(new DimOrganizationConfiguration());
            modelBuilder.Configurations.Add(new DimProductConfiguration());
            modelBuilder.Configurations.Add(new DimProductCategoryConfiguration());
            modelBuilder.Configurations.Add(new DimProductSubcategoryConfiguration());
            modelBuilder.Configurations.Add(new DimPromotionConfiguration());
            modelBuilder.Configurations.Add(new DimResellerConfiguration());
            modelBuilder.Configurations.Add(new DimSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new DimSalesTerritoryConfiguration());
            modelBuilder.Configurations.Add(new DimScenarioConfiguration());
            modelBuilder.Configurations.Add(new FactAdditionalInternationalProductDescriptionConfiguration());
            modelBuilder.Configurations.Add(new FactCallCenterConfiguration());
            modelBuilder.Configurations.Add(new FactCurrencyRateConfiguration());
            modelBuilder.Configurations.Add(new FactFinanceConfiguration());
            modelBuilder.Configurations.Add(new FactInternetSaleConfiguration());
            modelBuilder.Configurations.Add(new FactInternetSalesReasonConfiguration());
            modelBuilder.Configurations.Add(new FactProductInventoryConfiguration());
            modelBuilder.Configurations.Add(new FactResellerSaleConfiguration());
            modelBuilder.Configurations.Add(new FactSalesQuotaConfiguration());
            modelBuilder.Configurations.Add(new FactSurveyResponseConfiguration());
            modelBuilder.Configurations.Add(new ProspectiveBuyerConfiguration());
            modelBuilder.Configurations.Add(new VAssocSeqLineItemConfiguration());
            modelBuilder.Configurations.Add(new VAssocSeqOrderConfiguration());
            modelBuilder.Configurations.Add(new VDmPrepConfiguration());
            modelBuilder.Configurations.Add(new VTargetMailConfiguration());
            modelBuilder.Configurations.Add(new VTimeSeryConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new DatabaseLogConfiguration(schema));
            modelBuilder.Configurations.Add(new DimAccountConfiguration(schema));
            modelBuilder.Configurations.Add(new DimCurrencyConfiguration(schema));
            modelBuilder.Configurations.Add(new DimCustomerConfiguration(schema));
            modelBuilder.Configurations.Add(new DimDateConfiguration(schema));
            modelBuilder.Configurations.Add(new DimDepartmentGroupConfiguration(schema));
            modelBuilder.Configurations.Add(new DimEmployeeConfiguration(schema));
            modelBuilder.Configurations.Add(new DimGeographyConfiguration(schema));
            modelBuilder.Configurations.Add(new DimOrganizationConfiguration(schema));
            modelBuilder.Configurations.Add(new DimProductConfiguration(schema));
            modelBuilder.Configurations.Add(new DimProductCategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new DimProductSubcategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new DimPromotionConfiguration(schema));
            modelBuilder.Configurations.Add(new DimResellerConfiguration(schema));
            modelBuilder.Configurations.Add(new DimSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new DimSalesTerritoryConfiguration(schema));
            modelBuilder.Configurations.Add(new DimScenarioConfiguration(schema));
            modelBuilder.Configurations.Add(new FactAdditionalInternationalProductDescriptionConfiguration(schema));
            modelBuilder.Configurations.Add(new FactCallCenterConfiguration(schema));
            modelBuilder.Configurations.Add(new FactCurrencyRateConfiguration(schema));
            modelBuilder.Configurations.Add(new FactFinanceConfiguration(schema));
            modelBuilder.Configurations.Add(new FactInternetSaleConfiguration(schema));
            modelBuilder.Configurations.Add(new FactInternetSalesReasonConfiguration(schema));
            modelBuilder.Configurations.Add(new FactProductInventoryConfiguration(schema));
            modelBuilder.Configurations.Add(new FactResellerSaleConfiguration(schema));
            modelBuilder.Configurations.Add(new FactSalesQuotaConfiguration(schema));
            modelBuilder.Configurations.Add(new FactSurveyResponseConfiguration(schema));
            modelBuilder.Configurations.Add(new ProspectiveBuyerConfiguration(schema));
            modelBuilder.Configurations.Add(new VAssocSeqLineItemConfiguration(schema));
            modelBuilder.Configurations.Add(new VAssocSeqOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new VDmPrepConfiguration(schema));
            modelBuilder.Configurations.Add(new VTargetMailConfiguration(schema));
            modelBuilder.Configurations.Add(new VTimeSeryConfiguration(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>