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
    class gol
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int minuto { get; set; }
        private string jugadorGol { get; set; }
        private string equipoLocalGol { get; set; }
        private string equipoVisitanteGol { get; set; }
        private string fechaGol { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public gol()
        {

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="minuto"></param>
        /// <param name="jugadorGol"></param>
        /// <param name="equipoLocalGol"></param>
        /// <param name="equipoVisitanteGol"></param>
        /// <param name="fechaGol"></param>
        public gol(int minuto, string jugadorGol, string equipoLocalGol, string equipoVisitanteGol, string fechaGol)
        {
            this.minuto = minuto;
            this.jugadorGol = jugadorGol;
            this.equipoLocalGol = equipoLocalGol;
            this.equipoVisitanteGol = equipoVisitanteGol;
            this.fechaGol = fechaGol;

        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="Tanto"></param>
        public gol(gol Tanto)
        {
            this.minuto = Tanto.minuto;
            this.jugadorGol = Tanto.jugadorGol;
            this.equipoLocalGol = Tanto.equipoLocalGol;
            this.equipoVisitanteGol = Tanto.equipoVisitanteGol;
            this.fechaGol = Tanto.fechaGol;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~gol()
        {

        }
        /// <summary>
        /// Método ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return minuto + "#" + jugadorGol + "#" + equipoLocalGol + "#" + equipoVisitanteGol + "#" + fechaGol;
        }
    }
}
