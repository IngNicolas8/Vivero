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

            var provincias = new List<ProvinciaViewModels>{
                new ProvinciaViewModels { provincia = "Buenos Aires" },
                new ProvinciaViewModels { provincia = "Catamarca" },
                new ProvinciaViewModels { provincia = "Chaco" },
                new ProvinciaViewModels { provincia = "Chubut" },
                new ProvinciaViewModels { provincia = "Córdoba" },
                new ProvinciaViewModels { provincia = "Corrientes" },
                new ProvinciaViewModels { provincia = "Entre Ríos" },
                new ProvinciaViewModels { provincia = "Formosa" },
                new ProvinciaViewModels { provincia = "Jujuy" },
                new ProvinciaViewModels { provincia = "La Pampa" },
                new ProvinciaViewModels { provincia = "La Rioja" },
                new ProvinciaViewModels { provincia = "Mendoza" },
                new ProvinciaViewModels { provincia = "Misiones" },
                new ProvinciaViewModels { provincia = "Neuquén" },
                new ProvinciaViewModels { provincia = "Río Negro" },
                new ProvinciaViewModels { provincia = "Salta" },
                new ProvinciaViewModels { provincia = "San Juan" },
                new ProvinciaViewModels { provincia = "Santa Cruz" },
                new ProvinciaViewModels { provincia = "Santa Fe" },
                new ProvinciaViewModels { provincia = "Santiago del Estero" },
                new ProvinciaViewModels { provincia = "Tierra del Fuego" },
                new ProvinciaViewModels { provincia = "Tucumán" },
            };

            provincias.ForEach(p => context.provinciaViewModels.AddOrUpdate(p1 => p1.provincia, p));
            context.SaveChanges();
            
            //creo las localidades y les asigno la ProvinciaId

            ProvinciaViewModels bsAs = context.provinciaViewModels.Where(p => p.provincia == "Buenos Aires").SingleOrDefault();
            ProvinciaViewModels catamarca = context.provinciaViewModels.Where(p => p.provincia == "Catamarca").SingleOrDefault();
            ProvinciaViewModels chaco = context.provinciaViewModels.Where(p => p.provincia == "Chaco").SingleOrDefault();
            ProvinciaViewModels chubut = context.provinciaViewModels.Where(p => p.provincia == "Chubut").SingleOrDefault();
            ProvinciaViewModels cba = context.provinciaViewModels.Where(p => p.provincia == "Córdoba").SingleOrDefault();
            ProvinciaViewModels corrientes = context.provinciaViewModels.Where(p => p.provincia == "Corrientes").SingleOrDefault();
            ProvinciaViewModels entreRios = context.provinciaViewModels.Where(p => p.provincia == "Entre Ríos").SingleOrDefault();
            ProvinciaViewModels formosa = context.provinciaViewModels.Where(p => p.provincia == "Formosa").SingleOrDefault();
            ProvinciaViewModels jujuy = context.provinciaViewModels.Where(p => p.provincia == "Jujuy").SingleOrDefault();
            ProvinciaViewModels laPampa = context.provinciaViewModels.Where(p => p.provincia == "La Pampa").SingleOrDefault();
            ProvinciaViewModels laRioja = context.provinciaViewModels.Where(p => p.provincia == "La Rioja").SingleOrDefault();
            ProvinciaViewModels mendoza = context.provinciaViewModels.Where(p => p.provincia == "Mendoza").SingleOrDefault();
            ProvinciaViewModels misiones = context.provinciaViewModels.Where(p => p.provincia == "Misiones").SingleOrDefault();
            ProvinciaViewModels neuquen = context.provinciaViewModels.Where(p => p.provincia == "Neuquén").SingleOrDefault();
            ProvinciaViewModels rioNegro = context.provinciaViewModels.Where(p => p.provincia == "Río Negro").SingleOrDefault();
            ProvinciaViewModels salta = context.provinciaViewModels.Where(p => p.provincia == "Salta").SingleOrDefault();
            ProvinciaViewModels sanJuan = context.provinciaViewModels.Where(p => p.provincia == "San Juan").SingleOrDefault();
            ProvinciaViewModels santaCruz = context.provinciaViewModels.Where(p => p.provincia == "Santa Cruz").SingleOrDefault();
            ProvinciaViewModels santaFe = context.provinciaViewModels.Where(p => p.provincia == "Santa Fe").SingleOrDefault();
            ProvinciaViewModels santiagoDelEstero = context.provinciaViewModels.Where(p => p.provincia == "Santiago del Estero").SingleOrDefault();
            ProvinciaViewModels tucuman = context.provinciaViewModels.Where(p => p.provincia == "Tucumán").SingleOrDefault();

            var localidades = new List<LocalidadViewModels>{
                new LocalidadViewModels { localidad = "Alejandro Petión", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Alto Los Cardales", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Arribeños", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Ascensión", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Cacharí", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Campos Salles", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Casbas", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Chascomús Country Club", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Chillar", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Claromecó", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Comandante Nicanor Otamendi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Country Club Bosque Real-Barrio Morabo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Country Los Médanos", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Darregueira", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Eduardo O'Brien", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "El Remanso (barrio parque)", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Empalme Lobos", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Estación Camet", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Ferré", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "General Mansilla", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "General Rojo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Gobernador Castro", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Henderson", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Hilario Ascasubi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Hinojo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Huanguelén", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Jeppener", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Bautista Alberdi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Cousté", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan José Paso", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Nepomuceno Fernández", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "La Dulce", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Leandro N. Alem", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Lima", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Loma Negra", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Los Cardales", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Luján", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Mayor Buratovich", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Moquehuá", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Nicolás Levalle", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Norberto de la Riestra", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Orense", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Palemón Huergo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Parada Robles", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Paraje Vallimanca", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Quequén", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Rawson", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Roberts", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Saavedra", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "San José", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Santa Lucía", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Sierra Chica", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Sierra de la Ventana", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Sierras Bayas", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Treinta de Agosto", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Tres Algarrobos", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Urdampilleta", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Villa Arcadia", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Villa Cacique", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Villa Campi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Villa Canto", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Villa Ramallo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Villalonga", ProvinciaId = bsAs },

            //Catamarca

                new LocalidadViewModels { localidad = "Andalgalá", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Belén", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Casa de Piedra", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Chumbicha", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Fiambalá", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Huillapima", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Icaño", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "La Puntilla", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "La Ramadita", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Lavalle", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Londres", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Los Altos", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Palo Seco", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Pampa Blanca", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San José", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San José Norte", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San José Villa", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San Pedro de Guasayán", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Santa María", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Saujil", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Tinogasta", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Villa de Pomán", ProvinciaId = catamarca },

            //chaco

                new LocalidadViewModels { localidad = "Avia Terai", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Campo Largo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Charata", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Colonia Benítez", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Colonia Elisa", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Colonias Unidas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Comandancia Frías", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Concepción del Bermejo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Coronel Du Graty", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Corzuela", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "El Paranacito", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "El Sauzalito", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Fortín Belgrano", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Gancedo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "General José de San Martín", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "General Pinedo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Hermoso Campo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Horquilla", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Juan José Castelli", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Clotilde", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Escondida", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Leonesa", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Tigra", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Verde", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Las Breñas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Las Garcitas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Las Palmas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Los Frentones", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Machagai", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Makallé", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Margarita Belén", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Miraflores", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Misión Nueva Pompeya", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Napenay", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Pampa del Indio", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Pampa del Infierno", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Presidencia de la Plaza", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Presidencia Roca", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Puerto Bermejo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Puerto Tirol", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Quitilipi", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "San Bernardo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Paraje San Fernando", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Santa Sylvina", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Taco Pozo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Tres Isletas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Villa Ángela", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Villa Berthet", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Villa Río Bermejito", ProvinciaId = chaco },

            //chubut

                new LocalidadViewModels { localidad = "Dolavon", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "El Maitén", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Gobernador Costa", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Lago Puelo", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Playa Unión", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Río Mayo", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Trevelin", ProvinciaId = chubut },

            //cba

                new LocalidadViewModels { localidad = "Achiras", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Adelia María", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Alcira Gigena", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Alejandro Roca", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Alejo Ledesma", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Alicia", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Almafuerte", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Alta Gracia", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Alto Resbaloso-El Barrial", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Arias", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Arroyito", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Arroyo Cabral", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Ballesteros", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Balnearia", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Berrotarán", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Bialet Massé", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Brinkmann", ProvinciaId=cba },
                new LocalidadViewModels { localidad = "Calchín", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Camilo Aldao", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Canals", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Capilla del Monte", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Casa Grande", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Colonia Caroya", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Colonia La Argentina", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Coronel Moldes", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Corral de Bustos", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Cosquín", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Country Chacras de la Villa-Country San Isidro", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Cruz Alta", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Cuesta Blanca", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Deán Funes", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Del Campillo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Despeñaderos", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Devoto", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "El Pueblito", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "El Valle", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Elena", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Embalse", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Estación Juárez Celman", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Estancia Vieja", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Etruria", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Freyre", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Baldissera", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Cabrera", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Deheza", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Levalle", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Roca", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Guatimozín", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Hernando", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Huerta Grande", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Huinca Renancó", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Inriville", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Isla Verde", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "James Craik", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Jesús María", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "José de la Quintana", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Jovita", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Justiniano Posse", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Carlota", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Cumbre", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Cumbrecita", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Falda", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Francia", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Para", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Paz", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Perla", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Población", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Rancherita", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Serranita", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Laborde", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Laboulaye", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Laguna Larga", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Las Acequias", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Las Chacras", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Las Chacras", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Las Higueras", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Las Perdices", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Las Tapias", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Leones", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Cerrillos", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Cocos", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Cóndores", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Romeros", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Surgentes", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Luque", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Malagueño", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Malvinas Argentinas", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Marcos Juárez", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Mayu Sumaj", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Mi Granja", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Mina Clavero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Molinari", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Monte Buey", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Monte Cristo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Monte Maíz", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Morrison", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Morteros", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Noetinger", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Oliva", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Oncativo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Ordóñez", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Pascanas", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Paso del Durazno", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Pilar", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Playosa", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Porteña", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Pozo del Molle", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Quilino", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Río Primero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Río Segundo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Ciudad de Río Tercero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Rumi Huasi", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Sacanta", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Sampacho", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Agustín", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Antonio de Arredondo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Basilio", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Esteban", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Francisco", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Francisco del Chañar", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San José de la Dormida", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Marcos Sud", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Pedro", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Roque", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Catalina", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Elena", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa María de Punilla", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Mónica", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Rosa de Calamuchita", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Rosa de Río Primero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santiago Temple", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Saturnino María Laspiur", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Sebastián Elcano", ProvinciaId = cba }
            };

            //context.localidadViewModels.AddOrUpdate(l => l.localidad, localidades.ToArray());
            foreach (LocalidadViewModels localidad in localidades)
            {
                var localidadEnLaBaseDeDatos = context.localidadViewModels.Where(
                    l =>
                         l.localidad == localidad.localidad &&
                         l.ProvinciaId.provincia == localidad.ProvinciaId.provincia);
                if (localidadEnLaBaseDeDatos == null)
                {
                    context.localidadViewModels.Add(localidad);
                }
            }

            context.SaveChanges();

            #region Tipo documento

            IList<TipoDeDocumentoViewModels> tiposDeDocumento = new List<TipoDeDocumentoViewModels>();

            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "DNI" });
            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "Passaporte" });
            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "Cedula Provincial" });
            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "Cedula Federal" });
            
            context.tipoDeDocumentoViewModels.AddOrUpdate(t => t.tipoDeDocumento, tiposDeDocumento.ToArray());

            #endregion

            //context.SaveChanges();
        }
    }
}
