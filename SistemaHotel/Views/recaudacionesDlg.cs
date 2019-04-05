using SistemaHotel.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Views
{
    public partial class recaudacionesDlg : Form
    {
        public recaudacionesDlg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MsgError(String msg)
        {
            MessageBox.Show(this, msg, "Sistema de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loadGrid(DataTable t)
        {
            mainGV.DataSource = t;
        }

        private void recxhabBtn_Click(object sender, EventArgs e)
        {
            if(mydtpicker.Value > DateTime.Now)
            {
                MsgError("Fecha no Válida");
                return;
            }
            int m = mydtpicker.Value.Month, y = mydtpicker.Value.Year;
            try
            {
                loadGrid(CRec.rec_hab(m, y));
            }
            catch(Exception ex)
            {
                MsgError(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mydtpicker.Value > DateTime.Now)
            {
                MsgError("Fecha no Válida");
                return;
            }
            int m = mydtpicker.Value.Month, y = mydtpicker.Value.Year;
            try
            {
                loadGrid(CRec.rec_serv(m, y));
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mydtpicker.Value > DateTime.Now)
            {
                MsgError("Fecha no Válida");
                return;
            }
            int m = mydtpicker.Value.Month, y = mydtpicker.Value.Year;
            try
            {
                loadGrid(CRec.bonif_empl(m, y));
            }
            catch (Exception ex)
            {
                MsgError(ex.Message);
            }
        }
    }
}
