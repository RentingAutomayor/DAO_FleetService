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
    
    public partial class VehicleModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleModel()
        {
            this.Vehicle = new HashSet<Vehicle>();
            this.maintenanceRoutine = new HashSet<maintenanceRoutine>();
            this.MaintenanceItemsByVehicleModels = new HashSet<MaintenanceItemsByVehicleModels>();
            this.VehicleModelsByContract = new HashSet<VehicleModelsByContract>();
        }
    
        public int vm_id { get; set; }
        public string vm_shortName { get; set; }
        public string vm_longName { get; set; }
        public Nullable<bool> vm_state { get; set; }
        public Nullable<System.DateTime> vm_registrationDate { get; set; }
        public Nullable<System.DateTime> vm_updateDate { get; set; }
        public Nullable<System.DateTime> vm_deleteDate { get; set; }
        public Nullable<int> vb_id { get; set; }
        public Nullable<int> vt_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<maintenanceRoutine> maintenanceRoutine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceItemsByVehicleModels> MaintenanceItemsByVehicleModels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleModelsByContract> VehicleModelsByContract { get; set; }
    }
}
