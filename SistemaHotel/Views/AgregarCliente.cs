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
           //BAD PROCEDURE
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            CCliente cl = new CCliente();
            clienteGrid.DataSource = cl.show();
            clienteGrid.Columns["Id_Cliente"].Visible = false;
        }
    }
}
