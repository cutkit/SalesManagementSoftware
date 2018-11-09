namespace SalesManagementSoftware.EntityFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableCustomer")]
    public partial class TableCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableCustomer()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NameTable { get; set; }

        [Required]
        [StringLength(100)]
        public string StatusInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
