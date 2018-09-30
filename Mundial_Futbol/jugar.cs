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
    class jugar
    {
        private string nombreJugador;
        private string equipoLocal;
        private string equipoVisitante;
        private DateTime fechaPartido;
        private int? minJugar;
        private string puestoJugador;
        private int? dorsal;
        /// <summary>
        /// Constructor
        /// </summary>
        public jugar()
        {

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
        public jugar(string nombreJugador, string equipoLocal, string equipoVisitante, DateTime fechaPartido, int minJugar, string puestoJugador, int dorsal)
        {
            this.nombreJugador = nombreJugador;
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
            this.fechaPartido = fechaPartido;
            this.minJugar = minJugar;
            this.puestoJugador = puestoJugador;
            this.dorsal = dorsal;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="partido"></param>
        public jugar(jugar partido)
        {
            this.nombreJugador = partido.nombreJugador;
            this.equipoLocal = partido.equipoLocal;
            this.equipoVisitante = partido.equipoVisitante;
            this.fechaPartido = partido.fechaPartido;
            this.minJugar = partido.minJugar;
            this.puestoJugador = partido.puestoJugador;
            this.dorsal = partido.dorsal;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~jugar()
        {

        }


        public string NombreJugador
        {
            get { return nombreJugador; }
            set {
                if (value.Length > 0 & value.Length <= 60)
                    nombreJugador = value;
            }
        }


        public string EquipoLocal
        {
            get { return equipoLocal; }
            set {
                if (value.Length > 0 & value.Length <= 50)
                    equipoLocal = value;
            }
        }

        public string EquipoVisitante
        {
            get { return equipoVisitante; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    equipoVisitante = value;
            }
        }

        public DateTime FechaPartido
        {
            get { return fechaPartido; }
            set { fechaPartido = value; }
        }

        public int? MinJugar
        {
            get { return minJugar; }
            set
            {
                if (value > 0)
                    minJugar = value;
            }
        }

        public string PuestoJugador
        {
            get { return puestoJugador; }
            set
            {
                if (value.Length <= 2)
                    puestoJugador = value;
            }
        }
        public int? Dorsal
        {
            get { return dorsal; }
            set
            {
                if (value > 0)
                    dorsal = value;
            }
        }

        public override string ToString()
        {
            return NombreJugador + "#" + EquipoLocal + "#" + EquipoVisitante + "#" + FechaPartido + "#" + MinJugar + "#" + PuestoJugador + "#" + Dorsal;
        }
    }
}
