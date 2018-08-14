using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Producto")]
    public class ProductoViewModels
    {
        public ProductoViewModels() { }

        [Key]
        public int ProductoId { get; set; }

        [Required][Display(Name ="Producto")][Column("Nombre")]
        public string nombre { get; set; }

        [Required]
        [Column("Precio")]
        public float precio { get; set; }
        
        public virtual List<CategoriaViewModels> CategoriaId { get; set; }
    }
}