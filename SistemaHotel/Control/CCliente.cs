using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.Model;

namespace SistemaHotel.Control
{
    class CCliente
    {
        //Metodo que envia los datos de agregar ciente hasta Mcliente
        public void AgregandoCliente(String p_n, String s_n, String p_a, String s_a, String tel, String direccion, String correo)
        {
            MCliente cliente = new MCliente(p_n, s_n, p_a, s_a, tel, direccion, correo);
            cliente.AgregarCliente(cliente);
        }
    }
}
