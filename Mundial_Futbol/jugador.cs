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
    class jugador
    {
        /// <summary>
        /// Atributos de Jugador
        /// </summary>
        private string nombre { get; set; }
        private string direccion { get; set; }
        private string puesto { get; set; }
        private string fechaNacimiento { get; set; }
        private string equipo { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public jugador()
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="direccion"></param>
        /// <param name="puesto"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="equipo"></param>
        public jugador(string nombre, string direccion, string puesto, string fechaNacimiento, string equipo)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.puesto = puesto;
            this.fechaNacimiento = fechaNacimiento;
            this.equipo = equipo;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="deportista"></param>
        public jugador(jugador deportista)
        {
            this.nombre = deportista.nombre;
            this.direccion = deportista.direccion;
            this.puesto = deportista.puesto;
            this.fechaNacimiento = deportista.fechaNacimiento;
            this.equipo = deportista.equipo;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~jugador()
        {

        }
    }
}
