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
    
    public partial class MaintenanceItemsByVehicleModels
    {
        public int mivm_id { get; set; }
        public Nullable<int> mi_id { get; set; }
        public Nullable<int> vm_id { get; set; }
        public Nullable<System.DateTime> mivm_registrationDate { get; set; }
    
        public virtual MaintenanceItem MaintenanceItem { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
    }
}
