using System;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace CapaDatos
{
    public class GestionADO
    {
        private GestionBBDD bbdd;

        public GestionADO()
        {
            bbdd = new GestionBBDD();
        }
        /// <summary>
        /// Inserción de datos
        /// </summary>
        /// <param name="query">Instrucción SQL</param>
        /// <returns>Devuelve el id de la línea insertada</returns>
        public int Insertar(string query)
        {
            OracleDataReader lector;
            // Abrimos la conexión
            bbdd.AbrirConexion();

            int Id = 0;

            try
            {
                lector = bbdd.HazSelect(query);
                while (lector.Read())
                {
                    Id = lector.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                Id = 0;
                Debug.WriteLine("Error en la inserción: " + ex.Message);
            }
            finally
            {
                bbdd.CerrarConexion();
            }

            return Id;
        }

        /// <summary>
        /// Consulta de datos
        /// </summary>
        /// <param name="query">Instrucción SQL</param>
        /// <returns>Devuelve un DataReader con los datos consultados</returns>
        public OracleDataReader VerDatos(string query)
        {
            // Se define un objeto de tipo DataReader
            OracleDataReader salida;
            // Abrimos la conexión
            bbdd.AbrirConexion();
            // Almacenamos los datos de la consulta en el DataReader
            salida = bbdd.HazSelect(query);
            // Antes de finalizar, cerramos la conexión
            bbdd.CerrarConexion();
            // Se devuelve el DataReader con los datos
            return salida;
        }
    }
}
