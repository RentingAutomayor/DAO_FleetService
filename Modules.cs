
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
    
public partial class Modules
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Modules()
    {

        this.GroupModuleAction = new HashSet<GroupModuleAction>();

        this.GroupModuleAction1 = new HashSet<GroupModuleAction>();

    }


    public int mdl_id { get; set; }

    public string mdl_name { get; set; }

    public string mdl_path { get; set; }

    public string mdl_description { get; set; }

    public int mdl_father { get; set; }

    public bool mdl_state { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<GroupModuleAction> GroupModuleAction { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<GroupModuleAction> GroupModuleAction1 { get; set; }

}

}
