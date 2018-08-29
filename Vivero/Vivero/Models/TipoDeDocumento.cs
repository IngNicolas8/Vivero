using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    public class TipoDeDocumento
    {
        [Key]
        public int tipoDeDocumentoId { get; set; }

        [Required]
        [Column("TipoDeDocumento")]
        [Display(Name = "Tipo de DNI")]
        public string tipoDeDocumento { get; set; }
    }
}