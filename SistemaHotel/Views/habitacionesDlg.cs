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
    public partial class habitacionesDlg : Form
    {
        public habitacionesDlg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MsgError(String msg)
        {
            MessageBox.Show(this, msg, "Sistema de Información",  MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void perfechasBtn_Click(object sender, EventArgs e)
        {
            if (f_inDTP.Value > f_outDTP.Value || f_inDTP.Value<DateTime.Now || f_outDTP.Value<DateTime.Now)
            {
                MsgError("Las fechas no se han insertado correctamente");
                return;
            }
            try
            {
                mainGridV.DataSource = CHabs.habs_en_fechas(f_inDTP.Value, f_outDTP.Value);
            }
            catch(Exception ex)
            {
                MsgError(ex.Message);
            }
        }
    }
}
