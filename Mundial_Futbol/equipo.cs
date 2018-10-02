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
    class Equipo
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private string _nombreEquipo;
        private string _pais;
        private string _seleccionador;
        /// <summary>
        /// Constructor
        /// </summary>
        public Equipo()
        {
            this.NombreEquipo = "";
            this.Pais = "";
            this.Seleccionador = "";
        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombreEquipo"></param>
        /// <param name="pais"></param>
        /// <param name="seleccionador"></param>
        public Equipo(string nombreEquipo, string pais, string seleccionador)
        {
            this.NombreEquipo = nombreEquipo;
            this.Pais = pais;
            this.Seleccionador = seleccionador;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="seleccion"></param>
        public Equipo(Equipo seleccion)
        {
            this.NombreEquipo = seleccion.NombreEquipo;
            this.Pais = seleccion.Pais;
            this.Seleccionador = seleccion.Seleccionador;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Equipo()
        {
            this.NombreEquipo = "";
            this.Pais = "";
            this.Seleccionador = "";
        }


        public string NombreEquipo
        {
            get { return _nombreEquipo; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    _nombreEquipo = value;
            }
        }

        public string Pais
        {
            get { return _pais; }
            set
            {
                if (value.Length <= 30)
                    _pais = value;
            }
        }

        public string Seleccionador
        {
            get { return _seleccionador; }
            set
            {
                if (value.Length <= 50)
                    _seleccionador = value;
            }
        }

        public override string ToString()
        {
            return NombreEquipo + "#" + Pais + "#" + Seleccionador;
        }

    }
}
