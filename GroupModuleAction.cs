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
    
    public partial class GroupModuleAction
    {
        public int grpmdlact_id { get; set; }
        public int grp_id { get; set; }
        public int mdl_id { get; set; }
        public int act_id { get; set; }
    
        public virtual Actions Actions { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Modules Modules { get; set; }
    }
}
