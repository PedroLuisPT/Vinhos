namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VinhoEnologo")]
    public partial class VinhoEnologo
    {
        [Key]
        public int IDVinhoEnologo { get; set; }

        public int? Vinho { get; set; }

        public int? Enologo { get; set; }

        public virtual Enologo Enologo1 { get; set; }

        public virtual Vinho Vinho1 { get; set; }
    }
}
