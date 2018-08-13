using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    public class ProductoViewModels
    {
        #region atributos

        [Key]
        private int idProducto;

        [Required][Display(Name ="Producto")]
        private string nombre;

        [Required]
        private float precio;

        private List<CategoriaViewModels> categoria;

        #endregion

        #region propiedades

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public List<CategoriaViewModels> Categoria { get => categoria; set => categoria = value; }

        #endregion
        
    }
}