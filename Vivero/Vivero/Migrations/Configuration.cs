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
                new ProvinciaViewModels { provincia = "C�rdoba" },
                new ProvinciaViewModels { provincia = "Corrientes" },
                new ProvinciaViewModels { provincia = "Entre R�os" },
                new ProvinciaViewModels { provincia = "Formosa" },
                new ProvinciaViewModels { provincia = "Jujuy" },
                new ProvinciaViewModels { provincia = "La Pampa" },
                new ProvinciaViewModels { provincia = "La Rioja" },
                new ProvinciaViewModels { provincia = "Mendoza" },
                new ProvinciaViewModels { provincia = "Misiones" },
                new ProvinciaViewModels { provincia = "Neuqu�n" },
                new ProvinciaViewModels { provincia = "R�o Negro" },
                new ProvinciaViewModels { provincia = "Salta" },
                new ProvinciaViewModels { provincia = "San Juan" },
                new ProvinciaViewModels { provincia = "Santa Cruz" },
                new ProvinciaViewModels { provincia = "Santa Fe" },
                new ProvinciaViewModels { provincia = "Santiago del Estero" },
                new ProvinciaViewModels { provincia = "Tierra del Fuego" },
                new ProvinciaViewModels { provincia = "Tucum�n" },
            };

            provincias.ForEach(p => context.provinciaViewModels.AddOrUpdate(p1 => p1.provincia, p));
            context.SaveChanges();
            
            //creo las localidades y les asigno la ProvinciaId

            ProvinciaViewModels bsAs = context.provinciaViewModels.Where(p => p.provincia == "Buenos Aires").SingleOrDefault();
            ProvinciaViewModels catamarca = context.provinciaViewModels.Where(p => p.provincia == "Catamarca").SingleOrDefault();
            ProvinciaViewModels chaco = context.provinciaViewModels.Where(p => p.provincia == "Chaco").SingleOrDefault();
            ProvinciaViewModels chubut = context.provinciaViewModels.Where(p => p.provincia == "Chubut").SingleOrDefault();
            ProvinciaViewModels cba = context.provinciaViewModels.Where(p => p.provincia == "C�rdoba").SingleOrDefault();
            ProvinciaViewModels corrientes = context.provinciaViewModels.Where(p => p.provincia == "Corrientes").SingleOrDefault();
            ProvinciaViewModels entreRios = context.provinciaViewModels.Where(p => p.provincia == "Entre R�os").SingleOrDefault();
            ProvinciaViewModels formosa = context.provinciaViewModels.Where(p => p.provincia == "Formosa").SingleOrDefault();
            ProvinciaViewModels jujuy = context.provinciaViewModels.Where(p => p.provincia == "Jujuy").SingleOrDefault();
            ProvinciaViewModels laPampa = context.provinciaViewModels.Where(p => p.provincia == "La Pampa").SingleOrDefault();
            ProvinciaViewModels laRioja = context.provinciaViewModels.Where(p => p.provincia == "La Rioja").SingleOrDefault();
            ProvinciaViewModels mendoza = context.provinciaViewModels.Where(p => p.provincia == "Mendoza").SingleOrDefault();
            ProvinciaViewModels misiones = context.provinciaViewModels.Where(p => p.provincia == "Misiones").SingleOrDefault();
            ProvinciaViewModels neuquen = context.provinciaViewModels.Where(p => p.provincia == "Neuqu�n").SingleOrDefault();
            ProvinciaViewModels rioNegro = context.provinciaViewModels.Where(p => p.provincia == "R�o Negro").SingleOrDefault();
            ProvinciaViewModels salta = context.provinciaViewModels.Where(p => p.provincia == "Salta").SingleOrDefault();
            ProvinciaViewModels sanJuan = context.provinciaViewModels.Where(p => p.provincia == "San Juan").SingleOrDefault();
            ProvinciaViewModels santaCruz = context.provinciaViewModels.Where(p => p.provincia == "Santa Cruz").SingleOrDefault();
            ProvinciaViewModels santaFe = context.provinciaViewModels.Where(p => p.provincia == "Santa Fe").SingleOrDefault();
            ProvinciaViewModels santiagoDelEstero = context.provinciaViewModels.Where(p => p.provincia == "Santiago del Estero").SingleOrDefault();
            ProvinciaViewModels tucuman = context.provinciaViewModels.Where(p => p.provincia == "Tucum�n").SingleOrDefault();

            var localidades = new List<LocalidadViewModels>{
                new LocalidadViewModels { localidad = "Alejandro Peti�n", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Alto Los Cardales", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Arribe�os", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Ascensi�n", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Cachar�", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Campos Salles", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Casbas", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Chascom�s Country Club", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Chillar", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Claromec�", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Comandante Nicanor Otamendi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Country Club Bosque Real-Barrio Morabo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Country Los M�danos", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Darregueira", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Eduardo O'Brien", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "El Remanso (barrio parque)", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Empalme Lobos", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Estaci�n Camet", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Ferr�", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "General Mansilla", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "General Rojo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Gobernador Castro", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Henderson", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Hilario Ascasubi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Hinojo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Huanguel�n", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Jeppener", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Bautista Alberdi", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Coust�", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Jos� Paso", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Juan Nepomuceno Fern�ndez", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "La Dulce", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Leandro N. Alem", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Lima", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Loma Negra", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Los Cardales", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Luj�n", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Mayor Buratovich", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Moquehu�", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Nicol�s Levalle", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Norberto de la Riestra", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Orense", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Palem�n Huergo", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Parada Robles", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Paraje Vallimanca", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Quequ�n", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Rawson", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Roberts", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Saavedra", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "San Jos�", ProvinciaId = bsAs },
                new LocalidadViewModels { localidad = "Santa Luc�a", ProvinciaId = bsAs },
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

                new LocalidadViewModels { localidad = "Andalgal�", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Bel�n", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Casa de Piedra", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Chumbicha", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Fiambal�", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Huillapima", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Ica�o", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "La Puntilla", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "La Ramadita", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Lavalle", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Londres", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Los Altos", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Palo Seco", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Pampa Blanca", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San Jos�", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San Jos� Norte", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San Jos� Villa", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "San Pedro de Guasay�n", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Santa Mar�a", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Saujil", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Tinogasta", ProvinciaId = catamarca },
                new LocalidadViewModels { localidad = "Villa de Pom�n", ProvinciaId = catamarca },

            //chaco

                new LocalidadViewModels { localidad = "Avia Terai", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Campo Largo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Charata", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Colonia Ben�tez", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Colonia Elisa", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Colonias Unidas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Comandancia Fr�as", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Concepci�n del Bermejo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Coronel Du Graty", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Corzuela", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "El Paranacito", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "El Sauzalito", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Fort�n Belgrano", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Gancedo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "General Jos� de San Mart�n", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "General Pinedo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Hermoso Campo", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Horquilla", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Juan Jos� Castelli", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Clotilde", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Escondida", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Leonesa", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Tigra", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "La Verde", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Las Bre�as", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Las Garcitas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Las Palmas", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Los Frentones", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Machagai", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Makall�", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Margarita Bel�n", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Miraflores", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Misi�n Nueva Pompeya", ProvinciaId = chaco },
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
                new LocalidadViewModels { localidad = "Villa �ngela", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Villa Berthet", ProvinciaId = chaco },
                new LocalidadViewModels { localidad = "Villa R�o Bermejito", ProvinciaId = chaco },

            //chubut

                new LocalidadViewModels { localidad = "Dolavon", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "El Mait�n", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Gobernador Costa", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Lago Puelo", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Playa Uni�n", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "R�o Mayo", ProvinciaId = chubut },
                new LocalidadViewModels { localidad = "Trevelin", ProvinciaId = chubut },

            //cba

                new LocalidadViewModels { localidad = "Achiras", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Adelia Mar�a", ProvinciaId = cba },
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
                new LocalidadViewModels { localidad = "Berrotar�n", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Bialet Mass�", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Brinkmann", ProvinciaId=cba },
                new LocalidadViewModels { localidad = "Calch�n", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Camilo Aldao", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Canals", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Capilla del Monte", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Casa Grande", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Colonia Caroya", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Colonia La Argentina", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Coronel Moldes", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Corral de Bustos", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Cosqu�n", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Country Chacras de la Villa-Country San Isidro", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Cruz Alta", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Cuesta Blanca", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "De�n Funes", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Del Campillo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Despe�aderos", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Devoto", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "El Pueblito", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "El Valle", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Elena", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Embalse", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Estaci�n Ju�rez Celman", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Estancia Vieja", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Etruria", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Freyre", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Baldissera", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Cabrera", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Deheza", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Levalle", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "General Roca", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Guatimoz�n", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Hernando", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Huerta Grande", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Huinca Renanc�", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Inriville", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Isla Verde", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "James Craik", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Jes�s Mar�a", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Jos� de la Quintana", ProvinciaId = cba },
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
                new LocalidadViewModels { localidad = "La Poblaci�n", ProvinciaId = cba },
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
                new LocalidadViewModels { localidad = "Los C�ndores", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Romeros", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Los Surgentes", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Luque", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Malague�o", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Malvinas Argentinas", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Marcos Ju�rez", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Mayu Sumaj", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Mi Granja", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Mina Clavero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Molinari", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Monte Buey", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Monte Cristo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Monte Ma�z", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Morrison", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Morteros", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Noetinger", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Oliva", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Oncativo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Ord��ez", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Pascanas", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Paso del Durazno", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Pilar", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "La Playosa", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Porte�a", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Pozo del Molle", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Quilino", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "R�o Primero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "R�o Segundo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Ciudad de R�o Tercero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Rumi Huasi", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Sacanta", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Sampacho", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Agust�n", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Antonio de Arredondo", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Basilio", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Esteban", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Francisco", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Francisco del Cha�ar", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Jos� de la Dormida", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Marcos Sud", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Pedro", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "San Roque", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Catalina", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Elena", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Mar�a de Punilla", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa M�nica", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Rosa de Calamuchita", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santa Rosa de R�o Primero", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Santiago Temple", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Saturnino Mar�a Laspiur", ProvinciaId = cba },
                new LocalidadViewModels { localidad = "Sebasti�n Elcano", ProvinciaId = cba }
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
