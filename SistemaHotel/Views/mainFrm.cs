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
            dlg.ShowDialog();
            
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {
            loginDlg log = new loginDlg();
            if (log.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void disponibilidadDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habitacionesDlg dlg = new habitacionesDlg();
            dlg.ShowDialog();
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reserva dlg = new Reserva();
            dlg.ShowDialog();
        }

        private void pnlControlUsuario_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void porHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recaudacionesDlg dlg = new recaudacionesDlg();
            dlg.ShowDialog();
        }

        private void reservarHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabitacionReserva resv = new HabitacionReserva();
            resv.ShowDialog();
        }
    }
}
