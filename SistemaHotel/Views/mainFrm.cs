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
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

        }

        private void disponibilidadDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habitacionesDlg dlg = new habitacionesDlg();
            dlg.Show();
        }
    }
}
