namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Enologo")]
    public partial class Enologo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Enologo()
        {
            VinhoEnologoes = new HashSet<VinhoEnologo>();
        }

        [Key]
        public int IdEnologo { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [StringLength(150)]
        public string Instragram { get; set; }

        [StringLength(150)]
        public string Twitter { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VinhoEnologo> VinhoEnologoes { get; set; }
    }
}
