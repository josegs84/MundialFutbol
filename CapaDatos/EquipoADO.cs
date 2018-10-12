using System;
using CapaEntidades;
using AccesoDatos;

namespace CapaDatos
{
    public class EquipoADO
    {
        public EquipoADO()
        {

        }

        public static int Guardar(Equipo E)
        {
            int filas = 0;
            string query = "INSERT INTO EQUIPOS () VALUES('"+E.NombreEquipo+"','"+E.Pais+"','"+E.Seleccionador+"');";

            filas = Conexion
        }
    }
}
