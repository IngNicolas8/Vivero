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

            IList<LocalidadViewModels> localidades = new List<LocalidadViewModels>();

            #region BsAs

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
            localidades.Add(new LocalidadViewModels { localidad = "Moquehuá", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Nicolás Levalle", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Norberto de la Riestra", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Orense" });
            localidades.Add(new LocalidadViewModels { localidad = "Palemón Huergo" });
            localidades.Add(new LocalidadViewModels { localidad = "Parada Robles", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Paraje Vallimanca", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Quequén", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Rawson", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Roberts", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Saavedra", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "San José", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Lucía", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Sierra Chica", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Sierra de la Ventana", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Sierras Bayas", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Treinta de Agosto", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Tres Algarrobos", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Urdampilleta", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Arcadia", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Cacique", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Campi", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Canto", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Ramallo", ProvinciaId = BsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villalonga", ProvinciaId = BsAs });

            #endregion

            #region Catamarca

            var catamarca = context.provinciaViewModels.FirstOrDefault(x => x.provincia == "Catamarca");

            localidades.Add(new LocalidadViewModels { localidad = "Andalgalá", ProvinciaId=catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Belén", ProvinciaId=catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Casa de Piedra", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Chumbicha", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Fiambalá", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Huillapima", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Icaño", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "La Puntilla", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "La Ramadita", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Lavalle", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Londres", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Los Altos", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Palo Seco", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Pampa Blanca", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San José", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San José Norte", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San José Villa", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San Pedro de Guasayán", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Santa María", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Saujil", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Tinogasta", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Villa de Pomán", ProvinciaId = catamarca });
            
            #endregion

            #region Chaco

            var chaco = context.provinciaViewModels.FirstOrDefault(x => x.provincia == "Chaco");

            localidades.Add(new LocalidadViewModels { localidad = "Avia Terai", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Campo Largo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Charata", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia Benítez", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia Elisa", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Colonias Unidas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Comandancia Frías", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Concepción del Bermejo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Coronel Du Graty", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Corzuela", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "El Paranacito", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "El Sauzalito", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Fortín Belgrano", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Gancedo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "General José de San Martín", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "General Pinedo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Hermoso Campo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Horquilla", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Juan José Castelli", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Clotilde", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Escondida", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Leonesa", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Tigra", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Verde", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Las Breñas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Las Garcitas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Las Palmas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Los Frentones", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Machagai", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Makallé", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Margarita Belén", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Miraflores", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Misión Nueva Pompeya", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Napenay", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Pampa del Indio", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Pampa del Infierno", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Presidencia de la Plaza", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Presidencia Roca", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Puerto Bermejo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Puerto Tirol", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Quitilipi", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "San Bernardo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Paraje San Fernando", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Sylvina", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Taco Pozo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Tres Isletas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Ángela", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Berthet", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Río Bermejito", ProvinciaId = chaco });


            #endregion

            #region Chubut

            var chubut = context.provinciaViewModels.FirstOrDefault(x => x.provincia == "Chubut");

            localidades.Add(new LocalidadViewModels { localidad = "Dolavon", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "El Maitén", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Gobernador Costa", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Lago Puelo", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Playa Unión", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Río Mayo", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Trevelin", ProvinciaId = chubut });
            #endregion

            context.localidadViewModels.AddRange(localidades);
        }
    }
}
