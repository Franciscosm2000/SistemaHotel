using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel.Control;

namespace SistemaHotel.Views
{
    public partial class AgregarCliente : UserControl
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }
        //Agregando Cliente
        private void bttGuardar_Click(object sender, EventArgs e)
        {
            CCliente cliente = new CCliente();
            cliente.AgregandoCliente(txbPN.Text,txbSN.Text,txbPA.Text,txbSA.Text,txbTelefono.Text,txbDireccion.Text,txbCorreo.Text);
            MessageBox.Show("Agregado Correctamente ...","",MessageBoxButtons.OK);
        }
    }
}
