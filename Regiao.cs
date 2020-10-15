namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Regiao")]
    public partial class Regiao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Regiao()
        {
            Vinhoes = new HashSet<Vinho>();
        }

        [Key]
        public int IdRegiao { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [StringLength(1000)]
        public string Caracteristicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vinho> Vinhoes { get; set; }
    }
}
