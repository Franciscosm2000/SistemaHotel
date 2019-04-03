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
            this.boton_agregar = new System.Windows.Forms.Button();
            this.combo_stat = new System.Windows.Forms.ComboBox();
            this.combo_formadivisa = new System.Windows.Forms.ComboBox();
            this.combo_formapago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_cliente_txt = new System.Windows.Forms.TextBox();
            this.Id_empleado_txt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datos_reserva = new System.Windows.Forms.DataGridView();
            this.boton_editar = new System.Windows.Forms.Button();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.busqueda_txt = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fecha_de_la_reserva = new System.Windows.Forms.DateTimePicker();
            this.grupo_reserva.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_reserva
            // 
            this.grupo_reserva.BackColor = System.Drawing.Color.Transparent;
            this.grupo_reserva.Controls.Add(this.dataGridView1);
            this.grupo_reserva.Controls.Add(this.dataGridView2);
            this.grupo_reserva.Controls.Add(this.busqueda_txt);
            this.grupo_reserva.Controls.Add(this.boton_buscar);
            this.grupo_reserva.Controls.Add(this.boton_editar);
            this.grupo_reserva.Controls.Add(this.tableLayoutPanel1);
            this.grupo_reserva.Controls.Add(this.boton_agregar);
            this.grupo_reserva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_reserva.Location = new System.Drawing.Point(23, 13);
            this.grupo_reserva.Name = "grupo_reserva";
            this.grupo_reserva.Size = new System.Drawing.Size(731, 324);
            this.grupo_reserva.TabIndex = 0;
            this.grupo_reserva.TabStop = false;
            this.grupo_reserva.Text = "Ingreso de datos de la reserva";
            // 
            // boton_agregar
            // 
            this.boton_agregar.Image = ((System.Drawing.Image)(resources.GetObject("boton_agregar.Image")));
            this.boton_agregar.Location = new System.Drawing.Point(340, 215);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(74, 70);
            this.boton_agregar.TabIndex = 18;
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
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
            this.combo_formapago.SelectedIndexChanged += new System.EventHandler(this.combo_formapago_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma Pago";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id_Empleado";
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
            // Id_cliente_txt
            // 
            this.Id_cliente_txt.Location = new System.Drawing.Point(3, 44);
            this.Id_cliente_txt.Name = "Id_cliente_txt";
            this.Id_cliente_txt.Size = new System.Drawing.Size(144, 26);
            this.Id_cliente_txt.TabIndex = 1;
            // 
            // Id_empleado_txt
            // 
            this.Id_empleado_txt.Location = new System.Drawing.Point(153, 44);
            this.Id_empleado_txt.Name = "Id_empleado_txt";
            this.Id_empleado_txt.Size = new System.Drawing.Size(144, 26);
            this.Id_empleado_txt.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
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
            // datos_reserva
            // 
            this.datos_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_reserva.Location = new System.Drawing.Point(23, 352);
            this.datos_reserva.Name = "datos_reserva";
            this.datos_reserva.Size = new System.Drawing.Size(731, 205);
            this.datos_reserva.TabIndex = 1;
            // 
            // boton_editar
            // 
            this.boton_editar.Image = ((System.Drawing.Image)(resources.GetObject("boton_editar.Image")));
            this.boton_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_editar.Location = new System.Drawing.Point(436, 228);
            this.boton_editar.Name = "boton_editar";
            this.boton_editar.Size = new System.Drawing.Size(135, 57);
            this.boton_editar.TabIndex = 21;
            this.boton_editar.Text = "EDITAR";
            this.boton_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_editar.UseVisualStyleBackColor = true;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Image = ((System.Drawing.Image)(resources.GetObject("boton_buscar.Image")));
            this.boton_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_buscar.Location = new System.Drawing.Point(577, 228);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(136, 57);
            this.boton_buscar.TabIndex = 22;
            this.boton_buscar.Text = "BUSCAR";
            this.boton_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_buscar.UseVisualStyleBackColor = true;
            // 
            // busqueda_txt
            // 
            this.busqueda_txt.Location = new System.Drawing.Point(402, 183);
            this.busqueda_txt.Name = "busqueda_txt";
            this.busqueda_txt.Size = new System.Drawing.Size(263, 26);
            this.busqueda_txt.TabIndex = 23;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(340, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(185, 130);
            this.dataGridView2.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(185, 130);
            this.dataGridView1.TabIndex = 25;
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
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.datos_reserva);
            this.Controls.Add(this.grupo_reserva);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.grupo_reserva.ResumeLayout(false);
            this.grupo_reserva.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox combo_stat;
        private System.Windows.Forms.ComboBox combo_formadivisa;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Id_empleado_txt;
        private System.Windows.Forms.TextBox Id_cliente_txt;
        private System.Windows.Forms.TextBox busqueda_txt;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Button boton_editar;
        private System.Windows.Forms.DataGridView datos_reserva;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fecha_de_la_reserva;
    }
}