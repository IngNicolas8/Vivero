using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vivero.Models;
using System.Data.Entity;

namespace Vivero.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Registrar()
        {
            #region variables

            ClienteViewModels cliente = new ClienteViewModels();
            ApplicationDbContext contexto = new ApplicationDbContext();

            #endregion

            #region Provincias

            var provincias = contexto.provinciaViewModels.ToList();
            List<SelectListItem> listaDeProvincias = new List<SelectListItem>();
            listaDeProvincias.Add(new SelectListItem
            {
                Text = "--Seleccionar--",
                Value = "0",
                Selected = true
            });
            foreach (ProvinciaViewModels provincia in provincias)
            {
                listaDeProvincias.Add(new SelectListItem
                {
                    Text = provincia.provincia,
                    Value = provincia.ProvinciaId.ToString()
                });
            }
            ViewBag.Provincias = listaDeProvincias;

            #endregion

            #region Tipo de documento

            var tiposDeDocumento = contexto.tipoDeDocumentoViewModels.ToList();
            List<SelectListItem> listaDeTiposDeDocumento = new List<SelectListItem>();
            listaDeTiposDeDocumento.Add(new SelectListItem
            {
                Text = "--Seleccionar--",
                Value = "0",
                Selected = true
            });
            foreach (TipoDeDocumentoViewModels tipoDocumento in tiposDeDocumento)
            {
                listaDeTiposDeDocumento.Add(new SelectListItem
                {
                    Text = tipoDocumento.tipoDeDocumento,
                    Value = tipoDocumento.TipoDeDocumentoId.ToString()
                });
            }
            ViewBag.tiposDeDocumento = listaDeTiposDeDocumento;

            #endregion

            return View();
        }

        /// <summary>
        /// Devuelve las localidades que son de una provincia
        /// </summary>
        /// <param name="provincia">id de la provincia</param>
        /// <returns>lista de localidades</returns>
        [HttpPost]
        public JsonResult ObtenerLocalidades(int id)
        {
            ApplicationDbContext contexto = new ApplicationDbContext();
            var localidades = contexto.localidadViewModels.Where(l => l.ProvinciaId.ProvinciaId == id);
            var selectLists = new SelectList(localidades, "localidadId", "localidad");
            return Json(selectLists);
        }
    }
}