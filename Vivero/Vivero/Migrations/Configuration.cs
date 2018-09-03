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
            
            IList<ProvinciaViewModels> provincias = new List<ProvinciaViewModels>();
            var bsAs = new ProvinciaViewModels { provincia = "Buenos Aires" };
            provincias.Add(bsAs);
            var catamarca = new ProvinciaViewModels { provincia = "catamarca" };
            provincias.Add(catamarca);
            var chaco = new ProvinciaViewModels { provincia = "Chaco" };
            provincias.Add(chaco);
            var chubut = new ProvinciaViewModels { provincia = "Chubut" };
            provincias.Add(chubut);
            var cba = new ProvinciaViewModels { provincia = "C�rdoba" };
            provincias.Add(cba);
            var corrientes = new ProvinciaViewModels { provincia = "Corrientes" };
            provincias.Add(corrientes);
            var entreRios = new ProvinciaViewModels { provincia = "Entre R�os" };
            provincias.Add(entreRios);
            var formosa = new ProvinciaViewModels { provincia = "Formosa" };
            provincias.Add(formosa);
            var jujuy = new ProvinciaViewModels { provincia = "Jujuy" };
            provincias.Add(jujuy);
            var laPampa = new ProvinciaViewModels { provincia = "La Pampa" };
            provincias.Add(laPampa);
            var laRioja = new ProvinciaViewModels { provincia = "La Rioja" };
            provincias.Add(laRioja);
            var mendoza = new ProvinciaViewModels { provincia = "Mendoza" };
            provincias.Add(mendoza);
            var misiones = new ProvinciaViewModels { provincia = "Misiones" };
            provincias.Add(misiones);
            var neuquen = new ProvinciaViewModels { provincia = "Neuqu�n" };
            provincias.Add(neuquen);
            var rioNegro = new ProvinciaViewModels { provincia = "R�o Negro" };
            provincias.Add(rioNegro);
            var salta = new ProvinciaViewModels { provincia = "Salta" };
            provincias.Add(salta);
            var sanJuan = new ProvinciaViewModels { provincia = "San Juan" };
            provincias.Add(sanJuan);
            var santaCruz = new ProvinciaViewModels { provincia = "Santa Cruz" };
            provincias.Add(santaCruz);
            var santaFe = new ProvinciaViewModels { provincia = "Santa Fe" };
            provincias.Add(santaFe);
            var santiagoDelEstero =new ProvinciaViewModels { provincia = "Santiago del Estero" };
            provincias.Add(santiagoDelEstero);
            var tierraDelFuego = new ProvinciaViewModels { provincia = "Tierra del Fuego" };
            provincias.Add(tierraDelFuego);
            var tucuman = new ProvinciaViewModels { provincia = "Tucum�n" };
            provincias.Add(tucuman);

            context.provinciaViewModels.AddOrUpdate(provincias.ToArray());
            
            IList<LocalidadViewModels> localidades = new List<LocalidadViewModels>();
            
            //creo las localidades y les asigno la provincia

            localidades.Add(new LocalidadViewModels { localidad = "Alejandro Peti�n", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Alto Los Cardales", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Arribe�os", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Ascensi�n", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Cachar�", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Campos Salles", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Casbas", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Chascom�s Country Club", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Chillar", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Claromec�", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Comandante Nicanor Otamendi", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Country Club Bosque Real-Barrio Morabo", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Country Los M�danos", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Darregueira", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Eduardo O'Brien", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "El Remanso (barrio parque)", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Empalme Lobos", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Estaci�n Camet", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Ferr�", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "General Mansilla", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "General Rojo", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Gobernador Castro", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Henderson", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Hilario Ascasubi", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Hinojo", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Huanguel�n", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Jeppener", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Bautista Alberdi", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Coust�", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Jos� Paso", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Nepomuceno Fern�ndez", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "La Dulce", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Leandro N. Alem", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Lima", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Loma Negra", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Los Cardales", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Luj�n", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Mayor Buratovich", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Moquehu�", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Nicol�s Levalle", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Norberto de la Riestra", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Orense", ProvinciaId=bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Palem�n Huergo", ProvinciaId=bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Parada Robles", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Paraje Vallimanca", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Quequ�n", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Rawson", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Roberts", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Saavedra", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "San Jos�", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Luc�a", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Sierra Chica", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Sierra de la Ventana", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Sierras Bayas", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Treinta de Agosto", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Tres Algarrobos", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Urdampilleta", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Arcadia", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Cacique", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Campi", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Canto", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Ramallo", ProvinciaId = bsAs });
            localidades.Add(new LocalidadViewModels { localidad = "Villalonga", ProvinciaId = bsAs });

            //Catamarca

            localidades.Add(new LocalidadViewModels { localidad = "Andalgal�", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Bel�n", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Casa de Piedra", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Chumbicha", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Fiambal�", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Huillapima", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Ica�o", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "La Puntilla", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "La Ramadita", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Lavalle", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Londres", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Los Altos", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Palo Seco", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Pampa Blanca", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San Jos�", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San Jos� Norte", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San Jos� Villa", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "San Pedro de Guasay�n", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Mar�a", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Saujil", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Tinogasta", ProvinciaId = catamarca });
            localidades.Add(new LocalidadViewModels { localidad = "Villa de Pom�n", ProvinciaId = catamarca });

            //chaco

            localidades.Add(new LocalidadViewModels { localidad = "Avia Terai", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Campo Largo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Charata", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia Ben�tez", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia Elisa", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Colonias Unidas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Comandancia Fr�as", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Concepci�n del Bermejo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Coronel Du Graty", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Corzuela", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "El Paranacito", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "El Sauzalito", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Fort�n Belgrano", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Gancedo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "General Jos� de San Mart�n", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "General Pinedo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Hermoso Campo", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Horquilla", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Juan Jos� Castelli", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Clotilde", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Escondida", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Leonesa", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Tigra", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "La Verde", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Las Bre�as", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Las Garcitas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Las Palmas", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Los Frentones", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Machagai", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Makall�", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Margarita Bel�n", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Miraflores", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Misi�n Nueva Pompeya", ProvinciaId = chaco });
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
            localidades.Add(new LocalidadViewModels { localidad = "Villa �ngela", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Villa Berthet", ProvinciaId = chaco });
            localidades.Add(new LocalidadViewModels { localidad = "Villa R�o Bermejito", ProvinciaId = chaco });

            //chubut

            localidades.Add(new LocalidadViewModels { localidad = "Dolavon", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "El Mait�n", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Gobernador Costa", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Lago Puelo", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Playa Uni�n", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "R�o Mayo", ProvinciaId = chubut });
            localidades.Add(new LocalidadViewModels { localidad = "Trevelin", ProvinciaId = chubut });

            //cba

            localidades.Add(new LocalidadViewModels { localidad = "Achiras", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Adelia Mar�a", ProvinciaId = cba });
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
            localidades.Add(new LocalidadViewModels { localidad = "Berrotar�n", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Bialet Mass�", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Brinkmann", ProvinciaId=cba });
            localidades.Add(new LocalidadViewModels { localidad = "Calch�n", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Camilo Aldao", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Canals", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Capilla del Monte", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Casa Grande", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia Caroya", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Colonia La Argentina", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Coronel Moldes", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Corral de Bustos", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Cosqu�n", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Country Chacras de la Villa-Country San Isidro", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Cruz Alta", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Cuesta Blanca", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "De�n Funes", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Del Campillo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Despe�aderos", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Devoto", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "El Pueblito", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "El Valle", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Elena", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Embalse", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Estaci�n Ju�rez Celman", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Estancia Vieja", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Etruria", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Freyre", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Baldissera", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Cabrera", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Deheza", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Levalle", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "General Roca", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Guatimoz�n", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Hernando", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Huerta Grande", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Huinca Renanc�", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Inriville", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Isla Verde", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "James Craik", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Jes�s Mar�a", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Jos� de la Quintana", ProvinciaId = cba });
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
            localidades.Add(new LocalidadViewModels { localidad = "La Poblaci�n", ProvinciaId = cba });
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
            localidades.Add(new LocalidadViewModels { localidad = "Los C�ndores", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Romeros", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Los Surgentes", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Luque", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Malague�o", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Malvinas Argentinas", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Marcos Ju�rez", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Mayu Sumaj", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Mi Granja", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Mina Clavero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Molinari", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Monte Buey", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Monte Cristo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Monte Ma�z", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Morrison", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Morteros", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Noetinger", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Oliva", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Oncativo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Ord��ez", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Pascanas", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Paso del Durazno", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Pilar", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "La Playosa", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Porte�a", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Pozo del Molle", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Quilino", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "R�o Primero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "R�o Segundo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Ciudad de R�o Tercero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Rumi Huasi", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Sacanta", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Sampacho", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Agust�n", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Antonio de Arredondo", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Basilio", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Esteban", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Francisco", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Francisco del Cha�ar", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Jos� de la Dormida", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Marcos Sud", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Pedro", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "San Roque", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Catalina", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Elena", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Mar�a de Punilla", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa M�nica", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa de Calamuchita", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santa Rosa de R�o Primero", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Santiago Temple", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Saturnino Mar�a Laspiur", ProvinciaId = cba });
            localidades.Add(new LocalidadViewModels { localidad = "Sebasti�n Elcano", ProvinciaId = cba });

            context.localidadViewModels.AddOrUpdate(localidades.ToArray());
            
            #region Tipo documento

            IList<TipoDeDocumentoViewModels> tiposDeDocumento = new List<TipoDeDocumentoViewModels>();

            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "DNI" });
            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "Passaporte" });
            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "Cedula Provincial" });
            tiposDeDocumento.Add(new TipoDeDocumentoViewModels { tipoDeDocumento = "Cedula Federal" });

            context.tipoDeDocumentoViewModels.AddOrUpdate(tiposDeDocumento.ToArray());

            #endregion
        }
    }
}
