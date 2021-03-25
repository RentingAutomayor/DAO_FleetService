
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
    using System.Collections.Generic;
    
public partial class Vehicle
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Vehicle()
    {

        this.VehiclesByContract = new HashSet<VehiclesByContract>();

        this.transactionDetail = new HashSet<transactionDetail>();

    }


    public int veh_id { get; set; }

    public string veh_licensePlate { get; set; }

    public string veh_chasisCode { get; set; }

    public Nullable<int> vm_id { get; set; }

    public string veh_year { get; set; }

    public Nullable<int> veh_mileage { get; set; }

    public Nullable<int> cli_id { get; set; }

    public Nullable<bool> veh_state { get; set; }

    public Nullable<System.DateTime> veh_registrationDate { get; set; }

    public Nullable<System.DateTime> veh_updateDate { get; set; }

    public Nullable<System.DateTime> veh_deleteDate { get; set; }

    public Nullable<int> vs_id { get; set; }



    public virtual Client Client { get; set; }

    public virtual VehicleModel VehicleModel { get; set; }

    public virtual vehicleState vehicleState { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<VehiclesByContract> VehiclesByContract { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<transactionDetail> transactionDetail { get; set; }

}

}
