namespace SalesManagementSoftware.EntityFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillInfoes = new HashSet<BillInfo>();
        }

        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCheckOut { get; set; }

        public int idTable { get; set; }

        public int StatusInfo { get; set; }

        public virtual TableCustomer TableCustomer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }
    }
}
