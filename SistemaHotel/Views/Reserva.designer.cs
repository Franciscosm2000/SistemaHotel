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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            this.grupo_reserva = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fecha_de_la_reserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_empleado_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_cliente_txt = new System.Windows.Forms.TextBox();
            this.combo_formadivisa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_stat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_formapago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datos_empleados = new System.Windows.Forms.DataGridView();
            this.datos_clientes = new System.Windows.Forms.DataGridView();
            this.datos_reserva = new System.Windows.Forms.DataGridView();
            this.busqueda_txt = new System.Windows.Forms.TextBox();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.boton_editar = new System.Windows.Forms.Button();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grupo_reserva.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reserva)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_reserva
            // 
            this.grupo_reserva.BackColor = System.Drawing.Color.Transparent;
            this.grupo_reserva.Controls.Add(this.tableLayoutPanel1);
            this.grupo_reserva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_reserva.Location = new System.Drawing.Point(23, 13);
            this.grupo_reserva.Name = "grupo_reserva";
            this.grupo_reserva.Size = new System.Drawing.Size(348, 294);
            this.grupo_reserva.TabIndex = 0;
            this.grupo_reserva.TabStop = false;
            this.grupo_reserva.Text = "Ingreso de datos de la reserva";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.Controls.Add(this.fecha_de_la_reserva, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Id_empleado_txt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Id_cliente_txt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.combo_formadivisa, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.combo_stat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.combo_formapago, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 248);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // fecha_de_la_reserva
            // 
            this.fecha_de_la_reserva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_de_la_reserva.Location = new System.Drawing.Point(3, 208);
            this.fecha_de_la_reserva.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.fecha_de_la_reserva.MinDate = new System.DateTime(2019, 3, 1, 0, 0, 0, 0);
            this.fecha_de_la_reserva.Name = "fecha_de_la_reserva";
            this.fecha_de_la_reserva.Size = new System.Drawing.Size(144, 26);
            this.fecha_de_la_reserva.TabIndex = 26;
            this.fecha_de_la_reserva.TabIndexChanged += new System.EventHandler(this.verificacion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Cliente";
            // 
            // Id_empleado_txt
            // 
            this.Id_empleado_txt.Location = new System.Drawing.Point(153, 44);
            this.Id_empleado_txt.Name = "Id_empleado_txt";
            this.Id_empleado_txt.Size = new System.Drawing.Size(144, 26);
            this.Id_empleado_txt.TabIndex = 2;
            this.Id_empleado_txt.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Empleado";
            // 
            // Id_cliente_txt
            // 
            this.Id_cliente_txt.Location = new System.Drawing.Point(3, 44);
            this.Id_cliente_txt.Name = "Id_cliente_txt";
            this.Id_cliente_txt.Size = new System.Drawing.Size(144, 26);
            this.Id_cliente_txt.TabIndex = 1;
            this.Id_cliente_txt.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // combo_formadivisa
            // 
            this.combo_formadivisa.FormattingEnabled = true;
            this.combo_formadivisa.Items.AddRange(new object[] {
            "NIO",
            "USD",
            "EUR"});
            this.combo_formadivisa.Location = new System.Drawing.Point(3, 126);
            this.combo_formadivisa.Name = "combo_formadivisa";
            this.combo_formadivisa.Size = new System.Drawing.Size(144, 27);
            this.combo_formadivisa.TabIndex = 13;
            this.combo_formadivisa.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Divisa";
            // 
            // combo_stat
            // 
            this.combo_stat.FormattingEnabled = true;
            this.combo_stat.Items.AddRange(new object[] {
            "PAGADO",
            "RESERVADO",
            "PENALIZADO",
            "CANCELADO"});
            this.combo_stat.Location = new System.Drawing.Point(153, 208);
            this.combo_stat.Name = "combo_stat";
            this.combo_stat.Size = new System.Drawing.Size(144, 27);
            this.combo_stat.TabIndex = 14;
            this.combo_stat.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma Pago";
            // 
            // combo_formapago
            // 
            this.combo_formapago.FormattingEnabled = true;
            this.combo_formapago.Items.AddRange(new object[] {
            "CONTADO",
            "CREDITO",
            "CHEQUE"});
            this.combo_formapago.Location = new System.Drawing.Point(153, 126);
            this.combo_formapago.Name = "combo_formapago";
            this.combo_formapago.Size = new System.Drawing.Size(144, 27);
            this.combo_formapago.TabIndex = 12;
            this.combo_formapago.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Reserva";
            // 
            // datos_empleados
            // 
            this.datos_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_empleados.Location = new System.Drawing.Point(386, 187);
            this.datos_empleados.Name = "datos_empleados";
            this.datos_empleados.Size = new System.Drawing.Size(349, 120);
            this.datos_empleados.TabIndex = 25;
            this.datos_empleados.DoubleClick += new System.EventHandler(this.datos_empleados_DoubleClick);
            // 
            // datos_clientes
            // 
            this.datos_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_clientes.Location = new System.Drawing.Point(386, 35);
            this.datos_clientes.Name = "datos_clientes";
            this.datos_clientes.Size = new System.Drawing.Size(349, 120);
            this.datos_clientes.TabIndex = 24;
            this.datos_clientes.DoubleClick += new System.EventHandler(this.datos_clientes_DoubleClick);
            // 
            // datos_reserva
            // 
            this.datos_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_reserva.Location = new System.Drawing.Point(23, 318);
            this.datos_reserva.Name = "datos_reserva";
            this.datos_reserva.Size = new System.Drawing.Size(558, 370);
            this.datos_reserva.TabIndex = 1;
            this.datos_reserva.DoubleClick += new System.EventHandler(this.datos_reserva_DoubleClick);
            // 
            // busqueda_txt
            // 
            this.busqueda_txt.Location = new System.Drawing.Point(13, 168);
            this.busqueda_txt.Name = "busqueda_txt";
            this.busqueda_txt.Size = new System.Drawing.Size(162, 29);
            this.busqueda_txt.TabIndex = 27;
            this.busqueda_txt.TextChanged += new System.EventHandler(this.busqueda_txt_TextChanged);
            // 
            // boton_buscar
            // 
            this.boton_buscar.Image = ((System.Drawing.Image)(resources.GetObject("boton_buscar.Image")));
            this.boton_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_buscar.Location = new System.Drawing.Point(13, 214);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(162, 57);
            this.boton_buscar.TabIndex = 26;
            this.boton_buscar.Text = "BUSCAR";
            this.boton_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // boton_editar
            // 
            this.boton_editar.Image = ((System.Drawing.Image)(resources.GetObject("boton_editar.Image")));
            this.boton_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_editar.Location = new System.Drawing.Point(13, 90);
            this.boton_editar.Name = "boton_editar";
            this.boton_editar.Size = new System.Drawing.Size(162, 57);
            this.boton_editar.TabIndex = 25;
            this.boton_editar.Text = "EDITAR";
            this.boton_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_editar.UseVisualStyleBackColor = true;
            this.boton_editar.TextChanged += new System.EventHandler(this.verificacion_2);
            this.boton_editar.Click += new System.EventHandler(this.boton_editar_Click);
            // 
            // boton_agregar
            // 
            this.boton_agregar.Image = ((System.Drawing.Image)(resources.GetObject("boton_agregar.Image")));
            this.boton_agregar.Location = new System.Drawing.Point(53, 14);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(74, 70);
            this.boton_agregar.TabIndex = 24;
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.TextChanged += new System.EventHandler(this.verificacion);
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.boton_eliminar);
            this.panel1.Controls.Add(this.busqueda_txt);
            this.panel1.Controls.Add(this.boton_agregar);
            this.panel1.Controls.Add(this.boton_editar);
            this.panel1.Controls.Add(this.boton_buscar);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(587, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 370);
            this.panel1.TabIndex = 28;
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("boton_eliminar.Image")));
            this.boton_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_eliminar.Location = new System.Drawing.Point(13, 296);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(162, 57);
            this.boton_eliminar.TabIndex = 28;
            this.boton_eliminar.Text = "ELIMINAR";
            this.boton_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_eliminar.UseVisualStyleBackColor = true;
            this.boton_eliminar.Click += new System.EventHandler(this.boton_eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "CLIENTES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "EMPLEADOS";
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 701);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datos_empleados);
            this.Controls.Add(this.datos_clientes);
            this.Controls.Add(this.datos_reserva);
            this.Controls.Add(this.grupo_reserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.grupo_reserva.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reserva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox combo_stat;
        private System.Windows.Forms.ComboBox combo_formadivisa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Id_empleado_txt;
        private System.Windows.Forms.TextBox Id_cliente_txt;
        private System.Windows.Forms.DataGridView datos_reserva;
        private System.Windows.Forms.DataGridView datos_clientes;
        private System.Windows.Forms.DataGridView datos_empleados;
        private System.Windows.Forms.DateTimePicker fecha_de_la_reserva;
        private System.Windows.Forms.TextBox busqueda_txt;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_editar;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button boton_eliminar;
    }
}