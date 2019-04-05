using SistemaHotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Control
{
    class Clogin
    {
        public static String log_in(String usrname, String pswd)
        {
            return new Mlogin().log_in(usrname, pswd);
        }
    }
}
