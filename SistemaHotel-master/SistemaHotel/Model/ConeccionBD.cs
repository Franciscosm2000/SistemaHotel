using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SistemaHotel.Model
{
    class ConeccionBD
    {
        //Integrated Security "Credenciales de windows"
        static private String CadenaConeccion = "Server = DESKTOP-RQ1ANIO; Database = Hotel; Integrated Security = true";

        private SqlConnection coneccion = new SqlConnection(CadenaConeccion);
        //Metodo para Abrir coneccion
        public SqlConnection AbrirConeccion()
        {
            if (coneccion.State == ConnectionState.Closed) //Condicion donde preguntamos si la coneccion esta cerrada
            {
                coneccion.Open();

            }

            return coneccion;
        }
        //Metodo para Cerrar coneccion
        public SqlConnection CerrarConeccion()
        {
            if (coneccion.State == ConnectionState.Open) //Condicion donde preguntamos si la coneccion esta Abierta Para Cerrarla
            {
                coneccion.Close();
            }

            return coneccion;
        }
    }
}
