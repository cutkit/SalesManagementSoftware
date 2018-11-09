namespace SalesManagementSoftware.EntityFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            BillInfoes = new HashSet<BillInfo>();
        }

        public int Id { get; set; }

        public int IdCategory { get; set; }

        [Required]
        [StringLength(100)]
        public string FoodName { get; set; }

        public double PriceFood { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillInfo> BillInfoes { get; set; }

        public virtual FoodCategory FoodCategory { get; set; }
    }
}
