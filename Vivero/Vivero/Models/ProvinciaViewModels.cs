using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Provincia")]
    public class ProvinciaViewModels
    {
        public ProvinciaViewModels() { }

        [Key]
        public int ProvinciaId { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        [Column("Provincia")]
        public string provincia { get; set; }
    }
}