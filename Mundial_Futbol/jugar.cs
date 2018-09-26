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
        private string nombreJugador { get; set; }
        private string equipoLocal { get; set; }
        private string equipoVisitante { get; set; }
        private string fechaPartido { get; set; }
        private int minJugar { get; set; }
        private string puestoJugador { get; set; }
        private int dorsal { get; set; }
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
        public jugar(string nombreJugador, string equipoLocal, string equipoVisitante, string fechaPartido, int minJugar, string puestoJugador, int dorsal)
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
    }
}
