
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
    
public partial class PresentationUnit
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PresentationUnit()
    {

        this.MaintenanceItem = new HashSet<MaintenanceItem>();

    }


    public int pu_id { get; set; }

    public string pu_shortName { get; set; }

    public string pu_longName { get; set; }

    public Nullable<bool> pu_state { get; set; }

    public Nullable<System.DateTime> pu_registrationDate { get; set; }

    public Nullable<System.DateTime> pu_updateDate { get; set; }

    public Nullable<System.DateTime> pu_DeleteDate { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MaintenanceItem> MaintenanceItem { get; set; }

}

}
