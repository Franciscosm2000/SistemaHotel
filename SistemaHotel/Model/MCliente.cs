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
    class MCliente
    {
        private String P_Nombre;
        private String S_Nombre;
        private String P_Apellido;
        private String S_Apellido;
        private String Tel;
        private String Direccion;
        private String Correo;

        //Creacion de Metodos Get y set
        public string P_Nombre1 { get => P_Nombre; set => P_Nombre = value; }
        public string S_Nombre1 { get => S_Nombre; set => S_Nombre = value; }
        public string P_Apellido1 { get => P_Apellido; set => P_Apellido = value; }
        public string S_Apellido1 { get => S_Apellido; set => S_Apellido = value; }
        public string Tel1 { get => Tel; set => Tel = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Correo1 { get => Correo; set => Correo = value; }

        //Constructor
        public MCliente(String p_n, String s_n, String p_a, String s_a, String tel, String direccion, String correo)
        {
            this.P_Nombre = p_n;
            this.S_Nombre = s_n;
            this.P_Apellido = p_a;
            this.S_Apellido = s_a;
            this.Tel = tel;
            this.Direccion = direccion;
            this.Correo = correo;
        }

        //Creacion de  Metodos 

        private ConeccionBD coneccion = new ConeccionBD();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leer;

        //Metodo de agregar Cliente 

        public void AgregarCliente( MCliente datos)
        {
            comando.Connection = coneccion.AbrirConeccion(); //abrimos coneccion
            comando.CommandText=("Insertar_Cliente"); //Especificamos el nombre procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure; // decimos que es de tipo procedimiento almacenado

            //LLENANDO PARAMETROS
            comando.Parameters.AddWithValue("@p_nom ",datos.P_Nombre1);
            comando.Parameters.AddWithValue("@s_nom ", datos.S_Nombre1);
            comando.Parameters.AddWithValue("@p_apell ", datos.P_Apellido1);
            comando.Parameters.AddWithValue("@s_apell ", datos.S_Apellido1);
            comando.Parameters.AddWithValue("@dir", datos.Direccion1);
            comando.Parameters.AddWithValue("@tel ", datos.Tel1);
            comando.Parameters.AddWithValue("@corr ", datos.Correo1);
            comando.ExecuteNonQuery(); //Ejecutamos Instrucciones
            comando.Parameters.Clear(); //Luego de haver ingresado los datos, limpiamos los parametros para evitar cualquier tipo de error.

           // comando.Connection = coneccion.CerrarConeccion();
        }

    }
}
