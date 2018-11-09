namespace SalesManagementSoftware.EntityFW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillInfo")]
    public partial class BillInfo
    {
        public int Id { get; set; }

        public int idBill { get; set; }

        public int idFood { get; set; }

        public int CountFood { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Food Food { get; set; }
    }
}
