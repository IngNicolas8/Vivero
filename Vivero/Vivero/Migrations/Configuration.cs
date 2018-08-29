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

            #region Córdoba

            var cba = context.provinciaViewModels.FirstOrDefault(x => x.provincia == "Cordoba");

            localidades.Add(new LocalidadViewModels { localidad = "Achiras", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Adelia María", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Alcira Gigena", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Alejandro Roca", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Alejo Ledesma", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Alicia", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Almafuerte", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Alta Gracia", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Alto Resbaloso-El Barrial", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Arias", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Arroyito", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Arroyo Cabral", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Ballesteros", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Balnearia", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Berrotarán", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Bialet Massé", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Brinkmann" });
            localidades.Add(new LocalidadViewModels { localidad = "Calchín", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Camilo Aldao", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Canals", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Capilla del Monte", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Casa Grande", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia Caroya", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia La Argentina", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Coronel Moldes", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Corral de Bustos", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Cosquín", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Country Chacras de la Villa-Country San Isidro", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Cruz Alta", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Cuesta Blanca", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Deán Funes", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Del Campillo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Despeñaderos", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Devoto", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "El Pueblito", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "El Valle", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Elena", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Embalse", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Estación Juárez Celman", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Estancia Vieja", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Etruria", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Freyre", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Baldissera", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Cabrera", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Deheza", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Levalle", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Roca", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Guatimozín", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Hernando", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Huerta Grande", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Huinca Renancó", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Inriville", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Isla Verde", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "James Craik", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Jesús María", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "José de la Quintana", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Jovita", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Justiniano Posse", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Carlota", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Cumbre", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Cumbrecita", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Falda", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Francia", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Para", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Paz", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Perla", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Población", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Rancherita", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Serranita", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Laborde", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Laboulaye", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Laguna Larga", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Las Acequias", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Las Chacras", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Las Chacras", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Las Higueras", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Las Perdices", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Las Tapias", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Leones", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Cerrillos", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Cocos", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Cóndores", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Romeros", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Surgentes", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Luque", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Malagueño", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Malvinas Argentinas", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Marcos Juárez", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Mayu Sumaj", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Mi Granja", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Mina Clavero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Molinari", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Monte Buey", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Monte Cristo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Monte Maíz", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Morrison", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Morteros", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Noetinger", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Oliva", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Oncativo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Ordóñez", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Pascanas", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Paso del Durazno", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Pilar", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Playosa", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Porteña", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Pozo del Molle", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Quilino", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Río Primero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Río Segundo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Ciudad de Río Tercero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Rumi Huasi", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Sacanta", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Sampacho", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Agustín", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Antonio de Arredondo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Basilio", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Esteban", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Francisco", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Francisco del Chañar", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San José de la Dormida", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Marcos Sud", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Pedro", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Roque", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Catalina", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Elena", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa María de Punilla", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Mónica", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa de Calamuchita", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa de Río Primero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santiago Temple", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Saturnino María Laspiur", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Sebastián Elcano", ProvinciaId = cba });
            #endregion

            context.localidadViewModels.AddRange(localidades);

            #region Tipo documento


            #endregion
        }
    }
}
