namespace gestaoVinho
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vinho")]
    public partial class Vinho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vinho()
        {
            VinhoCastas = new HashSet<VinhoCasta>();
            VinhoEnologoes = new HashSet<VinhoEnologo>();
        }

        [Key]
        public int IdVinho { get; set; }

        [Required]
        [StringLength(250)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Cor { get; set; }

        public int? Regiao { get; set; }

        public int? Produtor { get; set; }

        public decimal? Volume { get; set; }

        public decimal? TeorAlcoolico { get; set; }

        public int? Ano { get; set; }

        public virtual Produtor Produtor1 { get; set; }

        public virtual Regiao Regiao1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VinhoCasta> VinhoCastas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VinhoEnologo> VinhoEnologoes { get; set; }
    }
}
