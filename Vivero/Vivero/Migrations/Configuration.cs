namespace Vivero.Migrations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vivero.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Vivero.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Vivero.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            #region provincias

            IList<ProvinciaViewModels> provincias = new List<ProvinciaViewModels>();

            provincias.Add(new ProvinciaViewModels { provincia = "Buenos Aires" });
            provincias.Add(new ProvinciaViewModels { provincia = "Catamarca" });
            provincias.Add(new ProvinciaViewModels { provincia = "Chaco" });
            provincias.Add(new ProvinciaViewModels { provincia = "Chubut" });
            provincias.Add(new ProvinciaViewModels { provincia = "Córdoba" });
            provincias.Add(new ProvinciaViewModels { provincia = "Corrientes" });
            provincias.Add(new ProvinciaViewModels { provincia = "Entre Ríos" });
            provincias.Add(new ProvinciaViewModels { provincia = "Formosa" });
            provincias.Add(new ProvinciaViewModels { provincia = "Jujuy" });
            provincias.Add(new ProvinciaViewModels { provincia = "La Pampa" });
            provincias.Add(new ProvinciaViewModels { provincia = "La Rioja" });
            provincias.Add(new ProvinciaViewModels { provincia = "Mendoza" });
            provincias.Add(new ProvinciaViewModels { provincia = "Misiones" });
            provincias.Add(new ProvinciaViewModels { provincia = "Neuquén" });
            provincias.Add(new ProvinciaViewModels { provincia = "Río Negro" });
            provincias.Add(new ProvinciaViewModels { provincia = "Salta" });
            provincias.Add(new ProvinciaViewModels { provincia = "San Juan" });
            provincias.Add(new ProvinciaViewModels { provincia = "Santa Cruz" });
            provincias.Add(new ProvinciaViewModels { provincia = "Santa Fe" });
            provincias.Add(new ProvinciaViewModels { provincia = "Santiago del Estero" });
            provincias.Add(new ProvinciaViewModels { provincia = "Tierra del Fuego" });
            provincias.Add(new ProvinciaViewModels { provincia = "Corrientes" });
            provincias.Add(new ProvinciaViewModels { provincia = "Tucumán" });
            provincias.Add(new ProvinciaViewModels { provincia = "Formosa" });
            provincias.Add(new ProvinciaViewModels { provincia = "Jujuy" });
            provincias.Add(new ProvinciaViewModels { provincia = "La Pampa" });
            provincias.Add(new ProvinciaViewModels { provincia = "La Rioja" });
            provincias.Add(new ProvinciaViewModels { provincia = "Mendoza" });
            provincias.Add(new ProvinciaViewModels { provincia = "Misiones" });
            provincias.Add(new ProvinciaViewModels { provincia = "Neuquén" });
            provincias.Add(new ProvinciaViewModels { provincia = "Río Negro" });
            provincias.Add(new ProvinciaViewModels { provincia = "Salta" });

            context.provinciaViewModels.AddRange(provincias);

            #endregion

            #region localidades

            IList<LocalidadViewModels> localidades = new List<LocalidadViewModels>();

            //Recupero la provincia

            var BsAs = context.provinciaViewModels.FirstOrDefault(x => x.provincia == "Buenos Aires");

            //creo las localidades y les asigno la provincia

            localidades.Add(new LocalidadViewModels { localidad = "Alejandro Petión", ProvinciaId=BsAs});
            localidades.Add(new LocalidadViewModels { localidad = "Alto Los Cardales", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Arribeños", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Ascensión", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Cacharí", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Campos Salles", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Casbas", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Chascomús Country Club", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Chillar", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Claromecó", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Comandante Nicanor Otamendi", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Country Club Bosque Real-Barrio Morabo", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Country Los Médanos", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Darregueira", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Eduardo O'Brien", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "El Remanso (barrio parque)", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Empalme Lobos", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Estación Camet", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Ferré", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "General Mansilla", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "General Rojo", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Gobernador Castro", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Henderson", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Hilario Ascasubi", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Hinojo", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Huanguelén", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Jeppener", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Bautista Alberdi", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Cousté", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan José Paso", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Nepomuceno Fernández", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "La Dulce", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Leandro N. Alem", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Lima", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Loma Negra", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Los Cardales", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Luján", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Mayor Buratovich", ProvinciaId = BsAs });

            context.departamentoViewModels.AddRange(departamentos);

            #endregion
        }
    }
}
