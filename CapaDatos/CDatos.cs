using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace AccesoDatos
{
    public abstract class CDatos
    {
        protected string _servidor = "";
        protected string _base = "";
        protected string _usuario = "";
        protected string _password = "";
        protected string _cadenaConexion = "";
        protected OracleConnection _conexion;

        public string Servidor
        {
            get { return _servidor; }
            set { _servidor = value; }
        }
        public string Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public abstract string CadenaConexion { get; set; }

        #region "Protegidas"
        /// <summary>
        /// Crea el objeto de conexión
        /// </summary>
        protected OracleConnection Conexion
        {
            get
            {
                if(_conexion == null)
                    _conexion = CrearConexion(CadenaConexion);

                if (_conexion.State != ConnectionState.Open)
                    _conexion.Open();

                return _conexion;
            }
        }
        #endregion
        
        #region "Acciones"
        protected abstract OracleConnection CrearConexion(string cadena);
        protected abstract OracleCommand QuerySQL(string query);
        protected abstract OracleDataAdapter NuevoDataAdapter(string query);
        /// <summary>
        /// Cierre de la conexión
        /// </summary>
        public void CerrarConexion()
        {
            if (Conexion != null)
                if (Conexion.State != ConnectionState.Closed)
                    Conexion.Close();
        }

        #endregion


    }
}
