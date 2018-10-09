using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CapaNegocio
{
    /// <author>
    /// José González Silva
    /// </author>
    class Mundial
    {
        private int _anyo;

        public Mundial()
        {
            Anyo = new DateTime().Year;
            Partidos = new List<Partido>();
            Jugadores = new List<Jugador>();
            Juegos = new List<Jugar>();
            Goles = new List<Gol>();
            Equipos = new List<Equipo>();
            BaseDeDatos();
        }

        public void BaseDeDatos()
        {
            // Partidos
            Partidos.Add(new Partido("EEUU", "España", new DateTime(2006, 06, 12), "16:30:00", "Ciudade da Luz", 0, 0, 32500));
            Partidos.Add(new Partido("Italia", "Mexico", new DateTime(1998, 06, 29), "20:30:00", "Ciudade da Luz", 0, 0, 12500));
            Partidos.Add(new Partido("España", "Francia", new DateTime(1994, 06, 1), "12:30:00", "Ciudade da Luz", 0, 0, 25000));
            Partidos.Add(new Partido("Mexico", "Italia", new DateTime(2010, 06, 26), "10:30:00", "Dombass Arena", 0, 0, 25525));
            Partidos.Add(new Partido("Alemania", "Rusia", new DateTime(1984, 06, 30), "19:30:00", "Rico Perez", 0, 0, 35000));
            Partidos.Add(new Partido("Francia", "Italia", new DateTime(1984, 06, 5), "12:30:00", "Stade aux Princes", 0, 0, 10000));
            Partidos.Add(new Partido("España", "Rusia", new DateTime(1998, 06, 7), "20:30:00", "Liberty Park", 0, 0, 25525));
            Partidos.Add(new Partido("Mexico", "España", new DateTime(1994, 06, 4), "15:30:00", "Mestalla", 0, 0, 17500));
            Partidos.Add(new Partido("Francia", "Francia", new DateTime(2018, 06, 13), "20:30:00", "Warsawa Arena", 0, 0, 10000));
            Partidos.Add(new Partido("Mexico", "Alemania", new DateTime(2018, 06, 12), "20:30:00", "Stade aux Princes", 0, 0, 25000));
            Partidos.Add(new Partido("España", "EEUU", new DateTime(1994, 06, 4), "16:30:00", "Liberty Park", 0, 0, 36500));
            Partidos.Add(new Partido("Francia", "España", new DateTime(2018, 06, 30), "19:30:00", "Ciudade da Luz", 0, 0, 10000));
            Partidos.Add(new Partido("Alemania", "Mexico", new DateTime(2002, 06, 7), "20:30:00", "Liberty Park", 0, 0, 25525));
            Partidos.Add(new Partido("EEUU", "Alemania", new DateTime(1998, 06, 1), "12:30:00", "Dombass Arena", 0, 0, 12500));
            Partidos.Add(new Partido("Mexico", "Italia", new DateTime(2018, 06, 30), "12:30:00", "Warsawa Arena", 0, 0, 17500));
            Partidos.Add(new Partido("Mexico", "Italia", new DateTime(1994, 06, 19), "20:30:00", "Mestalla", 0, 0, 40000));
            Partidos.Add(new Partido("Brasil", "Francia", new DateTime(1984, 06, 30), "10:30:00", "Wembley Stadium", 0, 0, 35000));
            Partidos.Add(new Partido("Francia", "EEUU", new DateTime(2010, 06, 12), "13:30:00", "Mestalla", 0, 0, 17500));
            Partidos.Add(new Partido("Francia", "Mexico", new DateTime(2014, 06, 4), "20:30:00", "Warsawa Arena", 0, 0, 35000));
            Partidos.Add(new Partido("Rusia", "EEUU", new DateTime(2014, 06, 8), "18:30:00", "Warsawa Arena", 0, 0, 32500));
            Partidos.Add(new Partido("España", "Rusia", new DateTime(1984, 06, 17), "10:30:00", "Rico Perez", 0, 0, 12500));
            Partidos.Add(new Partido("España", "Brasil", new DateTime(2018, 06, 28), "14:30:00", "Stade aux Princes", 0, 0, 10000));
            Partidos.Add(new Partido("Italia", "Alemania", new DateTime(2002, 06, 27), "13:30:00", "Mestalla", 0, 0, 10000));
            Partidos.Add(new Partido("Inglaterra", "España", new DateTime(2018, 06, 15), "11:30:00", "Camp Nou", 0, 0, 25000));
            Partidos.Add(new Partido("Mexico", "EEUU", new DateTime(2018, 06, 8), "10:30:00", "Wembley Stadium", 0, 0, 25000));
            Partidos.Add(new Partido("España", "EEUU", new DateTime(1994, 06, 10), "15:30:00", "Wembley Stadium", 0, 0, 25525));
            Partidos.Add(new Partido("EEUU", "Francia", new DateTime(2010, 06, 30), "11:30:00", "Wembley Stadium", 0, 0, 25000));
            Partidos.Add(new Partido("Brasil", "Mexico", new DateTime(1984, 06, 8), "10:30:00", "Stade aux Princes", 0, 0, 25525));
            Partidos.Add(new Partido("Italia", "Alemania", new DateTime(2010, 06, 22), "17:30:00", "Rico Perez", 0, 0, 36500));
            Partidos.Add(new Partido("Mexico", "Italia", new DateTime(2018, 06, 1), "17:30:00", "Ciudade da Luz", 0, 0, 40000));
            // Jugadores
            Jugadores.Add(new Jugador("Joern", "Italia", "direccion10", "DEL", new DateTime(1976, 8, 9)));
            Jugadores.Add(new Jugador("Jose", "Italia", "direccion2", "MED", new DateTime(1974, 3, 28)));
            Jugadores.Add(new Jugador("Joern", "Francia", "direccion4", "DEF", new DateTime(1978, 8, 14)));
            Jugadores.Add(new Jugador("Juanito", "España", "direccion1", "MED", new DateTime(1972, 8, 20)));
            Jugadores.Add(new Jugador("Mike", "España", "direccion1", "POR", new DateTime(1979, 8, 2)));
            Jugadores.Add(new Jugador("Jose", "España", "direccion10", "DEL", new DateTime(1970, 7, 17)));
            Jugadores.Add(new Jugador("Luca", "Brasil", "direccion4", "DEF", new DateTime(1970, 7, 18)));
            Jugadores.Add(new Jugador("Igor", "Mexico", "direccion8", "MED", new DateTime(1972, 6, 18)));
            Jugadores.Add(new Jugador("Mike", "Inglaterra", "direccion9", "DEF", new DateTime(1973, 9, 5)));
            Jugadores.Add(new Jugador("Luisao", "Brasil", "direccion2", "MED", new DateTime(1975, 7, 3)));
            Jugadores.Add(new Jugador("Luca", "Mexico", "direccion2", "MED", new DateTime(1979, 11, 17)));
            Jugadores.Add(new Jugador("George", "EEUU", "direccion7", "DEL", new DateTime(1970, 10, 10)));
            Jugadores.Add(new Jugador("Jose", "Rusia", "direccion4", "MED", new DateTime(1972, 11, 21)));
            Jugadores.Add(new Jugador("Evan", "España", "direccion7", "DEL", new DateTime(1973, 3, 20)));
            Jugadores.Add(new Jugador("Mike", "Italia", "direccion7", "MED", new DateTime(1980, 7, 3)));
            Jugadores.Add(new Jugador("Evan", "Italia", "direccion2", "DEL", new DateTime(1970, 7, 2)));
            // Juegos
            Juegos.Add(new Jugar("Luca", "Italia", "EEUU", new DateTime(1980, 11, 7), 84, "DEL", 8));
            Juegos.Add(new Jugar("Juanito", "Italia", "Francia", new DateTime(1976, 6, 16), 20, "DEF", 20));
            Juegos.Add(new Jugar("Jose", "Brasil", "Rusia", new DateTime(1973, 12, 7), 39, "DEL", 15));
            Juegos.Add(new Jugar("Evan", "EEUU", "España", new DateTime(1979, 5, 29), 86, "POR", 1));
            Juegos.Add(new Jugar("Luisao", "Francia", "Alemania", new DateTime(1976, 7, 14), 73, "POR", 9));
            Juegos.Add(new Jugar("Luca", "España", "Alemania", new DateTime(1976, 12, 21), 62, "POR", 5));
            Juegos.Add(new Jugar("Joern", "Mexico", "Alemania", new DateTime(1980, 10, 17), 25, "DEL", 3));
            Juegos.Add(new Jugar("George", "Francia", "Rusia", new DateTime(1973, 2, 2), 39, "MED", 21));
            Juegos.Add(new Jugar("Mike", "Alemania", "Alemania", new DateTime(1976, 9, 20), 27, "MED", 14));
            Juegos.Add(new Jugar("Juanito", "EEUU", "Brasil", new DateTime(1971, 9, 2), 90, "POR", 5));
            Juegos.Add(new Jugar("Igor", "Inglaterra", "Italia", new DateTime(1979, 10, 3), 65, "POR", 18));
            Juegos.Add(new Jugar("Evan", "España", "Francia", new DateTime(1979, 10, 9), 51, "MED", 12));
            Juegos.Add(new Jugar("Joern", "Alemania", "Rusia", new DateTime(1976, 5, 19), 34, "DEL", 17));
            Juegos.Add(new Jugar("Juanito", "Brasil", "Inglaterra", new DateTime(1970, 11, 23), 26, "DEL", 3));
            Juegos.Add(new Jugar("Jose", "Inglaterra", "Alemania", new DateTime(1979, 8, 16), 17, "DEF", 20));
            Juegos.Add(new Jugar("Jose", "Italia", "EEUU", new DateTime(1979, 4, 5), 36, "POR", 22));
            Juegos.Add(new Jugar("Jose", "Brasil", "Francia", new DateTime(1975, 11, 4), 64, "MED", 22));
            // Goles
            Goles.Add(new Gol(29, "Luisao", "Italia", "Inglaterra", new DateTime()));
            Goles.Add(new Gol(73, "George", "Mexico", "Italia", new DateTime()));
            Goles.Add(new Gol(89, "Mike", "Mexico", "Inglaterra", new DateTime()));
            Goles.Add(new Gol(86, "Jose", "Rusia", "Inglaterra", new DateTime()));
            Goles.Add(new Gol(74, "Juanito", "España", "España", new DateTime()));
            Goles.Add(new Gol(88, "Igor", "Brasil", "EEUU", new DateTime()));
            Goles.Add(new Gol(63, "George", "Brasil", "Brasil", new DateTime()));
            Goles.Add(new Gol(11, "Luisao", "Inglaterra", "EEUU", new DateTime()));
            Goles.Add(new Gol(42, "Evan", "España", "España", new DateTime()));
            Goles.Add(new Gol(76, "Evan", "España", "Inglaterra", new DateTime()));
            Goles.Add(new Gol(32, "Luca", "Rusia", "Mexico", new DateTime()));
            Goles.Add(new Gol(41, "Luisao", "EEUU", "Brasil", new DateTime()));
            Goles.Add(new Gol(86, "Mike", "Rusia", "Francia", new DateTime()));
            Goles.Add(new Gol(86, "Joern", "España", "Rusia", new DateTime()));
            Goles.Add(new Gol(3, "Igor", "Rusia", "Mexico", new DateTime()));
            Goles.Add(new Gol(20, "Igor", "Alemania", "España", new DateTime()));
            // Equipos
            Equipos.Add(new Equipo("pais6", "Alemania", "Pepe Higuita"));
            Equipos.Add(new Equipo("pais6", "EEUU", "Oleg Schevchenko"));
            Equipos.Add(new Equipo("pais7", "Brasil", "Thomas Tuchel"));
            Equipos.Add(new Equipo("pais8", "Brasil", "Thomas Tuchel"));
            Equipos.Add(new Equipo("pais3", "Italia", "Pepe Higuita"));
            Equipos.Add(new Equipo("pais8", "Italia", "Mike Oldfield"));
            Equipos.Add(new Equipo("pais6", "España", "Oleg Schevchenko"));
            Equipos.Add(new Equipo("pais7", "Brasil", "Oleg Schevchenko"));
            Equipos.Add(new Equipo("pais8", "EEUU", "Roberto Baggio"));
            Equipos.Add(new Equipo("pais3", "EEUU", "Arsene Wenger"));
            Equipos.Add(new Equipo("pais4", "Mexico", "Franz Beckenbauer"));
            Equipos.Add(new Equipo("pais2", "EEUU", "Thomas Tuchel"));
            Equipos.Add(new Equipo("pais1", "Brasil", "Roberto Baggio"));
        }

        public List<Partido> Cargar(int anyo)
        {
            List<Partido> PartidosAnyo = new List<Partido>();

            foreach (Partido _partido in Partidos)
            {
                if (_partido.Fecha.Year == anyo)
                    PartidosAnyo.Add(_partido);

            }

            return PartidosAnyo;
           
        }

        public List<Jugador> BuscarJugador(string nombre)
        {
            List<Jugador> ListaJugadores = new List<Jugador>();

            foreach (Jugador _jugador in Jugadores)
            {
                if (_jugador.Nombre == nombre)
                    ListaJugadores.Add(_jugador);
            }

            return ListaJugadores;
        }
        
        public List<Partido> Buscar(DateTime dia)
        {
            List<Partido> PartidosDia = new List<Partido>();

            foreach(Partido _partido in Partidos)
            {
                if(_partido.Fecha == dia)
                    PartidosDia.Add(_partido);
            }

            return PartidosDia;
        }

        public List<Partido> Listar()
        {
            List<Partido> TodosPartidos = new List<Partido>();

            foreach(Partido _partido in Partidos)
            {
                if (_partido.Fecha.Year == Anyo)
                    TodosPartidos.Add(_partido);
            }

            return TodosPartidos;
        }

        public List<Partido> Partidos { get; set; }
        public List<Equipo> Equipos { get; set; }
        public List<Gol> Goles { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public List<Jugar> Juegos { get; set; }

        public int Anyo {
            get { return _anyo; }
            set { _anyo = value; }
        }
    }
}
