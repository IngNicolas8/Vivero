using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Factura")]
    public class FacturaViewModels
    {
        public FacturaViewModels() { }

        [Key]
        public int FacturaId { get; set; }

        [Required][Display(Name = "Fecha")][Column("Fecha")]
        public DateTime fecha { get; set; }

        [Required] [Display(Name = "Total")][Column("Total")]
        public float total { get; set; }
        
        public LocalViewModels LocalId { get; set; }
        
        public ClienteViewModels EmailId { get; set; }
        
        public DetalleViewModels DetalleId { get; set; }
    }
}