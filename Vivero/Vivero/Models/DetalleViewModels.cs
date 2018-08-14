using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Detalle")]
    public class DetalleViewModels
    {
        public DetalleViewModels() { }

        [Key]
        public int DetalleId { get; set; }

        [Required]
        [Column("Cantidad")]
        public int cantidad { get; set; }

        [Column("SubTotal")]
        public float subTotal { get; set; }
        
        public ProductoViewModels ProductoId { get; set; }
    }
}