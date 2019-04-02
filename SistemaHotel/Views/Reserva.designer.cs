namespace SistemaHotel.Views
{
    partial class Reserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupo_reserva = new System.Windows.Forms.GroupBox();
            this.boton_visualizar = new System.Windows.Forms.Button();
            this.lista_reserva = new System.Windows.Forms.ListView();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.calendario_reserva = new System.Windows.Forms.MonthCalendar();
            this.fecha_entrada_txt = new System.Windows.Forms.TextBox();
            this.combo_idempleado = new System.Windows.Forms.ComboBox();
            this.combo_idcliente = new System.Windows.Forms.ComboBox();
            this.combo_stat = new System.Windows.Forms.ComboBox();
            this.combo_formadivisa = new System.Windows.Forms.ComboBox();
            this.combo_formapago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lista_de_las_reservas = new System.Windows.Forms.ListView();
            this.grupo_reserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_reserva
            // 
            this.grupo_reserva.Controls.Add(this.boton_visualizar);
            this.grupo_reserva.Controls.Add(this.lista_reserva);
            this.grupo_reserva.Controls.Add(this.boton_agregar);
            this.grupo_reserva.Controls.Add(this.calendario_reserva);
            this.grupo_reserva.Controls.Add(this.fecha_entrada_txt);
            this.grupo_reserva.Controls.Add(this.combo_idempleado);
            this.grupo_reserva.Controls.Add(this.combo_idcliente);
            this.grupo_reserva.Controls.Add(this.combo_stat);
            this.grupo_reserva.Controls.Add(this.combo_formadivisa);
            this.grupo_reserva.Controls.Add(this.combo_formapago);
            this.grupo_reserva.Controls.Add(this.label6);
            this.grupo_reserva.Controls.Add(this.label5);
            this.grupo_reserva.Controls.Add(this.label4);
            this.grupo_reserva.Controls.Add(this.label3);
            this.grupo_reserva.Controls.Add(this.label2);
            this.grupo_reserva.Controls.Add(this.label1);
            this.grupo_reserva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_reserva.Location = new System.Drawing.Point(23, 13);
            this.grupo_reserva.Name = "grupo_reserva";
            this.grupo_reserva.Size = new System.Drawing.Size(731, 274);
            this.grupo_reserva.TabIndex = 0;
            this.grupo_reserva.TabStop = false;
            this.grupo_reserva.Text = "Ingreso de datos de la reserva";
            // 
            // boton_visualizar
            // 
            this.boton_visualizar.Location = new System.Drawing.Point(582, 213);
            this.boton_visualizar.Name = "boton_visualizar";
            this.boton_visualizar.Size = new System.Drawing.Size(121, 36);
            this.boton_visualizar.TabIndex = 19;
            this.boton_visualizar.Text = "VISUALIZAR";
            this.boton_visualizar.UseVisualStyleBackColor = true;
            this.boton_visualizar.Click += new System.EventHandler(this.boton_visualizar_Click);
            // 
            // lista_reserva
            // 
            this.lista_reserva.Location = new System.Drawing.Point(29, 156);
            this.lista_reserva.Name = "lista_reserva";
            this.lista_reserva.Size = new System.Drawing.Size(674, 42);
            this.lista_reserva.TabIndex = 1;
            this.lista_reserva.UseCompatibleStateImageBehavior = false;
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(604, 60);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(99, 37);
            this.boton_agregar.TabIndex = 18;
            this.boton_agregar.Text = "AGREGAR";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // calendario_reserva
            // 
            this.calendario_reserva.Location = new System.Drawing.Point(152, 106);
            this.calendario_reserva.Name = "calendario_reserva";
            this.calendario_reserva.TabIndex = 17;
            this.calendario_reserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_reserva_DateChanged);
            // 
            // fecha_entrada_txt
            // 
            this.fecha_entrada_txt.Location = new System.Drawing.Point(152, 106);
            this.fecha_entrada_txt.Name = "fecha_entrada_txt";
            this.fecha_entrada_txt.Size = new System.Drawing.Size(129, 26);
            this.fecha_entrada_txt.TabIndex = 16;
            this.fecha_entrada_txt.TextChanged += new System.EventHandler(this.fecha_entrada_txt_TextChanged);
            // 
            // combo_idempleado
            // 
            this.combo_idempleado.FormattingEnabled = true;
            this.combo_idempleado.Location = new System.Drawing.Point(152, 70);
            this.combo_idempleado.Name = "combo_idempleado";
            this.combo_idempleado.Size = new System.Drawing.Size(129, 27);
            this.combo_idempleado.TabIndex = 15;
            this.combo_idempleado.SelectedIndexChanged += new System.EventHandler(this.combo_idempleado_SelectedIndexChanged);
            // 
            // combo_idcliente
            // 
            this.combo_idcliente.FormattingEnabled = true;
            this.combo_idcliente.Location = new System.Drawing.Point(152, 37);
            this.combo_idcliente.Name = "combo_idcliente";
            this.combo_idcliente.Size = new System.Drawing.Size(129, 27);
            this.combo_idcliente.TabIndex = 1;
            this.combo_idcliente.SelectedIndexChanged += new System.EventHandler(this.combo_idcliente_SelectedIndexChanged);
            // 
            // combo_stat
            // 
            this.combo_stat.FormattingEnabled = true;
            this.combo_stat.Items.AddRange(new object[] {
            "PAGADO",
            "RESERVADO",
            "PENALIZADO",
            "CANCELADO"});
            this.combo_stat.Location = new System.Drawing.Point(466, 110);
            this.combo_stat.Name = "combo_stat";
            this.combo_stat.Size = new System.Drawing.Size(121, 27);
            this.combo_stat.TabIndex = 14;
            // 
            // combo_formadivisa
            // 
            this.combo_formadivisa.FormattingEnabled = true;
            this.combo_formadivisa.Items.AddRange(new object[] {
            "NIO",
            "USD",
            "EUR"});
            this.combo_formadivisa.Location = new System.Drawing.Point(466, 73);
            this.combo_formadivisa.Name = "combo_formadivisa";
            this.combo_formadivisa.Size = new System.Drawing.Size(121, 27);
            this.combo_formadivisa.TabIndex = 13;
            // 
            // combo_formapago
            // 
            this.combo_formapago.FormattingEnabled = true;
            this.combo_formapago.Items.AddRange(new object[] {
            "CONTADO",
            "CREDITO",
            "CHEQUE"});
            this.combo_formapago.Location = new System.Drawing.Point(466, 36);
            this.combo_formapago.Name = "combo_formapago";
            this.combo_formapago.Size = new System.Drawing.Size(121, 27);
            this.combo_formapago.TabIndex = 12;
            this.combo_formapago.SelectedIndexChanged += new System.EventHandler(this.combo_formapago_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Divisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cliente";
            // 
            // lista_de_las_reservas
            // 
            this.lista_de_las_reservas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_de_las_reservas.Location = new System.Drawing.Point(23, 302);
            this.lista_de_las_reservas.Name = "lista_de_las_reservas";
            this.lista_de_las_reservas.Size = new System.Drawing.Size(731, 139);
            this.lista_de_las_reservas.TabIndex = 2;
            this.lista_de_las_reservas.UseCompatibleStateImageBehavior = false;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lista_de_las_reservas);
            this.Controls.Add(this.grupo_reserva);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.grupo_reserva.ResumeLayout(false);
            this.grupo_reserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_reserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_formapago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar calendario_reserva;
        private System.Windows.Forms.TextBox fecha_entrada_txt;
        private System.Windows.Forms.ComboBox combo_idempleado;
        private System.Windows.Forms.ComboBox combo_idcliente;
        private System.Windows.Forms.ComboBox combo_stat;
        private System.Windows.Forms.ComboBox combo_formadivisa;
        private System.Windows.Forms.ListView lista_reserva;
        private System.Windows.Forms.Button boton_visualizar;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.ListView lista_de_las_reservas;
    }
}