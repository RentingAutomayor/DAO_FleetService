
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
    
public partial class MaintenanceItemCategory
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MaintenanceItemCategory()
    {

        this.MaintenanceItem = new HashSet<MaintenanceItem>();

    }


    public int mict_id { get; set; }

    public string mict_name { get; set; }

    public Nullable<bool> mict_state { get; set; }

    public Nullable<System.DateTime> mict_registrationDate { get; set; }

    public Nullable<System.DateTime> mict_updateDate { get; set; }

    public Nullable<System.DateTime> mict_deleteDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MaintenanceItem> MaintenanceItem { get; set; }

}

}
