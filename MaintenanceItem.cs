
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
    
public partial class MaintenanceItem
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MaintenanceItem()
    {

        this.MaintenanceItemsByVehicleTypes = new HashSet<MaintenanceItemsByVehicleTypes>();

        this.MaintenanceItemsByVehicleModels = new HashSet<MaintenanceItemsByVehicleModels>();

        this.ItemsByRoutines = new HashSet<ItemsByRoutines>();

        this.ItemsByRoutines1 = new HashSet<ItemsByRoutines>();

        this.PricesByContract = new HashSet<PricesByContract>();

        this.PricesByDealer = new HashSet<PricesByDealer>();

        this.transactionItems = new HashSet<transactionItems>();

        this.TaxesByMaintenanceItem = new HashSet<TaxesByMaintenanceItem>();

    }


    public int mi_id { get; set; }

    public string mi_code { get; set; }

    public string mi_name { get; set; }

    public string mi_description { get; set; }

    public int tmi_id { get; set; }

    public int pu_id { get; set; }

    public Nullable<float> mi_referencePrice { get; set; }

    public Nullable<bool> mi_state { get; set; }

    public Nullable<System.DateTime> mi_registrationDate { get; set; }

    public Nullable<System.DateTime> mi_updateDate { get; set; }

    public Nullable<System.DateTime> mi_deleteDate { get; set; }

    public Nullable<int> mict_id { get; set; }

    public bool mi_handleTax { get; set; }

    public Nullable<int> deal_id { get; set; }



    public virtual PresentationUnit PresentationUnit { get; set; }

    public virtual TypeOfMaintenanceItem TypeOfMaintenanceItem { get; set; }

    public virtual MaintenanceItemCategory MaintenanceItemCategory { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MaintenanceItemsByVehicleTypes> MaintenanceItemsByVehicleTypes { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MaintenanceItemsByVehicleModels> MaintenanceItemsByVehicleModels { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ItemsByRoutines> ItemsByRoutines { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ItemsByRoutines> ItemsByRoutines1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PricesByContract> PricesByContract { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<PricesByDealer> PricesByDealer { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<transactionItems> transactionItems { get; set; }

    public virtual Dealer Dealer { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TaxesByMaintenanceItem> TaxesByMaintenanceItem { get; set; }

}

}
