using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Model;

namespace SistemaHotel.Control
{
    class CCliente
    {
        //Metodo que envia los datos de agregar ciente hasta Mcliente
        public void AgregarCliente(String p_n, String s_n, String p_a, String s_a, String tel, String direccion, String correo)
        {
            //BAD PROCEDURE
        }
        public DataTable show()
        {
            MCliente cliente = new MCliente();
            return cliente.show();
        }
    }
}
