using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Categoria")]
    public class CategoriaViewModels
    {
        public CategoriaViewModels() { }

        [Key]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [Display(Name = "Categoria")]
        public string nombre { get; set; }
        
        [Column("descripcion")]
        [Display(Name = "Descripción")]
        public virtual string descripcion { get; set; }
        
    }
}