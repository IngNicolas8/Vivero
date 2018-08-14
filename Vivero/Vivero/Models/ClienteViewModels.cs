﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Cliente")]
    public class ClienteViewModels
    {
        public ClienteViewModels() { }

        [Required]
        [EmailAddress]
        [Key]
        public string EmailId { get; set; }

        [Required][Display(Name ="Nombre")][Column("Nombre")]
        public string Nombre{ get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Column("Fecha")]
        public DateTime fecha { get; set; }

        [Display(Name = "Telefono")]
        [StringLength(11)]
        [Column("Telefono")]
        public string telefono { get; set; }

        [Display(Name = "Celular")][StringLength(13)][Column("Celular")]
        public string celular { get; set; }
        
        public DomicilioViewModels DomicilioId { get; set; }
        
        public List<FacturaViewModels> FacturaId { get; set; }
    }
}