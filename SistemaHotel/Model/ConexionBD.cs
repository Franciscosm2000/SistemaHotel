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
    class ConexionBD
    {
        //NO USAR INTEGRATED SECURITY
        public static String DATABASE_URL = "Data Source=USER19-UXPC\\SQLEXPRESS; Initial Catalog=Hotel; user=sa; password=SysAdmin547";
    }
}
