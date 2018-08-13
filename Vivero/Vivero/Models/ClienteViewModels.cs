using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vivero.Models
{
    public class ClienteViewModels
    {
        #region atributos

        [Required][Display(Name ="Nombre")]
        private string nombre;
        #endregion
    }
}