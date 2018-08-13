using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    public class CategoriaViewModels
    {
        #region atributos

        [Required]
        private int idCategoria;

        [Required][Display(Name = "Categoria")]
        private string categoria;

        private string descripcion;

        #endregion

        #region propiedades

        public int IdTipo { get => idCategoria; set => idCategoria = value; }
        public string Tipo { get => categoria; set => categoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        #endregion

    }
}