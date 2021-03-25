
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
    
public partial class VehicleType
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public VehicleType()
    {

        this.VehicleModel = new HashSet<VehicleModel>();

        this.MaintenanceItemsByVehicleTypes = new HashSet<MaintenanceItemsByVehicleTypes>();

    }


    public int vt_id { get; set; }

    public string vt_name { get; set; }

    public string vt_description { get; set; }

    public Nullable<bool> vt_state { get; set; }

    public Nullable<System.DateTime> vt_registrationDate { get; set; }

    public Nullable<System.DateTime> vt_updateDate { get; set; }

    public Nullable<System.DateTime> vt_deleteDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<VehicleModel> VehicleModel { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MaintenanceItemsByVehicleTypes> MaintenanceItemsByVehicleTypes { get; set; }

}

}
