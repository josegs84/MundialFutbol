using System;

namespace CapaEntidades
{
    /// <author>
    /// José González Silva
    /// </author>
    public class Partido : IComparable
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string _equipoLocal;
        private string _equipoVisitante;
        private DateTime _fecha;
        private string _hora;
        private string _sede;
        private int? _resultadoLocal;
        private int? _resultadoVisitante;
        private int? _asistenciaEstadio;
        /// <summary>
        /// Constructor
        /// </summary>
        public Partido()
        {
            this.EquipoLocal = "";
            this.EquipoVisitante = "";
            this.Fecha = new DateTime();
            this.Hora = "";
            this.Sede = "";
            this.ResultadoLocal = 0;
            this.ResultadoVisitante = 0;
            this.AsistenciaEstadio = 0;
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
        public Partido(string equipoLocal, string equipoVisitante, DateTime fecha, string hora, string sede, int? resultadoLocal, int? resultadoVisitante, int? asistenciaEstadio)
        {
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;
            this.Fecha = fecha;
            this.Hora = hora;
            this.Sede = sede;
            this.ResultadoLocal = resultadoLocal;
            this.ResultadoVisitante = resultadoVisitante;
            this.AsistenciaEstadio = asistenciaEstadio;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="encuentro"></param>
        public Partido(Partido encuentro)
        {
            this.EquipoLocal = encuentro.EquipoLocal;
            this.EquipoVisitante = encuentro.EquipoVisitante;
            this.Fecha = encuentro.Fecha;
            this.Hora = encuentro.Hora;
            this.Sede = encuentro.Sede;
            this.ResultadoLocal = encuentro.ResultadoLocal;
            this.ResultadoVisitante = encuentro.ResultadoVisitante;
            this.AsistenciaEstadio = encuentro.AsistenciaEstadio;
        }

        public int CompareTo(object obj)
        {
            int salida;
            try
            {
                Partido par = (Partido)obj;

                if((par.FechaPartido < FechaPartido))
                {
                    salida = 1;
                } else if ((par.FechaPartido > FechaPartido))
                {
                    salida = -1;
                } else
                {
                    salida = 0;
                }
            }
            catch (Exception e)
            {
                salida = 0;
            }

            return salida;
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~Partido()
        {
            this.EquipoLocal = "";
            this.EquipoVisitante = "";
            this.Hora = "";
            this.Sede = "";
            this.ResultadoLocal = null;
            this.ResultadoVisitante = null;
            this.AsistenciaEstadio = null;
        }


        public string EquipoLocal
        {
            get { return _equipoLocal; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    _equipoLocal = value;
                else
                    _equipoLocal = value;
            }
        }
        public string EquipoVisitante
        {
            get { return _equipoVisitante; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    _equipoVisitante = value;
            }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public string Hora
        {
            get { return _hora; }
            set
            {
                if (value.Length <= 8)
                    _hora = value;
            }
        }
        public string Sede
        {
            get { return _sede; }
            set
            {
                if (value.Length <= 100)
                    _sede = value;
            }
        }

        public int? ResultadoLocal
        {
            get { return _resultadoLocal; }
            set { _resultadoLocal = value; }
        }
        public int? ResultadoVisitante
        {
            get { return _resultadoVisitante; }
            set { _resultadoVisitante = value; }
        }
        public int? AsistenciaEstadio
        {
            get { return _asistenciaEstadio; }
            set { _asistenciaEstadio = value; }
        }

        public DateTime FechaPartido
        {
            get { return new DateTime(Fecha.Year, Fecha.Month, Fecha.Day, int.Parse(Hora.Substring(0,2)), int.Parse(Hora.Substring(3,2)), 0);  }
        }

        public override string ToString()
        {
            return EquipoLocal + "#" + EquipoVisitante + "#" + Fecha + "#" + Hora + "#" + Sede + "#" + ResultadoLocal + "#" + ResultadoVisitante + "#" + AsistenciaEstadio;
        }

    }
}
