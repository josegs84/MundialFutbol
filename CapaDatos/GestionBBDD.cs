using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CapaDatos
{
    class GestionBBDD
    {
        private OracleConnection _conexionBBDD;
        private OracleCommand _orden;
        private OracleDataReader _lector;
        static string _cadenaConexion;
        /// <summary>
        /// Constructor
        /// </summary>
        public GestionBBDD()
        {
            _cadenaConexion = "User ID=MUNDIAL; Password=1234; " +
                            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)) " +
                            "(CONNECT_DATA = (SERVICE_NAME = xe)))";
            _conexionBBDD = null;
            _orden = null;
            _lector = null;
        }
        /// <summary>
        /// Abrir la conexión de base de datos
        /// </summary>
        public void AbrirConexion()
        {
            _conexionBBDD = new OracleConnection(_cadenaConexion);
            _conexionBBDD.Open();
        }
        /// <summary>
        /// Cerrar la conexión de base de datos (cuando ya no sea necesaria)
        /// </summary>
        public void CerrarConexion()
        {
            if (_lector != null)
            {
                _lector.Close();
                _lector.Dispose();
            }
                
            if (_conexionBBDD != null)
            {
                _conexionBBDD.Close();
            }
                
        }
        /// <summary>
        /// Ejecuta una query para mostrar datos
        /// </summary>
        /// <param name="query">Instrucción SQL</param>
        /// <returns>Devuelve un objeto con datos</returns>
        public OracleDataReader HazSelect(string query)
        {
            _orden = new OracleCommand(query, _conexionBBDD);
            _lector = _orden.ExecuteReader();
            return _lector;
        }
        /// <summary>
        /// Ejecuta una query para insertar, actualizar o eliminar datos
        /// </summary>
        /// <param name="query">Instrucción SQL</param>
        /// <returns>Devuelve el nº de filas afectadas. En el caso del Insert, devuelve el id insertado</returns>
        public int HazActualizacion(string query)
        {
            int afectadas = 0;
            _orden = new OracleCommand(query, _conexionBBDD);
            afectadas = _orden.ExecuteNonQuery();
            return afectadas;
        }
    }
}
