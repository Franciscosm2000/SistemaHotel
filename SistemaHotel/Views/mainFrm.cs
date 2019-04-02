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
            clienteDlg dlg = new clienteDlg();
            dlg.Show();
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void disponibilidadDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habitacionesDlg dlg = new habitacionesDlg();
            dlg.Show();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserva dlg = new Reserva();
            dlg.Show();
        }
    }
}
