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
        private OracleConnection conexionBBDD;
        private OracleCommand orden;
        private OracleDataReader lector;
        static string cadenaConexion;
        /// <summary>
        /// Constructor
        /// </summary>
        public GestionBBDD()
        {
            cadenaConexion = "User ID=MUNDIAL; Password=1234; " +
                            "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=localhost)(PORT=1521)) " +
                            "(CONNECT_DATA = (SERVICE_NAME = xe)))";
            conexionBBDD = null;
            orden = null;
            lector = null;
        }
        /// <summary>
        /// Abrir la conexión de base de datos
        /// </summary>
        public void AbrirConexion()
        {
            conexionBBDD = new OracleConnection(cadenaConexion);
            conexionBBDD.Open();
        }
        /// <summary>
        /// Cerrar la conexión de base de datos (cuando ya no sea necesaria)
        /// </summary>
        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            if (conexionBBDD != null)
                conexionBBDD.Close();
        }
        /// <summary>
        /// Ejecuta una query para mostrar datos
        /// </summary>
        /// <param name="query">Instrucción SQL</param>
        /// <returns>Devuelve un objeto con datos</returns>
        public OracleDataReader EjecutarDML(string query)
        {
            orden = new OracleCommand(query, conexionBBDD);
            lector = orden.ExecuteReader();
            return lector;
        }
        /// <summary>
        /// Ejecuta una query para insertar, actualizar o eliminar datos
        /// </summary>
        /// <param name="query">Instrucción SQL</param>
        /// <returns>Devuelve el nº de filas afectadas</returns>
        public int EjecutarDDL(string query)
        {
            int afectadas = 0;
            orden = new OracleCommand(query, conexionBBDD);
            afectadas = orden.ExecuteNonQuery();
            return afectadas;
        }
    }
}
