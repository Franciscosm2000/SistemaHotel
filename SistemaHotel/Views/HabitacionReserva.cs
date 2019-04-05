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
    public partial class HabitacionReserva : Form
    {
        public HabitacionReserva()
        {
            InitializeComponent();
            CenterToScreen();
            /*Bitmap img = new Bitmap(Application.StartupPath + @"\background\Fondo2.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;*/
            boton_guardar.Enabled = false;
        }

        private void mostrar()
        {
            this.datos_habitacion_reserva.DataSource = CHabReserva.visualizar_habitacion_reserva();
            this.Datos_Habitacion.DataSource = CHabReserva.visualizar_las_habitaciones();
            this.datos_reserva.DataSource = CHabReserva.visualizar_la_reservacion();
            //this.datos_precio_habitacion.DataSource = CHabReserva.visualizar_tipo_habitacion();
        }

        private void HabitacionReserva_Load(object sender, EventArgs e)
        {
            this.mostrar();
            No_habitacion.Enabled = false;
            Id_reserva.Enabled = false;
            Precio_habitacion.Enabled = false;
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

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CHabReserva entrada = new CHabReserva();

                    entrada.insertar_datos(
                    Convert.ToInt32(No_habitacion.Text),
                    Convert.ToInt32(Id_reserva.Text),
                    Convert.ToDateTime(fecha_de_entrada.Text),
                    Convert.ToDateTime(fecha_de_salida.Text),
                    Convert.ToDouble(Precio_habitacion.Text));
                MensajeOk("GUARDADO CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            this.mostrar();
        }

        private void Datos_Habitacion_DoubleClick(object sender, EventArgs e)
        {
            No_habitacion.Text = Convert.ToString(this.Datos_Habitacion.CurrentRow.Cells["No Habitación"].Value);
            Precio_habitacion.Text = Convert.ToString(this.Datos_Habitacion.CurrentRow.Cells["Precio"].Value);
        }

        private void datos_reserva_DoubleClick(object sender, EventArgs e)
        {
            Id_reserva.Text = Convert.ToString(this.datos_reserva.CurrentRow.Cells["Id de Reserva"].Value);
        }

        /*private void datos_precio_habitacion_DoubleClick(object sender, EventArgs e)
        {
            Precio_habitacion.Text = Convert.ToString(this.datos_precio_habitacion.CurrentRow.Cells["Precio"].Value);
        }*/

        private void verificacion(object sender, EventArgs e)
        {
            if (No_habitacion.Text.Length != 0 &&
                Id_reserva.Text.Length != 0 &&
                fecha_de_entrada.Text.Length != 0 &&
                fecha_de_salida.Text.Length != 0 &&
                Precio_habitacion.Text.Length != 0
                )
            {
                boton_guardar.Enabled = true;
            }
            else
            {
                boton_guardar.Enabled = false;
            }
        }

        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar la Habitacion reserva", "HABITACION RESERVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CHabReserva.eliminar_hab_reserva(Convert.ToInt32(this.datos_habitacion_reserva.CurrentRow.Cells["Id de Habitacion Reserva"].Value));
                this.mostrar();
            }
            else
            {
                this.mostrar();
            }
            
        }

        private void Datos_Habitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
