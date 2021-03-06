﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DAO_FleetService
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class DB_FleetServiceEntities : DbContext
{
    public DB_FleetServiceEntities()
        : base("name=DB_FleetServiceEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<areas> areas { get; set; }

    public virtual DbSet<branch> branch { get; set; }

    public virtual DbSet<Cities> Cities { get; set; }

    public virtual DbSet<Client> Client { get; set; }

    public virtual DbSet<Contact> Contact { get; set; }

    public virtual DbSet<Countries> Countries { get; set; }

    public virtual DbSet<Dealer> Dealer { get; set; }

    public virtual DbSet<DealerByDealerNerwork> DealerByDealerNerwork { get; set; }

    public virtual DbSet<DealerNetwork> DealerNetwork { get; set; }

    public virtual DbSet<Departments> Departments { get; set; }

    public virtual DbSet<jobTitle> jobTitle { get; set; }

    public virtual DbSet<JobTitlesClient> JobTitlesClient { get; set; }

    public virtual DbSet<Vehicle> Vehicle { get; set; }

    public virtual DbSet<VehicleBrand> VehicleBrand { get; set; }

    public virtual DbSet<VehicleModel> VehicleModel { get; set; }

    public virtual DbSet<VehicleType> VehicleType { get; set; }

    public virtual DbSet<vehicleState> vehicleState { get; set; }

    public virtual DbSet<MaintenanceItem> MaintenanceItem { get; set; }

    public virtual DbSet<PresentationUnit> PresentationUnit { get; set; }

    public virtual DbSet<TypeOfMaintenanceItem> TypeOfMaintenanceItem { get; set; }

    public virtual DbSet<frequency> frequency { get; set; }

    public virtual DbSet<maintenanceRoutine> maintenanceRoutine { get; set; }

    public virtual DbSet<MaintenanceItemCategory> MaintenanceItemCategory { get; set; }

    public virtual DbSet<MaintenanceItemsByVehicleModels> MaintenanceItemsByVehicleModels { get; set; }

    public virtual DbSet<MaintenanceItemsByVehicleTypes> MaintenanceItemsByVehicleTypes { get; set; }

    public virtual DbSet<ItemsByRoutines> ItemsByRoutines { get; set; }

    public virtual DbSet<Contract> Contract { get; set; }

    public virtual DbSet<ContractState> ContractState { get; set; }

    public virtual DbSet<DiscountType> DiscountType { get; set; }

    public virtual DbSet<VehicleModelsByContract> VehicleModelsByContract { get; set; }

    public virtual DbSet<VehiclesByContract> VehiclesByContract { get; set; }

    public virtual DbSet<Actions> Actions { get; set; }

    public virtual DbSet<FieldsToOperate> FieldsToOperate { get; set; }

    public virtual DbSet<FinancialInformationByClient> FinancialInformationByClient { get; set; }

    public virtual DbSet<GroupModuleAction> GroupModuleAction { get; set; }

    public virtual DbSet<Groups> Groups { get; set; }

    public virtual DbSet<LOG_TRX> LOG_TRX { get; set; }

    public virtual DbSet<Modules> Modules { get; set; }

    public virtual DbSet<Movement> Movement { get; set; }

    public virtual DbSet<MovementType> MovementType { get; set; }

    public virtual DbSet<observationsByTransaction> observationsByTransaction { get; set; }

    public virtual DbSet<Operations> Operations { get; set; }

    public virtual DbSet<PricesByContract> PricesByContract { get; set; }

    public virtual DbSet<PricesByDealer> PricesByDealer { get; set; }

    public virtual DbSet<RulesByMovement> RulesByMovement { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<transactionDetail> transactionDetail { get; set; }

    public virtual DbSet<transactionItems> transactionItems { get; set; }

    public virtual DbSet<transactions> transactions { get; set; }

    public virtual DbSet<transactionState> transactionState { get; set; }

    public virtual DbSet<Users> Users { get; set; }

    public virtual DbSet<Company> Company { get; set; }

    public virtual DbSet<Taxes> Taxes { get; set; }

    public virtual DbSet<TaxesByMaintenanceItem> TaxesByMaintenanceItem { get; set; }


    public virtual ObjectResult<STRPRC_GET_CLIENTS_WITHOUT_QUOTA_Result> STRPRC_GET_CLIENTS_WITHOUT_QUOTA()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_CLIENTS_WITHOUT_QUOTA_Result>("STRPRC_GET_CLIENTS_WITHOUT_QUOTA");
    }


    public virtual ObjectResult<STRPRC_GET_FINANCIAL_INFORMATION_BY_CLIENT_Result> STRPRC_GET_FINANCIAL_INFORMATION_BY_CLIENT()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_FINANCIAL_INFORMATION_BY_CLIENT_Result>("STRPRC_GET_FINANCIAL_INFORMATION_BY_CLIENT");
    }


    public virtual ObjectResult<STRPRC_GET_TRANSACTIONS_TODAY_Result> STRPRC_GET_TRANSACTIONS_TODAY()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_TRANSACTIONS_TODAY_Result>("STRPRC_GET_TRANSACTIONS_TODAY");
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT_Result> STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT(Nullable<int> cLIENT_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT_Result>("STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT", cLIENT_IDParameter);
    }


    public virtual int STRPRC_PROCESS_RULES_OF_TRANSACTION(Nullable<int> cLIENT_ID, Nullable<int> mOVEMENT_ID, Nullable<decimal> tRX_VALUE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var mOVEMENT_IDParameter = mOVEMENT_ID.HasValue ?
            new ObjectParameter("MOVEMENT_ID", mOVEMENT_ID) :
            new ObjectParameter("MOVEMENT_ID", typeof(int));


        var tRX_VALUEParameter = tRX_VALUE.HasValue ?
            new ObjectParameter("TRX_VALUE", tRX_VALUE) :
            new ObjectParameter("TRX_VALUE", typeof(decimal));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_PROCESS_RULES_OF_TRANSACTION", cLIENT_IDParameter, mOVEMENT_IDParameter, tRX_VALUEParameter);
    }


    public virtual int STRPRC_PROCESS_TRANSACTION(Nullable<int> cLIENT_ID, Nullable<int> mOVEMENT_ID, Nullable<decimal> tRX_VALUE_WITHOUT_TAXES, Nullable<decimal> tRX_TAXES_VALUE, Nullable<decimal> tRX_VALUE, Nullable<int> tRX_STATE, Nullable<int> uSER_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var mOVEMENT_IDParameter = mOVEMENT_ID.HasValue ?
            new ObjectParameter("MOVEMENT_ID", mOVEMENT_ID) :
            new ObjectParameter("MOVEMENT_ID", typeof(int));


        var tRX_VALUE_WITHOUT_TAXESParameter = tRX_VALUE_WITHOUT_TAXES.HasValue ?
            new ObjectParameter("TRX_VALUE_WITHOUT_TAXES", tRX_VALUE_WITHOUT_TAXES) :
            new ObjectParameter("TRX_VALUE_WITHOUT_TAXES", typeof(decimal));


        var tRX_TAXES_VALUEParameter = tRX_TAXES_VALUE.HasValue ?
            new ObjectParameter("TRX_TAXES_VALUE", tRX_TAXES_VALUE) :
            new ObjectParameter("TRX_TAXES_VALUE", typeof(decimal));


        var tRX_VALUEParameter = tRX_VALUE.HasValue ?
            new ObjectParameter("TRX_VALUE", tRX_VALUE) :
            new ObjectParameter("TRX_VALUE", typeof(decimal));


        var tRX_STATEParameter = tRX_STATE.HasValue ?
            new ObjectParameter("TRX_STATE", tRX_STATE) :
            new ObjectParameter("TRX_STATE", typeof(int));


        var uSER_IDParameter = uSER_ID.HasValue ?
            new ObjectParameter("USER_ID", uSER_ID) :
            new ObjectParameter("USER_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_PROCESS_TRANSACTION", cLIENT_IDParameter, mOVEMENT_IDParameter, tRX_VALUE_WITHOUT_TAXESParameter, tRX_TAXES_VALUEParameter, tRX_VALUEParameter, tRX_STATEParameter, uSER_IDParameter);
    }


    public virtual int STRPRC_UPDATE_LOG_TRANSACTION(Nullable<int> tRX_ID, Nullable<double> aPPROVED_QUOTA, Nullable<double> cONSUMED_QUOTA, Nullable<double> cURRENT_QUOTA, Nullable<double> iN_TRANSIT_QUOTA)
    {

        var tRX_IDParameter = tRX_ID.HasValue ?
            new ObjectParameter("TRX_ID", tRX_ID) :
            new ObjectParameter("TRX_ID", typeof(int));


        var aPPROVED_QUOTAParameter = aPPROVED_QUOTA.HasValue ?
            new ObjectParameter("APPROVED_QUOTA", aPPROVED_QUOTA) :
            new ObjectParameter("APPROVED_QUOTA", typeof(double));


        var cONSUMED_QUOTAParameter = cONSUMED_QUOTA.HasValue ?
            new ObjectParameter("CONSUMED_QUOTA", cONSUMED_QUOTA) :
            new ObjectParameter("CONSUMED_QUOTA", typeof(double));


        var cURRENT_QUOTAParameter = cURRENT_QUOTA.HasValue ?
            new ObjectParameter("CURRENT_QUOTA", cURRENT_QUOTA) :
            new ObjectParameter("CURRENT_QUOTA", typeof(double));


        var iN_TRANSIT_QUOTAParameter = iN_TRANSIT_QUOTA.HasValue ?
            new ObjectParameter("IN_TRANSIT_QUOTA", iN_TRANSIT_QUOTA) :
            new ObjectParameter("IN_TRANSIT_QUOTA", typeof(double));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_UPDATE_LOG_TRANSACTION", tRX_IDParameter, aPPROVED_QUOTAParameter, cONSUMED_QUOTAParameter, cURRENT_QUOTAParameter, iN_TRANSIT_QUOTAParameter);
    }


    public virtual int STRPRC_CREATE_FINANCIAL_INFORMATION(Nullable<int> cLIENT_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_CREATE_FINANCIAL_INFORMATION", cLIENT_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_BY_DEALER_Result> STRPRC_GET_WORKORDERS_BY_DEALER(Nullable<int> dEALER_ID)
    {

        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_BY_DEALER_Result>("STRPRC_GET_WORKORDERS_BY_DEALER", dEALER_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_BY_DEALER1_Result> STRPRC_GET_WORKORDERS_BY_DEALER1(Nullable<int> dEALER_ID)
    {

        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_BY_DEALER1_Result>("STRPRC_GET_WORKORDERS_BY_DEALER1", dEALER_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_TRANSACTIONS_BY_CLIENT_Result1> STRPRC_GET_TRANSACTIONS_BY_CLIENT(Nullable<int> cLIENT_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_TRANSACTIONS_BY_CLIENT_Result1>("STRPRC_GET_TRANSACTIONS_BY_CLIENT", cLIENT_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_VEHICLES_WITHOUT_CONTRACT_Result> STRPRC_GET_VEHICLES_WITHOUT_CONTRACT(Nullable<int> cLIENT_ID, Nullable<int> cONTRACT_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var cONTRACT_IDParameter = cONTRACT_ID.HasValue ?
            new ObjectParameter("CONTRACT_ID", cONTRACT_ID) :
            new ObjectParameter("CONTRACT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_VEHICLES_WITHOUT_CONTRACT_Result>("STRPRC_GET_VEHICLES_WITHOUT_CONTRACT", cLIENT_IDParameter, cONTRACT_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_BY_DEALER2_Result> STRPRC_GET_WORKORDERS_BY_DEALER2(Nullable<int> dEALER_ID)
    {

        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_BY_DEALER2_Result>("STRPRC_GET_WORKORDERS_BY_DEALER2", dEALER_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_BY_DEALER3_Result> STRPRC_GET_WORKORDERS_BY_DEALER3(Nullable<int> dEALER_ID)
    {

        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_BY_DEALER3_Result>("STRPRC_GET_WORKORDERS_BY_DEALER3", dEALER_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT1_Result> STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT1(Nullable<int> cLIENT_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT1_Result>("STRPRC_GET_WORKORDERS_TO_APPROVE_BY_CLIENT1", cLIENT_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_TRANSACTIONS_TODAY1_Result> STRPRC_GET_TRANSACTIONS_TODAY1()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_TRANSACTIONS_TODAY1_Result>("STRPRC_GET_TRANSACTIONS_TODAY1");
    }


    public virtual int STRPRC_PROCESS_TRANSACTION_V2(Nullable<int> cLIENT_ID, Nullable<int> mOVEMENT_ID, Nullable<decimal> tRX_VALUE_WITHOUT_DISCOUNT, Nullable<decimal> tRX_DISCOUNT_VALUE, Nullable<decimal> tRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXES, Nullable<decimal> tRX_TAXES_VALUE, Nullable<decimal> tRX_VALUE, Nullable<int> tRX_STATE, Nullable<int> uSER_ID)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var mOVEMENT_IDParameter = mOVEMENT_ID.HasValue ?
            new ObjectParameter("MOVEMENT_ID", mOVEMENT_ID) :
            new ObjectParameter("MOVEMENT_ID", typeof(int));


        var tRX_VALUE_WITHOUT_DISCOUNTParameter = tRX_VALUE_WITHOUT_DISCOUNT.HasValue ?
            new ObjectParameter("TRX_VALUE_WITHOUT_DISCOUNT", tRX_VALUE_WITHOUT_DISCOUNT) :
            new ObjectParameter("TRX_VALUE_WITHOUT_DISCOUNT", typeof(decimal));


        var tRX_DISCOUNT_VALUEParameter = tRX_DISCOUNT_VALUE.HasValue ?
            new ObjectParameter("TRX_DISCOUNT_VALUE", tRX_DISCOUNT_VALUE) :
            new ObjectParameter("TRX_DISCOUNT_VALUE", typeof(decimal));


        var tRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXESParameter = tRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXES.HasValue ?
            new ObjectParameter("TRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXES", tRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXES) :
            new ObjectParameter("TRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXES", typeof(decimal));


        var tRX_TAXES_VALUEParameter = tRX_TAXES_VALUE.HasValue ?
            new ObjectParameter("TRX_TAXES_VALUE", tRX_TAXES_VALUE) :
            new ObjectParameter("TRX_TAXES_VALUE", typeof(decimal));


        var tRX_VALUEParameter = tRX_VALUE.HasValue ?
            new ObjectParameter("TRX_VALUE", tRX_VALUE) :
            new ObjectParameter("TRX_VALUE", typeof(decimal));


        var tRX_STATEParameter = tRX_STATE.HasValue ?
            new ObjectParameter("TRX_STATE", tRX_STATE) :
            new ObjectParameter("TRX_STATE", typeof(int));


        var uSER_IDParameter = uSER_ID.HasValue ?
            new ObjectParameter("USER_ID", uSER_ID) :
            new ObjectParameter("USER_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("STRPRC_PROCESS_TRANSACTION_V2", cLIENT_IDParameter, mOVEMENT_IDParameter, tRX_VALUE_WITHOUT_DISCOUNTParameter, tRX_DISCOUNT_VALUEParameter, tRX_VALUE_WITH_DISCOUNT_WITHOUT_TAXESParameter, tRX_TAXES_VALUEParameter, tRX_VALUEParameter, tRX_STATEParameter, uSER_IDParameter);
    }


    public virtual ObjectResult<STRPRC_GET_COUNT_TOTAL_WORKORDER_BY_DEALER_AND_CLIENT_Result> STRPRC_GET_COUNT_TOTAL_WORKORDER_BY_DEALER_AND_CLIENT(Nullable<int> dEALER_ID, Nullable<int> cLIENT_ID, Nullable<System.DateTime> iNIT_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var iNIT_DATEParameter = iNIT_DATE.HasValue ?
            new ObjectParameter("INIT_DATE", iNIT_DATE) :
            new ObjectParameter("INIT_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_COUNT_TOTAL_WORKORDER_BY_DEALER_AND_CLIENT_Result>("STRPRC_GET_COUNT_TOTAL_WORKORDER_BY_DEALER_AND_CLIENT", dEALER_IDParameter, cLIENT_IDParameter, iNIT_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_APPROVED_BY_VEHICLE_Result> STRPRC_GET_WORKORDERS_APPROVED_BY_VEHICLE(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, string lICENSE_PLATE, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var lICENSE_PLATEParameter = lICENSE_PLATE != null ?
            new ObjectParameter("LICENSE_PLATE", lICENSE_PLATE) :
            new ObjectParameter("LICENSE_PLATE", typeof(string));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_APPROVED_BY_VEHICLE_Result>("STRPRC_GET_WORKORDERS_APPROVED_BY_VEHICLE", cLIENT_IDParameter, dEALER_IDParameter, lICENSE_PLATEParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_CANCELED_BY_VEHICLE_Result> STRPRC_GET_WORKORDERS_CANCELED_BY_VEHICLE(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, string lICENSE_PLATE, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var lICENSE_PLATEParameter = lICENSE_PLATE != null ?
            new ObjectParameter("LICENSE_PLATE", lICENSE_PLATE) :
            new ObjectParameter("LICENSE_PLATE", typeof(string));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_CANCELED_BY_VEHICLE_Result>("STRPRC_GET_WORKORDERS_CANCELED_BY_VEHICLE", cLIENT_IDParameter, dEALER_IDParameter, lICENSE_PLATEParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_VALUES_BY_MONTH_Result> STRPRC_GET_WORKORDERS_VALUES_BY_MONTH(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_VALUES_BY_MONTH_Result>("STRPRC_GET_WORKORDERS_VALUES_BY_MONTH", cLIENT_IDParameter, dEALER_IDParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_AMOUNT_WORKORDERS_BY_CLIENT_AND_MONTH_Result> STRPRC_GET_AMOUNT_WORKORDERS_BY_CLIENT_AND_MONTH(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_AMOUNT_WORKORDERS_BY_CLIENT_AND_MONTH_Result>("STRPRC_GET_AMOUNT_WORKORDERS_BY_CLIENT_AND_MONTH", cLIENT_IDParameter, dEALER_IDParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_AMOUNT_WORKORDERS_BY_DEALER_AND_MONTH_Result> STRPRC_GET_AMOUNT_WORKORDERS_BY_DEALER_AND_MONTH(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_AMOUNT_WORKORDERS_BY_DEALER_AND_MONTH_Result>("STRPRC_GET_AMOUNT_WORKORDERS_BY_DEALER_AND_MONTH", cLIENT_IDParameter, dEALER_IDParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_PENDING_BY_VEHICLE_Result> STRPRC_GET_WORKORDERS_PENDING_BY_VEHICLE(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, string lICENSE_PLATE, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var lICENSE_PLATEParameter = lICENSE_PLATE != null ?
            new ObjectParameter("LICENSE_PLATE", lICENSE_PLATE) :
            new ObjectParameter("LICENSE_PLATE", typeof(string));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_PENDING_BY_VEHICLE_Result>("STRPRC_GET_WORKORDERS_PENDING_BY_VEHICLE", cLIENT_IDParameter, dEALER_IDParameter, lICENSE_PLATEParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_TRANSACTIONS_BY_CLIENT_OR_DEALER_Result> STRPRC_GET_TRANSACTIONS_BY_CLIENT_OR_DEALER(Nullable<int> dEALER_ID, Nullable<int> cLIENT_ID, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE, string cODE, string lICENSE_PLATE, Nullable<int> sTATE_WORK_ORDER)
    {

        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        var cODEParameter = cODE != null ?
            new ObjectParameter("CODE", cODE) :
            new ObjectParameter("CODE", typeof(string));


        var lICENSE_PLATEParameter = lICENSE_PLATE != null ?
            new ObjectParameter("LICENSE_PLATE", lICENSE_PLATE) :
            new ObjectParameter("LICENSE_PLATE", typeof(string));


        var sTATE_WORK_ORDERParameter = sTATE_WORK_ORDER.HasValue ?
            new ObjectParameter("STATE_WORK_ORDER", sTATE_WORK_ORDER) :
            new ObjectParameter("STATE_WORK_ORDER", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_TRANSACTIONS_BY_CLIENT_OR_DEALER_Result>("STRPRC_GET_TRANSACTIONS_BY_CLIENT_OR_DEALER", dEALER_IDParameter, cLIENT_IDParameter, iNI_DATEParameter, eND_DATEParameter, cODEParameter, lICENSE_PLATEParameter, sTATE_WORK_ORDERParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_ANNUL_BY_VEHICLE_Result> STRPRC_GET_WORKORDERS_ANNUL_BY_VEHICLE(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, string lICENSE_PLATE, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var lICENSE_PLATEParameter = lICENSE_PLATE != null ?
            new ObjectParameter("LICENSE_PLATE", lICENSE_PLATE) :
            new ObjectParameter("LICENSE_PLATE", typeof(string));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_ANNUL_BY_VEHICLE_Result>("STRPRC_GET_WORKORDERS_ANNUL_BY_VEHICLE", cLIENT_IDParameter, dEALER_IDParameter, lICENSE_PLATEParameter, iNI_DATEParameter, eND_DATEParameter);
    }


    public virtual ObjectResult<STRPRC_GET_WORKORDERS_FINISHED_BY_VEHICLE_Result> STRPRC_GET_WORKORDERS_FINISHED_BY_VEHICLE(Nullable<int> cLIENT_ID, Nullable<int> dEALER_ID, string lICENSE_PLATE, Nullable<System.DateTime> iNI_DATE, Nullable<System.DateTime> eND_DATE)
    {

        var cLIENT_IDParameter = cLIENT_ID.HasValue ?
            new ObjectParameter("CLIENT_ID", cLIENT_ID) :
            new ObjectParameter("CLIENT_ID", typeof(int));


        var dEALER_IDParameter = dEALER_ID.HasValue ?
            new ObjectParameter("DEALER_ID", dEALER_ID) :
            new ObjectParameter("DEALER_ID", typeof(int));


        var lICENSE_PLATEParameter = lICENSE_PLATE != null ?
            new ObjectParameter("LICENSE_PLATE", lICENSE_PLATE) :
            new ObjectParameter("LICENSE_PLATE", typeof(string));


        var iNI_DATEParameter = iNI_DATE.HasValue ?
            new ObjectParameter("INI_DATE", iNI_DATE) :
            new ObjectParameter("INI_DATE", typeof(System.DateTime));


        var eND_DATEParameter = eND_DATE.HasValue ?
            new ObjectParameter("END_DATE", eND_DATE) :
            new ObjectParameter("END_DATE", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STRPRC_GET_WORKORDERS_FINISHED_BY_VEHICLE_Result>("STRPRC_GET_WORKORDERS_FINISHED_BY_VEHICLE", cLIENT_IDParameter, dEALER_IDParameter, lICENSE_PLATEParameter, iNI_DATEParameter, eND_DATEParameter);
    }

}

}

