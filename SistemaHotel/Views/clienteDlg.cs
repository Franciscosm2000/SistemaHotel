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
            if (validarcampos() == true)
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
                mainGV.Columns["Id_Cliente"].Visible = false;
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
            if (validarcampos() == true)
            {
                CCliente cliente = new CCliente();
                try
                {
                    cliente.EditarCliente(id, txbPnombre.Text, txbSnombre.Text, txbPapellido.Text, txbSapellido.Text, txbDireccion.Text, txbTel.Text, txbCorreo.Text);
                    refresh();
                    MessageBox.Show("Editado Correctamente...");
                }
                catch (Exception es)
                {

                    msgerror(es.Message);
                }
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
            lblPn.Text = "Registro :";
            lblSn.Visible = false;
            lblPa.Visible = false;
            lblSa.Visible = false;
            lblCorreo.Visible = false;
            lblTel.Visible = false;
            lblDireccion.Visible = false;
            txbCorreo.Visible = false;
            txbTel.Visible = false;
            txbDireccion.Visible = false;
            txbSnombre.Visible = false;
            txbPapellido.Visible = false;
            txbSapellido.Visible = false;
            btnGuardarNuevoscambios.Visible = false;
            btnguardar.Visible = false;
            btnBuscarRegistro.Visible = true;
            btnAgregar.Enabled = true;
            btnactualizarestado.Enabled = false;
        }
        private void Habilitar()
        {
            lblCorreo.Visible = true;
            lblTel.Visible = true;
            lblDireccion.Visible = true;
            txbCorreo.Visible = true;
            txbTel.Visible = true;
            lblPn.Text = "Primer Nombre :";
            lblSn.Visible = true;
            lblPa.Visible = true;
            lblSa.Visible = true;
            txbDireccion.Visible = true;
            txbPnombre.Visible = true;
            txbSnombre.Visible = true;
            txbPapellido.Visible = true;
            txbSapellido.Visible = true;
            txbSnombre.Visible = true;
            txbPapellido.Visible = true;
            txbSapellido.Visible = true;
            btnGuardarNuevoscambios.Visible = true;
            btnguardar.Visible = true;
            btnactualizarestado.Enabled = true;
            btnBuscarRegistro.Visible =false;
            mainGV.CellContentClick += mainGV_CellContentClick;
        }

        private void btnBuscarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
               mainGV.DataSource = CCliente.showBusqueda(txbPnombre.Text); 
            }
            catch (Exception ex)
            {

                msgerror(ex.Message);
            }
        }
        //Metodo para validar que los campos no esten vacios
        private bool validarcampos()
        {
            bool rpt = false;
            int cont = 0;

            if (txbPnombre.Text.Equals("") || txbPnombre.Text == null)
            {
                MessageBox.Show(" Obligatorio llenar los campos ... ");
                cont = 0;
            }
            else
            {
                cont = cont + 1;
                if (txbSnombre.Text.Equals("") || txbSnombre.Text == null)
                {
                    MessageBox.Show(" Obligatorio llenar los campos ... ");
                    cont = 0;
                }
                else
                {
                    cont = cont + 1;
                    if (txbPapellido.Text.Equals("") || txbPapellido.Text == null)
                    {
                        MessageBox.Show(" Obligatorio llenar los campos ... ");
                        cont = 0;
                    }
                    else
                    {
                        cont = cont + 1;

                        if (txbSapellido.Text.Equals("") || txbSapellido.Text == null)
                        {
                            MessageBox.Show(" Obligatorio llenar los campos ... ");
                            cont = 0;
                        }
                        else
                        {
                            cont = cont + 1;

                            if (txbDireccion.Text.Equals("") || txbDireccion.Text == null)
                            {
                                MessageBox.Show(" Obligatorio llenar los campos ... ");
                                cont = 0;
                            }
                            else
                            {
                                cont = cont + 1;

                                if (txbTel.Text.Equals("") || txbTel.Text == null || txbTel.Text.Length > 8 || txbTel.Text.Length <8)
                                {
                                    MessageBox.Show(" El nùmero de telèfono es incorrecto, ... ");
                                    cont = 0;
                                }
                                else
                                {
                                    cont = cont + 1;

                                    if (txbCorreo.Text.Equals("") || txbCorreo.Text == null)
                                    {
                                        MessageBox.Show(" Obligatorio llenar los campos ... ");
                                        cont = 0;
                                    }
                                    else
                                    {
                                        cont = cont + 1;
                                    }
                                }

                            }
                        }
                    }
                }
            } // termina el primer else

            if (cont == 7)
            {
                rpt = true;

            }
            else
            {
                rpt = false;
            }
           return rpt;
        }
        //metodo validar solo letras
        private void solo_letras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                msgerror(ex.Message);
            }
        }
        //metodo validar solo numeros
        private void solo_numeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                msgerror(ex.Message);
            }
        }

        private void txbPnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_letras(e);
        }

        private void txbSnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_letras(e);
        }

        private void txbPapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_letras(e);
        }

        private void txbSapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_letras(e);
        }

        private void txbTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            solo_numeros(e);
        }
    }
}
