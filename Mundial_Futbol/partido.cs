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
        private string equipoLocal;
        private string equipoVisitante;
        private DateTime fecha;
        private string hora;
        private string sede;
        private int? resultadoLocal;
        private int? resultadoVisitante;
        private int? asistenciaEstadio;
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
        public partido(string equipoLocal, string equipoVisitante, DateTime fecha, string hora, string sede, int? resultadoLocal, int? resultadoVisitante, int? asistenciaEstadio)
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


        public string EquipoLocal
        {
            get { return equipoLocal; }
            set
            {
                if (value.Length < 0 & value.Length >= 50)
                    equipoLocal = value;
            }
        }
        public string EquipoVisitante
        {
            get { return equipoVisitante; }
            set
            {
                if (value.Length < 0 & value.Length >= 50)
                    equipoVisitante = value;
            }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Hora
        {
            get { return hora; }
            set
            {
                if (value.Length >= 8)
                    hora = value;
            }
        }
        public string Sede
        {
            get { return sede; }
            set
            {
                if (value.Length >= 100)
                    sede = value;
            }
        }

        public int? ResultadoLocal
        {
            get { return resultadoLocal; }
            set { resultadoLocal = value; }
        }
        public int? ResultadoVisitante
        {
            get { return resultadoVisitante; }
            set { resultadoVisitante = value; }
        }
        public int? AsistenciaEstadio
        {
            get { return asistenciaEstadio; }
            set { asistenciaEstadio = value; }
        }

        public override string ToString()
        {
            return EquipoLocal + "#" + EquipoVisitante + "#" + Fecha + "#" + Hora + "#" + Sede + "#" + ResultadoLocal + "#" + ResultadoVisitante + "#" + AsistenciaEstadio;
        }

    }
}
