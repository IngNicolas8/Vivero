using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    public class FacturaViewModels
    {
        #region atributos

        [Key]
        private int idFactura;

        [Required][Display(Name = "Fecha")]
        private DateTime fecha;

        [Required] [Display(Name = "Total")]
        private float total;

        private DetalleViewModels detalle;

        private 
        #endregion

        #region propiedades

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Total { get => total; set => total = value; }
        public DetalleViewModels Detalle { get => detalle; set => detalle = value; }

        #endregion
    }
}