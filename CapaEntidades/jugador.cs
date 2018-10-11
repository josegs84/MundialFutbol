using System;

namespace CapaEntidades
{
    /// <author>
    /// José González Silva
    /// </author>
    public class Jugador
    {
        /// <summary>
        /// Atributos de Jugador
        /// </summary>
        private string _nombre;
        private string _direccion;
        private string _puesto;
        private string _equipo;
        private DateTime _fechaNacimiento;
        /// <summary>
        /// Constructor
        /// </summary>
        public Jugador()
        {
            this.Nombre = "";
            this.Direccion = "";
            this.Puesto = "";
            this.Equipo = "";
            this.FechaNacimiento = new DateTime();
        }
        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="_nombre"></param>
        /// <param name="_direccion"></param>
        /// <param name="_puesto"></param>
        /// <param name="_fechaNacimiento"></param>
        /// <param name="_equipo"></param>
        public Jugador(string _nombre, string _equipo, string _direccion, string _puesto, DateTime _fechaNacimiento)
        {
            this.Nombre = _nombre;
            this.Direccion = _direccion;
            this.Puesto = _puesto;
            this.FechaNacimiento = _fechaNacimiento;
            this.Equipo = _equipo;
        }
        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="deportista"></param>
        public Jugador(Jugador deportista)
        {
            this.Nombre = deportista.Nombre;
            this.Direccion = deportista.Direccion;
            this.Puesto = deportista.Puesto;
            this.FechaNacimiento = deportista.FechaNacimiento;
            this.Equipo = deportista.Equipo;
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~Jugador()
        {
            this.Nombre = "";
            this.Direccion = "";
            this.Puesto = "";
            this.Equipo = "";
        }

        public string Nombre
        {
            get { return _nombre; }
            set {
                if(value.Length > 0 & value.Length <= 60)
                    _nombre = value;
            }
        }

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                if (value.Length <= 150)
                    _direccion = value;
            }
        }

        public string Puesto
        {
            get { return _puesto; }
            set
            {
                if (value.Length <= 2)
                    _puesto = value;
            }
        }

        public string Equipo
        {
            get { return _equipo; }
            set
            {
                if (value.Length > 0 & value.Length <= 50)
                    _equipo = value;
            }
        }

        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return Nombre + "#" + Direccion + "#" + Puesto + "#" + Equipo + "#" + FechaNacimiento;
        }
    }
}
