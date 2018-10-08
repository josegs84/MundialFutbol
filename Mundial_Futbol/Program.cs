using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundial_Futbol
{
    /// <author>
    /// José González Silva
    /// </author>
    class Program
    {
        static void Main(string[] args)
        {
            Mundial mundial2010 = new Mundial();
            List<Partido> Partidos = mundial2010.Cargar(2010);
            int cnt = 0;
            // Cargar partidos
            Console.WriteLine("LISTAR PARTIDOS");
            Console.WriteLine("");

            foreach (Partido Partido in Partidos)
            {
                cnt++;
                //Console.WriteLine(Partido.ToString());
                Console.WriteLine("Partido #{0}", cnt);
                Console.WriteLine("Fecha del Partido: {0}",Partido.FechaPartido);
                Console.WriteLine("Equipo Local: {0}",Partido.EquipoLocal);
                Console.WriteLine("Equipo Visitante: {0}",Partido.EquipoVisitante);
                Console.WriteLine("Estadio: {0}",Partido.Sede);
                Console.WriteLine("Asistencia: {0}",Partido.AsistenciaEstadio);
                Console.WriteLine(" ");
            }

            Console.ReadLine();
            // Buscar jugadores
            Console.WriteLine("BUSCAR JUGADORES");
            Console.WriteLine("");

            List<Jugador> Jugadores = mundial2010.BuscarJugador("Jose");

            foreach (Jugador jugador in Jugadores)
            {
                cnt++;
                Console.WriteLine(jugador.ToString());
            }
            Console.ReadLine();
            // Buscar partidos en un día concreto
            Console.WriteLine("BUSCAR PARTIDOS EN UN DIA CONCRETO");
            Console.WriteLine("");

            List<Partido> Partidos2 = mundial2010.Buscar(new DateTime(1994, 06, 4));

            foreach (Partido partido in Partidos2)
            {
                cnt++;
                Console.WriteLine(partido.ToString());
            }
            Console.ReadLine();
        }
    }
}
