using SistemaHotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Control
{
    class CHabs
    {
        public static DataTable habs_en_fechas(DateTime f_in, DateTime f_out)
        {
            if (f_in >= f_out || f_in<DateTime.Today || f_out<DateTime.Today || f_in==null || f_out==null )
            {
                throw new Exception("Error de fechas");
            }
            return new MHabs().habs_en_fechas(f_in, f_out);
        }
    }
}
