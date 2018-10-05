using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Mundial_Futbol
{
    class Mundial
    {
        public Mundial()
        {
            //Partidos = "";
            Anyo = new DateTime().Year;
        }

        public void Cargar(int anyo)
        {
            
           
        }

        /*public Jugador BuscarJugador(string nombre)
        {

            return Jugador;
        } */

        public List<Partido> Partidos { get; set; }

        public int Anyo { get; set; }
    }
}
