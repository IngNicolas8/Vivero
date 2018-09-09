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
        public TipoDeDocumentoViewModels(){}

        [Key]
        public int TipoDeDocumentoId { get; set; }

        [Required]
        [Column("TipoDeDocumento")]
        [Display(Name = "Tipo de documento")]
        public string tipoDeDocumento { get; set; }
    }
}