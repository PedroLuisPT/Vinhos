namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Casta")]
    public partial class Casta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Casta()
        {
            VinhoCastas = new HashSet<VinhoCasta>();
        }

        [Key]
        public int IdCasta { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [StringLength(1000)]
        public string Caracteristicas { get; set; }

        [StringLength(250)]
        public string Foto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VinhoCasta> VinhoCastas { get; set; }
    }
}
