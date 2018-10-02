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
    class Jugar
    {
        private string _nombreJugador;
        private string _equipoLocal;
        private string _equipoVisitante;
        private DateTime _fechaPartido;
        private int? _minJugar;
        private string _puestoJugador;
        private int? _dorsal;
        /// <summary>
        /// Constructor
        /// </summary>
        public Jugar()
        {
            this.NombreJugador = "";
            this.EquipoLocal = "";
            this.EquipoVisitante = "";
            this.FechaPartido = new DateTime();
            this.MinJugar = 0;
            this.PuestoJugador = "";
            this.Dorsal = 0;
        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombreJugador"></param>
        /// <param name="equipoLocal"></param>
        /// <param name="equipoVisitante"></param>
        /// <param name="fechaPartido"></param>
        /// <param name="minJugar"></param>
        /// <param name="puestoJugador"></param>
        /// <param name="dorsal"></param>
        public Jugar(string nombreJugador, string equipoLocal, string equipoVisitante, DateTime fechaPartido, int minJugar, string puestoJugador, int dorsal)
        {
            this.NombreJugador = nombreJugador;
            this.EquipoLocal = equipoLocal;
            this.EquipoVisitante = equipoVisitante;
            this.FechaPartido = fechaPartido;
            this.MinJugar = minJugar;
            this.PuestoJugador = puestoJugador;
            this.Dorsal = dorsal;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="partido"></param>
        public Jugar(Jugar partido)
        {
            this.NombreJugador = partido.NombreJugador;
            this.EquipoLocal = partido.EquipoLocal;
            this.EquipoVisitante = partido.EquipoVisitante;
            this.FechaPartido = partido.FechaPartido;
            this.MinJugar = partido.MinJugar;
            this.PuestoJugador = partido.PuestoJugador;
            this.Dorsal = partido.Dorsal;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Jugar()
        {
            this.NombreJugador = "";
            this.EquipoLocal = "";
            this.EquipoVisitante = "";
            this.MinJugar = null;
            this.PuestoJugador = "";
            this.Dorsal = null;
        }


        public string NombreJugador
        {
            get { return _nombreJugador; }
            set {
                if (value.Length > 0 & value.Length <= 60)
                    _nombreJugador = value;
            }
        }


        public string EquipoLocal
        {
            get { return _equipoLocal; }
            set {
                if (value.Length > 0 & value.Length <= 50)
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

        public DateTime FechaPartido
        {
            get { return _fechaPartido; }
            set { _fechaPartido = value; }
        }

        public int? MinJugar
        {
            get { return _minJugar; }
            set
            {
                if (value > 0)
                    _minJugar = value;
            }
        }

        public string PuestoJugador
        {
            get { return _puestoJugador; }
            set
            {
                if (value.Length <= 2)
                    _puestoJugador = value;
            }
        }
        public int? Dorsal
        {
            get { return _dorsal; }
            set
            {
                if (value > 0)
                    _dorsal = value;
            }
        }

        public override string ToString()
        {
            return NombreJugador + "#" + EquipoLocal + "#" + EquipoVisitante + "#" + FechaPartido + "#" + MinJugar + "#" + PuestoJugador + "#" + Dorsal;
        }
    }
}
