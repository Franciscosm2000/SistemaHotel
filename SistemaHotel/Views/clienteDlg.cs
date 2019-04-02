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
            try
            {
                cliente.AgregarCliente(txbPnombre.Text, txbSnombre.Text, txbPapellido.Text, txbSapellido.Text,
                txbTel.Text, txbDireccion.Text, txbCorreo.Text);
            }
            catch (Exception ex)
            {
                msgerror(ex.Message);
            }    
            MessageBox.Show("Agregado Correctamente...");
            refresh();
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
                msgerror(ex.Message);
            }
        }

        private void mainGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mainGV.DataSource = CCliente.show();
        }
        private void msgerror(String msg)
        {
            MessageBox.Show(this, msg, "Sistema de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
