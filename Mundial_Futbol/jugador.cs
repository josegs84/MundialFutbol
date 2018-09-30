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
        private string nombre;
        private string direccion;
        private string puesto;
        private string equipo;
        private DateTime fechaNacimiento;
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
        public jugador(string nombre, string direccion, string puesto, DateTime fechaNacimiento, string equipo)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.puesto = puesto;
            this.FechaNacimiento = fechaNacimiento;
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
            this.FechaNacimiento = deportista.FechaNacimiento;
            this.equipo = deportista.equipo;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~jugador()
        {

        }

        public string Nombre
        {
            get { return nombre; }
            set {
                if(value.Length > 0 & value.Length <= 60)
                    nombre = value;
            }
        }

        public string Direccion
        {
            get { return direccion; }
            set
            {
                if (value.Length <= 150)
                    direccion = value;
            }
        }

        public string Puesto
        {
            get { return puesto; }
            set
            {
                if (value.Length <= 2)
                    puesto = value;
            }
        }

        public string Equipo
        {
            get { return equipo; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    equipo = value;
            }
        }

        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return Nombre + "#" + Direccion + "#" + Puesto + "#" + Equipo + "#" + FechaNacimiento;
        }
    }
}
