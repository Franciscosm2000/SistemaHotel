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
        }

        private void calendario_reserva_DateChanged(object sender, DateRangeEventArgs e)
        {
            fecha_entrada_txt.Text = calendario_reserva.SelectionEnd.Date.ToString();
            calendario_reserva.Visible = false;
        }

        private void fecha_entrada_txt_TextChanged(object sender, EventArgs e)
        {
            calendario_reserva.Visible = true;
        }

        private void combo_formapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            calendario_reserva.Visible = false;
        }

        private void combo_idempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            calendario_reserva.Visible = false;
            
            combo_idempleado.Items.Add(CReserva.listado_empleado());
        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            calendario_reserva.Visible = false;
            
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
            try
            {
                string rpta = "";

                rpta = CReserva.insertar_datos(
                    Convert.ToInt32(combo_idcliente.SelectedItem),
                    Convert.ToInt32(combo_idempleado.SelectedItem),
                    fecha_entrada_txt.Text,
                    Convert.ToString(combo_formapago.SelectedItem),
                    Convert.ToString(combo_formadivisa.SelectedItem),
                    Convert.ToString(combo_stat.SelectedItem));
                    MensajeOk("GUARDADO CORRECTAMENTE");
            }
            catch (Exception ex)
            {
                MensajeError(Convert.ToString(ex));
               
            }       


    
        }

        private void combo_idcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_idcliente.Items.Add(CReserva.listado_cliente());
        }

        private void boton_visualizar_Click(object sender, EventArgs e)
        {
            //this.dataCliente.DataSource = NCliente.Mostrar();
            //this.lista_de_las_reservas = CReserva.
        }
    }
}
