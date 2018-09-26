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
    class equipo
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string nombreEquipo { get; set; }
        private string pais { get; set; }
        private string seleccionador { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public equipo()
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombreEquipo"></param>
        /// <param name="pais"></param>
        /// <param name="seleccionador"></param>
        public equipo(string nombreEquipo, string pais, string seleccionador)
        {
            this.nombreEquipo = nombreEquipo;
            this.pais = pais;
            this.seleccionador = seleccionador;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="seleccion"></param>
        public equipo(equipo seleccion)
        {
            this.nombreEquipo = seleccion.nombreEquipo;
            this.pais = seleccion.pais;
            this.seleccionador = seleccion.seleccionador;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~equipo()
        {

        }
    }
}
