namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produtor")]
    public partial class Produtor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produtor()
        {
            Vinhoes = new HashSet<Vinho>();
        }

        [Key]
        public int IdProdutor { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [StringLength(150)]
        public string URL { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vinho> Vinhoes { get; set; }
    }
}
