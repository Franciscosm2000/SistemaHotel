using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel.Control;

namespace SistemaHotel.Views
{
    public partial class clienteDlg : Form
    {
        public clienteDlg()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            CCliente cliente = new CCliente();
            cliente.AgregarCliente(txbPnombre.Text, txbSnombre.Text, txbPapellido.Text, txbSapellido.Text,
               txbTel.Text, txbDireccion.Text, txbCorreo.Text);
            MessageBox.Show("Agregado Correctamente...");

        }

        private void clienteDlg_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            try
            {
                mainGV.DataSource = CCliente.show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
