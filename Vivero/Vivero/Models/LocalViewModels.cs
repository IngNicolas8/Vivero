using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Local")]
    public class LocalViewModels
    {
        public LocalViewModels() { }

        [Key]
        public int LocalId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [Column("Nombre")]
        public string nombre { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email")]
        public string email { get; set; }
        
        [StringLength(13)][Display(Name ="Celular")][Column("Celular")]
        public string celular { get; set; }

        [StringLength(11)][Display(Name ="Telefono")][Column("Telefono")]
        public string telefono { get; set; }
        
        public DomicilioViewModels DomicilioId { get; set; }
    }
}