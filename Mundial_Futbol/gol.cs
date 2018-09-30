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
        private int minuto;
        private string jugadorGol;
        private string equipoLocalGol;
        private string equipoVisitanteGol;
        private DateTime fechaGol;
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
        public gol(int minuto, string jugadorGol, string equipoLocalGol, string equipoVisitanteGol, DateTime fechaGol)
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

        
        public int Minuto {
            get { return minuto; }
            set
            {
                if (value > 0)
                    minuto = value;
            }
        }        

        public string JugadorGol
        {
            get { return JugadorGol; }
            set
            {
                if (value.Length < 0 & value.Length <= 60)
                    jugadorGol = value;
            }
        }

        public string EquipoLocalGol
        {
            get { return equipoLocalGol; }
            set
            {
                if (value.Length < 0 & value.Length <= 50)
                    equipoLocalGol = value;
            }
        }

        public string EquipoVisitanteGol
        {
            get { return equipoVisitanteGol; }
            set
            {
                if (value.Length < 0 & value.Length <= 50)
                    equipoVisitanteGol = value;
            }
        }

        public DateTime FechaGol
        {
            get { return fechaGol; }
            set
            {
                fechaGol = value;
            }
        }

        /// <summary>
        /// Método ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Minuto + "#" + JugadorGol + "#" + EquipoLocalGol + "#" + EquipoVisitanteGol + "#" + FechaGol;
        }
    }
}
