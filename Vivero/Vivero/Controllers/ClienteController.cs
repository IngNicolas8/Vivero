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

            #region Provincias

            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
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
            }

            #endregion

            #region Tipo de documento

            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                var tiposDeDocumento = contexto.tipoDeDocumentoViewModels.ToList();
                //List<SelectListItem> listaDeTiposDeDocumento = new List<SelectListItem>();
                //listaDeTiposDeDocumento.Add(new SelectListItem
                //{
                //    Text = "--Seleccionar--",
                //    Value = "0",
                //    Selected = true
                //});
                //foreach (TipoDeDocumentoViewModels tipoDeDocumento in tiposDeDocumento)
                //{
                //    listaDeTiposDeDocumento.Add(new SelectListItem
                //    {
                //        Text = tipoDeDocumento.tipoDeDocumento,
                //        Value = tipoDeDocumento.TipoDeDocumentoId.ToString()
                //    });
                //}
                //ViewBag.TiposDeDocumento = listaDeTiposDeDocumento;
                SelectList listaDeTiposDeDocumentos = new SelectList(tiposDeDocumento, "tipoDeDocumento", "TipoDeDocumentoId");
                ViewBag.TiposDeDocumento = listaDeTiposDeDocumentos;
            }

            #endregion


            return View();
        }
        
        /// <summary>
        /// Metodo que devuelve las localidades pasando para una provincia
        /// </summary>
        /// <param name="id">provincia</param>
        /// <returns>json con las localidades</returns>
        [HttpPost]
        public JsonResult Localidades(ProvinciaViewModels id)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                var localidades = contexto.localidadViewModels.Include(x => x.ProvinciaId).ToList(); 
                List<SelectListItem> listaDeLocalidades = new List<SelectListItem>();
                listaDeLocalidades.Add(new SelectListItem
                {
                    Text = "--Seleccionar--",
                    Value = "0",
                    Selected = true
                });
                foreach (LocalidadViewModels localidad in localidades)
                {

                    if (localidad.ProvinciaId.ProvinciaId == id.ProvinciaId)
                    {
                        listaDeLocalidades.Add(new SelectListItem
                        {
                            Text = localidad.localidad,
                            Value = localidad.LocalidadId.ToString()
                        });
                    }
                }

                return Json(listaDeLocalidades);
            }
        }

        //POST: Cliente
        /// <summary>
        /// Registra un cliente
        /// </summary>
        /// <param name="cliente">cliente a registrar</param>
        /// <returns>una vista</returns>
        [HttpPost]
        public ActionResult Registrar(ClienteViewModels cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ApplicationDbContext contexto = new ApplicationDbContext();
                    if (ModelState.IsValid)
                    {
                        contexto.clienteViewModels.Add(cliente);
                        contexto.SaveChanges();
                    }
                }
            }
            catch
            {
                return View("Registrar");
            }

            return View();
        }
    }
}