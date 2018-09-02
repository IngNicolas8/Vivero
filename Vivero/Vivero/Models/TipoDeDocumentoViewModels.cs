using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vivero.Models
{
    [Table("TipoDeDocumento")]
    public class TipoDeDocumentoViewModels
    {
        [Key]
        public int tipoDeDocumentoId { get; set; }

        [Required]
        [Column("TipoDeDocumento")]
        [Display(Name = "Tipo de documento")]
        public string tipoDeDocumento { get; set; }
    }
}