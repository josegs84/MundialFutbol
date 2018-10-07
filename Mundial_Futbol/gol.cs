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
    class Gol
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int _minuto;
        private string _jugadorGol;
        private string _equipoLocalGol;
        private string _equipoVisitanteGol;
        private DateTime _fechaGol;
        /// <summary>
        /// Constructor
        /// </summary>
        public Gol()
        {
            this.Minuto = 0;
            this.JugadorGol = "";
            this.EquipoLocalGol = "";
            this.EquipoVisitanteGol = "";
            this.FechaGol = new DateTime();

        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="minuto"></param>
        /// <param name="jugadorGol"></param>
        /// <param name="equipoLocalGol"></param>
        /// <param name="equipoVisitanteGol"></param>
        /// <param name="fechaGol"></param>
        public Gol(int minuto, string jugadorGol, string equipoLocalGol, string equipoVisitanteGol, DateTime fechaGol)
        {
            this.Minuto = minuto;
            this.JugadorGol = jugadorGol;
            this.EquipoLocalGol = equipoLocalGol;
            this.EquipoVisitanteGol = equipoVisitanteGol;
            this.FechaGol = fechaGol;

        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="Tanto"></param>
        public Gol(Gol Tanto)
        {
            this.Minuto = Tanto.Minuto;
            this.JugadorGol = Tanto.JugadorGol;
            this.EquipoLocalGol = Tanto.EquipoLocalGol;
            this.EquipoVisitanteGol = Tanto.EquipoVisitanteGol;
            this.FechaGol = Tanto.FechaGol;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Gol()
        {
            this.Minuto = 0;
            this.JugadorGol = "";
            this.EquipoLocalGol = "";
            this.EquipoVisitanteGol = "";
        }

        
        public int Minuto {
            get { return _minuto; }
            set
            {
                if (value > 0)
                    _minuto = value;
            }
        }        

        public string JugadorGol
        {
            get { return _jugadorGol; }
            set
            {
                if (value.Length > 0 & value.Length <= 60)
                    _jugadorGol = value;
            }
        }

        public string EquipoLocalGol
        {
            get { return _equipoLocalGol; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    _equipoLocalGol = value;
            }
        }

        public string EquipoVisitanteGol
        {
            get { return _equipoVisitanteGol; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    _equipoVisitanteGol = value;
            }
        }

        public DateTime FechaGol
        {
            get { return _fechaGol; }
            set
            {
                _fechaGol = value;
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
