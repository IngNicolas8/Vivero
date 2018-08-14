using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Localidad")]
    public class LocalidadViewModels
    {
        public LocalidadViewModels() { }

        [Key]
        public int LocalidadId { get; set; }

        [Required]
        [Display(Name = "Localidad")]
        [Column("Localidad")]
        public string localidad { get; set; }
        
        public ProvinciaViewModels ProvinciaId { get; set; }
    }
}