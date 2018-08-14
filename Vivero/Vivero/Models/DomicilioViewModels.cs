﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    [Table("Domicilio")]
    public class DomicilioViewModels
    {
        public DomicilioViewModels() { }

        [Key]
        public int DomicilioId { get; set; }

        [Required]
        [Display(Name = "Calle")]
        [Column("Calle")]
        public string calle { get; set; }

        [Required]
        [Display(Name = "N°")]
        [Column("Nro")]
        public int nro { get; set; }
        
        public LocalidadViewModels LocalidadId { get; set; }
    }
}