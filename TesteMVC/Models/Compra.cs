namespace TesteMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compra")]
    public partial class Compra
    {
        public int Id { get; set; }

        public decimal? Valor { get; set; }

        public int? ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
