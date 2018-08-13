using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    public class DetalleViewModels
    {
        #region atributos

        [Key]
        private int idDetalle;

        [Required]
        private int cantidad;

        private float subTotal;

        private int productoViewModels;

        #endregion

        #region propiedades

        public int IdDetalle { get => idDetalle; set => idDetalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float SubTotal { get => subTotal; set => subTotal = value; }
        public int ProductoViewModels { get => productoViewModels; set => productoViewModels = value; }

        #endregion
    }
}