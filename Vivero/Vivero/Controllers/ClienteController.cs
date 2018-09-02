using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vivero.Models;

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
                foreach (ProvinciaViewModels provincia in provincias)
                {
                    listaDeProvincias.Add(new SelectListItem
                    {
                        Text = provincia.provincia,
                        Value = provincia.ProvinciaId.ToString()
                    });
                }
                listaDeProvincias.Add(new SelectListItem
                {
                    Text = "--Seleccionar--",
                    Value = "0",
                    Selected = true
                });
                ViewBag.Provincias = listaDeProvincias;
            }

            #endregion

            #region Tipo de documento

            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                var tiposDeDocumento = contexto.tipoDeDocumentoViewModels.ToList();
                List<SelectListItem> listaDeTiposDeDocumento = new List<SelectListItem>();
                foreach (TipoDeDocumentoViewModels tipoDeDocumento in tiposDeDocumento)
                {
                    listaDeTiposDeDocumento.Add(new SelectListItem
                    {
                        Text = tipoDeDocumento.tipoDeDocumento,
                        Value = tipoDeDocumento.tipoDeDocumentoId.ToString()
                    });
                }
                listaDeTiposDeDocumento.Add(new SelectListItem
                {
                    Text = "--Seleccionar--",
                    Value = "0",
                    Selected = true
                });
                ViewBag.TiposDeDocumento = listaDeTiposDeDocumento;
            }

            #endregion

            return View();
        }

        public JsonResult Localidades(int id)
        {
            #region lista de localidades

            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                var localidades = contexto.localidadViewModels.ToList();
                List<SelectListItem> listaDeLocalidades = new List<SelectListItem>();
                listaDeLocalidades.Add(new SelectListItem
                {
                    Text = "--Seleccionar--",
                    Value = "0",
                    Selected = true
                });
                foreach (LocalidadViewModels localidad in localidades)
                {
                    if (localidad.ProvinciaId.ProvinciaId == id)
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

            #endregion
        }
    }
}