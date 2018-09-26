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
    class partido : IComparable
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string equipoLocal { get; set; }
        private string equipoVisitante { get; set; }
        private string fecha { get; set; }
        private string hora { get; set; }
        private string sede { get; set; }
        private int resultadoLocal { get; set; }
        private int resultadoVisitante { get; set; }
        private int asistenciaEstadio { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public partido()
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="equipoLocal"></param>
        /// <param name="equipoVisitante"></param>
        /// <param name="fecha"></param>
        /// <param name="hora"></param>
        /// <param name="sede"></param>
        /// <param name="resultadoLocal"></param>
        /// <param name="resultadoVisitante"></param>
        /// <param name="asistenciaEstadio"></param>
        public partido(string equipoLocal, string equipoVisitante, string fecha, string hora, string sede, int resultadoLocal, int resultadoVisitante, int asistenciaEstadio)
        {
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
            this.fecha = fecha;
            this.hora = hora;
            this.sede = sede;
            this.resultadoLocal = resultadoLocal;
            this.resultadoVisitante = resultadoVisitante;
            this.asistenciaEstadio = asistenciaEstadio;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="encuentro"></param>
        public partido(partido encuentro)
        {
            this.equipoLocal = encuentro.equipoLocal;
            this.equipoVisitante = encuentro.equipoVisitante;
            this.fecha = encuentro.fecha;
            this.hora = encuentro.hora;
            this.sede = encuentro.sede;
            this.resultadoLocal = encuentro.resultadoLocal;
            this.resultadoVisitante = encuentro.resultadoVisitante;
            this.asistenciaEstadio = encuentro.asistenciaEstadio;
        }

        public int CompareTo(object obj)
        {
            return fecha.CompareTo(obj);
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~partido()
        {

        }
    }
}
