using SistemaHotel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.Control
{
    class CRec
    {
        public static DataTable rec_hab(int m, int y)
        { 
            return new MRec().rec_hab(m, y);
        }
        public static DataTable rec_serv(int m, int y)
        {
            return new MRec().rec_serv(m, y);
        }
        public static DataTable bonif_empl(int m, int y)
        {
            return new MRec().bonif_empl(m, y);
        }
    }
}
