using System;
using System.Collections.Generic;
using CapaEntidades;
using CapaDatos;

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

        public int AnadirEquipo(Equipo E)
        {

            return CapaDatos.EquipoADO
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
