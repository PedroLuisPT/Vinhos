namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VinhoCasta")]
    public partial class VinhoCasta
    {
        [Key]
        public int IdVinhoCasta { get; set; }

        public int? Vinho { get; set; }

        public int? Casta { get; set; }

        public decimal? Percentagem { get; set; }

        public virtual Casta Casta1 { get; set; }

        public virtual Vinho Vinho1 { get; set; }
    }
}
