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
        private int id; //variable donde se guardara la posicion seleccionada de la tabla
        public clienteDlg()
        {
            InitializeComponent();
            Desabilitar();
        }
        //Evento Guardar
        private void btnguardar_Click(object sender, EventArgs e)
        {
            CCliente cliente = new CCliente();
            try
            {
                cliente.AgregarCliente(txbPnombre.Text, txbSnombre.Text, txbPapellido.Text, txbSapellido.Text,
                txbTel.Text, txbDireccion.Text, txbCorreo.Text);
                clearCampos();
            }
            catch (Exception ex)
            {
                msgerror(ex.Message);
            }    
            MessageBox.Show("Agregado Correctamente...");
            refresh();
        }
        //Evento para cuando  inicie el formulario mostrar datos guardados
        private void clienteDlg_Load(object sender, EventArgs e)
        {
            refresh();
        }
        //Metodo refrescar tabla
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
        //metodo de error
        private void msgerror(String msg)
        {
            MessageBox.Show(this, msg, "Sistema de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //metodo que permite la editacion de campos
        private void btneditar_Click(object sender, EventArgs e)
        {
            Habilitar();
            this.btnAgregar.Enabled = true;
            this.gbxdatos.Enabled = true;
            btnGuardarNuevoscambios.Visible = true;
            btnguardar.Visible = false;
            mainGV.CellClick += mainGV_CellClick; //Activamos Metodo
            //Desactivamos Metodos
            txbPnombre.Click -= Pn;
            txbSnombre.Click -= Sn;
            txbPapellido.Click -= Pa;
            txbSapellido.Click -= Sa;
        }
        //metodo que captura el elemento selecciando de la tabla
        private void mainGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int poc = 0;
            poc = mainGV.CurrentRow.Index; //octenemos la posicion
            id = Convert.ToInt32(mainGV[0,poc].Value.ToString());
            txbPnombre.Text = mainGV[1, poc].Value.ToString();
            txbSnombre.Text = mainGV[2, poc].Value.ToString();
            txbPapellido.Text = mainGV[3, poc].Value.ToString();
            txbSapellido.Text = mainGV[4, poc].Value.ToString();
            txbDireccion.Text = mainGV[5, poc].Value.ToString();
            txbTel.Text = mainGV[6, poc].Value.ToString();
            txbCorreo.Text = mainGV[7, poc].Value.ToString();

        }
        //Metodo que guarda los nuevos cambios 
        private void btnGuardarNuevoscambios_Click(object sender, EventArgs e)
        {
            CCliente cliente = new CCliente();
            try
            {
                cliente.EditarCliente(id,txbPnombre.Text,txbSnombre.Text,txbPapellido.Text,txbSapellido.Text,txbDireccion.Text,txbTel.Text,txbCorreo.Text);
                refresh();
                MessageBox.Show("Editado Correctamente...");
            }
            catch (Exception es)
            {

                msgerror(es.Message);
            }
        }
        //metodo que permite agregar un nuevo registro
        private void button1_Click(object sender, EventArgs e)
        {
            Habilitar();
            Desabilitar();
            clearCampos();
            
        }
        //metodo que desabilita botones
        private void Desabilitar()
        {
            this.btnAgregar.Enabled = false;
            this.btnguardar.Visible = true;
            this.btnBuscarRegistro.Visible = false;
            this.btnGuardarNuevoscambios.Visible = false;
            mainGV.CellClick -= mainGV_CellClick;
            txbPnombre.Click -= Pn;
            txbSnombre.Click -= Sn;
            txbPapellido.Click -= Pa;
            txbSapellido.Click -= Sa;
        }
        //metodo que limpia campos
        private void clearCampos()
        {
            txbPnombre.Text = "";
            txbSnombre.Text = "";
            txbPapellido.Text = "";
            txbSapellido.Text = "";
            txbTel.Text = "";
            txbDireccion.Text = "";
            txbCorreo.Text = "";
        }
        //Metodo que cambia el estado del cliente
        private void btnactualizarestado_Click(object sender, EventArgs e)
        {
            Habilitar();
            String rpt = null;
            int i = 0;
            int aux = 0;

            Desabilitar();
            clearCampos();

            i = mainGV.CurrentRow.Index;
            aux = Convert.ToInt32(mainGV[0,i].Value.ToString());     
            this.gbxdatos.Enabled = false;
            rpt = MessageBox.Show("Esta Seguro De Cambiar El Estado ?","Estado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation).ToString();
            
            if (rpt.Equals("Yes"))
            {
                try
                {
                    CCliente cliente = new CCliente();
                    cliente.CambiarEstado(aux);
                    MessageBox.Show("Estado Cambiado Exitosamente...");
                    refresh();
                }
                catch (Exception ex)
                {

                    msgerror(ex.Message);
                }
            }
            else
                MessageBox.Show("Proceso Cancelado","Cancelado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            clearCampos();
            DesabilitarEnBusqueda();
        }

        private void DesabilitarEnBusqueda()
        {
            gbxdatos.Enabled = true;
            lblCorreo.Visible = false;
            lblTel.Visible = false;
            lblDireccion.Visible = false;
            txbCorreo.Visible = false;
            txbTel.Visible = false;
            txbDireccion.Visible = false;
            btnGuardarNuevoscambios.Visible = false;
            btnguardar.Visible = false;
            btnBuscarRegistro.Visible = true;
            btnAgregar.Enabled = true;
            txbPnombre.Click += Pn;
            txbSnombre.Click += Sn;
            txbPapellido.Click += Pa;
            txbSapellido.Click += Sa;
            btnactualizarestado.Enabled = false;
        }
        private void Habilitar()
        {
            lblCorreo.Visible = true;
            lblTel.Visible = true;
            lblDireccion.Visible = true;
            txbCorreo.Visible = true;
            txbTel.Visible = true;
            txbDireccion.Visible = true;
            txbPnombre.Enabled = true;
            txbSnombre.Enabled = true;
            txbPapellido.Enabled = true;
            txbSapellido.Enabled = true;
            btnGuardarNuevoscambios.Visible = true;
            btnguardar.Visible = true;
            btnactualizarestado.Enabled = true;
            btnBuscarRegistro.Visible =false;
            mainGV.CellContentClick += mainGV_CellContentClick;
        }

        private void Pn(object sender, EventArgs e)
        {
            txbSnombre.Enabled = false;
            txbPapellido.Enabled = false;
            txbSapellido.Enabled = false;
        }

        private void Sn(object sender, EventArgs e)
        {
            txbPnombre.Enabled = false;
            txbPapellido.Enabled = false;
            txbSapellido.Enabled = false;
        }

        private void Pa(object sender, EventArgs e)
        {

            txbPnombre.Enabled = false;
            txbSnombre.Enabled = false;
            txbSapellido.Enabled = false;
        }

        private void Sa(object sender, EventArgs e)
        {
            txbPnombre.Enabled = false;
            txbSnombre.Enabled = false;
            txbPapellido.Enabled = false;
        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbPnombre.Enabled == true)
                {
                    mainGV.DataSource = CCliente.showBusqueda(txbPnombre.Text);
                    mainGV.CellContentClick -= mainGV_CellContentClick;
                }
                else if (txbSnombre.Enabled == true)
                {
                    mainGV.DataSource = CCliente.showBusqueda(txbSnombre.Text);
                    mainGV.CellContentClick -= mainGV_CellContentClick;
                }
                else if (txbPapellido.Enabled == true)
                {
                    mainGV.DataSource = CCliente.showBusqueda(txbPapellido.Text);
                    mainGV.CellContentClick -= mainGV_CellContentClick;
                }
                else if (txbSapellido.Enabled == true)
                {
                    mainGV.DataSource = CCliente.showBusqueda(txbSapellido.Text);
                    mainGV.CellContentClick -= mainGV_CellContentClick;
                }
            }
            catch (Exception ex)
            {

                msgerror(ex.Message);
            }
        }
    }
}
