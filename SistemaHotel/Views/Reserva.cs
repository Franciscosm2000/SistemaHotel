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
            Bitmap img = new Bitmap(Application.StartupPath + @"\background\fondo1.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        

        private void combo_formapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combo_idempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void mostrar()
        {
            this.datos_reserva.DataSource = CReserva.visualizar();
        }
        
        private void Reserva_Load(object sender, EventArgs e)
        {
            this.mostrar();
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
            /*if (MessageBox.Show("Desea Editar o Buscar un dato de la reserva", "RESERVA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                busqueda_txt.Show();
            }
            else
            {
                busqueda_txt.Hide();
            }*/


        }

    }
}
