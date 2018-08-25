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
            #region lista de localidades

            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                var localidades = contexto.localidadViewModels.ToList();
                List<SelectListItem> listaDeLocalidades = new List<SelectListItem>();
                foreach (LocalidadViewModels localidad in localidades)
                {
                    listaDeLocalidades.Add(new SelectListItem
                    {
                        Text = localidad.localidad,
                        Value = localidad.LocalidadId.ToString()
                    });
                }
                listaDeLocalidades.Add(new SelectListItem
                {
                    Text = "--Seleccionar--",
                    Value = "0",
                    Selected = true
                });
                ViewBag.Localidades = listaDeLocalidades;
                
            }

            #endregion

            #region Provincias

            using(ApplicationDbContext contexto = new ApplicationDbContext())
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

            return View();
        }
    }
}