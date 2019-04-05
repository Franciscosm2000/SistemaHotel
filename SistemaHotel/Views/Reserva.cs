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
using System.Data.SqlClient;
using SistemaHotel.Model;

namespace SistemaHotel.Views
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
            CenterToScreen();
            //Bitmap img = new Bitmap(Application.StartupPath + @"\background\fondo1.jpg");
            //this.BackgroundImage = img;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            boton_agregar.Enabled = false;
            
        }

        

        private void combo_formapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mostrar()
        {
            this.datos_reserva.DataSource = CReserva.visualizar();
            this.datos_clientes.DataSource = CReserva.visualizar_2();
            this.datos_empleados.DataSource = CReserva.visualizar_3();
            datos_clientes.Columns["ID del cliente"].Visible = false;
            datos_empleados.Columns["ID del Empleado"].Visible = false;
            datos_reserva.Columns["ID Cliente"].Visible = false;
            datos_reserva.Columns["ID Empleado"].Visible = false;
        }
        
        private void Reserva_Load(object sender, EventArgs e)
        {
            this.mostrar();
            busqueda_txt.Hide();
            Id_cliente_txt.Enabled = false;
            Id_empleado_txt.Enabled = false;
            
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Convert.ToDateTime(fecha_de_la_reserva.Text));
            try
            {
                CReserva entrada = new CReserva();

                entrada.insertar_datos(
                    Convert.ToInt32(Id_cliente_txt.Text),
                    Convert.ToInt32(Id_empleado_txt.Text),
                    Convert.ToDateTime(fecha_de_la_reserva.Text),
                    Convert.ToString(combo_formapago.SelectedItem),
                    Convert.ToString(combo_formadivisa.SelectedItem),
                    Convert.ToString(combo_stat.SelectedItem));

                MensajeOk("GUARDADO CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            this.mostrar();

            if (MessageBox.Show("Desea Editar o Buscar un dato de la reserva", "RESERVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                busqueda_txt.Show();
                boton_editar.Enabled = true;
                boton_buscar.Enabled = true;
            }
            else
            {
                busqueda_txt.Hide();
                boton_editar.Enabled = false;
                boton_buscar.Enabled = false;
            }


        }

        private void datos_clientes_DoubleClick(object sender, EventArgs e)
        {
            Id_cliente_txt.Text = Convert.ToString(this.datos_clientes.CurrentRow.Cells["ID del cliente"].Value);
        }

        private void datos_empleados_DoubleClick(object sender, EventArgs e)
        {
            Id_empleado_txt.Text = Convert.ToString(this.datos_empleados.CurrentRow.Cells["ID del Empleado"].Value);
        }

        private void verificacion(object sender, EventArgs e)
        {
            if (Id_cliente_txt.Text.Length !=0 &&
                Id_empleado_txt.Text.Length != 0 &&
                fecha_de_la_reserva.Text.Length != 0 &&
                combo_formapago.SelectedItem != null &&
                combo_formadivisa.SelectedItem != null &&
                combo_stat.SelectedItem != null)
            {
                boton_agregar.Enabled = true;
            }
            else
            {
                boton_agregar.Enabled = false;
            }
        }

        private void verificacion_2(object sender, EventArgs e)
        {
            if (Id_cliente_txt.Text.Length != 0 &&
                Id_empleado_txt.Text.Length != 0 &&
                fecha_de_la_reserva.Text.Length != 0 &&
                combo_formapago.SelectedItem != null &&
                combo_formadivisa.SelectedItem != null &&
                combo_stat.SelectedItem != null)
            {
                //boton_agregar.Enabled = true;
                boton_editar.Enabled = true;
                
            }
            else
            {
                boton_editar.Enabled = false;
            }
        }

        private void boton_editar_Click(object sender, EventArgs e)
        {
            boton_agregar.Enabled = false;
            
            Console.WriteLine(Convert.ToDateTime(fecha_de_la_reserva.Text));
            try
            {
                CReserva entrada = new CReserva();

                entrada.editar_datos(
                    Convert.ToInt32(this.datos_reserva.CurrentRow.Cells["ID Reserva"].Value),
                    Convert.ToInt32(Id_cliente_txt.Text),
                    Convert.ToInt32(Id_empleado_txt.Text),
                    Convert.ToDateTime(fecha_de_la_reserva.Text),
                    Convert.ToString(combo_formapago.SelectedItem),
                    Convert.ToString(combo_formadivisa.SelectedItem),
                    Convert.ToString(combo_stat.SelectedItem));

                MensajeOk("EDITADOS CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            this.mostrar();
        }

        private void datos_reserva_DoubleClick(object sender, EventArgs e)
        {
            this.Id_cliente_txt.Text = Convert.ToString(this.datos_reserva.CurrentRow.Cells["ID Cliente"].Value);
            this.Id_empleado_txt.Text = Convert.ToString(this.datos_reserva.CurrentRow.Cells["ID Empleado"].Value);
            //this.fecha_de_la_reserva.Text = Convert.ToString(this.datos_reserva.CurrentRow.Cells["Fecha de la Reserva"].Value);
            this.combo_formapago.SelectedItem = Convert.ToString(this.datos_reserva.CurrentRow.Cells["Forma de Pago"].Value);
            this.combo_formadivisa.SelectedItem = Convert.ToString(this.datos_reserva.CurrentRow.Cells["Divisa"].Value);
            this.combo_stat.SelectedItem = Convert.ToString(this.datos_reserva.CurrentRow.Cells["Estado"].Value);
        }

        private void boton_buscar_Click(object sender, EventArgs e)
        {
            busqueda_txt.Show();
            
        }

        private void busqueda_txt_TextChanged(object sender, EventArgs e)
        {
            this.datos_reserva.DataSource = CReserva.buscar_cliente(this.busqueda_txt.Text.Trim());
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar esta reserva", "RESERVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CReserva.eliminar_reserva(Convert.ToInt32(this.datos_reserva.CurrentRow.Cells["Id Reserva"].Value));
                this.mostrar();
            }
            else
            {
                this.mostrar();
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
