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
        private int id_cliente;
        private String p_Nombre;
        private String s_Nombre;
        private String p_Apellido;
        private String s_Apellido;
        private String tel;
        private String direccion;
        private String correo;

        

        //Creacion de Metodos Get y set


        //Constructor
        

        public MCliente() { }

        public MCliente(int id_cliente, string p_Nombre, string s_Nombre, string p_Apellido, string s_Apellido, string tel, string direccion, string correo)
        {
            this.id_cliente = id_cliente;
            this.p_Nombre = p_Nombre;
            this.s_Nombre = s_Nombre;
            this.p_Apellido = p_Apellido;
            this.s_Apellido = s_Apellido;
            this.tel = tel;
            this.direccion = direccion;
            this.correo = correo;
        }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string P_Nombre { get => p_Nombre; set => p_Nombre = value; }
        public string S_Nombre { get => s_Nombre; set => s_Nombre = value; }
        public string P_Apellido { get => p_Apellido; set => p_Apellido = value; }
        public string S_Apellido { get => s_Apellido; set => s_Apellido = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }

        //Creacion de  Metodos 

        //Metodo de agregar Cliente 

        public void AgregarCliente( MCliente datos)
        {
            //BAD PROCEDURE
        }
        public DataTable show()
        {
            DataTable res = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = ConexionBD.DATABASE_URL;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Mostrar_Clientes";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(res);

            }
            catch (Exception)
            {
                throw new Exception("Error en la conexion");
            }
            return res;
        }

    }
}
