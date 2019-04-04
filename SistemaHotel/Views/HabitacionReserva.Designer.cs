namespace SistemaHotel.Views
{
    partial class HabitacionReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitacionReserva));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.No_habitacion = new System.Windows.Forms.TextBox();
            this.Id_reserva = new System.Windows.Forms.TextBox();
            this.fecha_de_entrada = new System.Windows.Forms.DateTimePicker();
            this.fecha_de_salida = new System.Windows.Forms.DateTimePicker();
            this.Precio_habitacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_de_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Datos_Habitacion = new System.Windows.Forms.DataGridView();
            this.datos_reserva = new System.Windows.Forms.DataGridView();
            this.datos_precio_habitacion = new System.Windows.Forms.DataGridView();
            this.datos_habitacion_reserva = new System.Windows.Forms.DataGridView();
            this.boton_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_de_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Habitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_precio_habitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_habitacion_reserva)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.No_habitacion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Id_reserva, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fecha_de_entrada, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fecha_de_salida, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Precio_habitacion, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "No de la Habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id de la Reserva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Precio";
            // 
            // No_habitacion
            // 
            this.No_habitacion.Location = new System.Drawing.Point(145, 3);
            this.No_habitacion.Name = "No_habitacion";
            this.No_habitacion.Size = new System.Drawing.Size(136, 26);
            this.No_habitacion.TabIndex = 4;
            this.No_habitacion.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // Id_reserva
            // 
            this.Id_reserva.Location = new System.Drawing.Point(145, 36);
            this.Id_reserva.Name = "Id_reserva";
            this.Id_reserva.Size = new System.Drawing.Size(136, 26);
            this.Id_reserva.TabIndex = 5;
            this.Id_reserva.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // fecha_de_entrada
            // 
            this.fecha_de_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_de_entrada.Location = new System.Drawing.Point(145, 69);
            this.fecha_de_entrada.Name = "fecha_de_entrada";
            this.fecha_de_entrada.Size = new System.Drawing.Size(136, 26);
            this.fecha_de_entrada.TabIndex = 6;
            this.fecha_de_entrada.ValueChanged += new System.EventHandler(this.verificacion);
            // 
            // fecha_de_salida
            // 
            this.fecha_de_salida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_de_salida.Location = new System.Drawing.Point(145, 102);
            this.fecha_de_salida.Name = "fecha_de_salida";
            this.fecha_de_salida.Size = new System.Drawing.Size(136, 26);
            this.fecha_de_salida.TabIndex = 7;
            this.fecha_de_salida.ValueChanged += new System.EventHandler(this.verificacion);
            // 
            // Precio_habitacion
            // 
            this.Precio_habitacion.Location = new System.Drawing.Point(145, 135);
            this.Precio_habitacion.Name = "Precio_habitacion";
            this.Precio_habitacion.Size = new System.Drawing.Size(136, 26);
            this.Precio_habitacion.TabIndex = 8;
            this.Precio_habitacion.TextChanged += new System.EventHandler(this.verificacion);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos de Habitacion Reserva";
            // 
            // panel_de_control
            // 
            this.panel_de_control.Controls.Add(this.tabPage1);
            this.panel_de_control.Controls.Add(this.tabPage2);
            this.panel_de_control.Controls.Add(this.tabPage3);
            this.panel_de_control.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_de_control.Location = new System.Drawing.Point(338, 22);
            this.panel_de_control.Name = "panel_de_control";
            this.panel_de_control.SelectedIndex = 0;
            this.panel_de_control.Size = new System.Drawing.Size(281, 167);
            this.panel_de_control.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Datos_Habitacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Habitacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.datos_reserva);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(273, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reserva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.datos_precio_habitacion);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(273, 139);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Precio Habitacion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Datos_Habitacion
            // 
            this.Datos_Habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos_Habitacion.Location = new System.Drawing.Point(6, 5);
            this.Datos_Habitacion.Name = "Datos_Habitacion";
            this.Datos_Habitacion.Size = new System.Drawing.Size(260, 120);
            this.Datos_Habitacion.TabIndex = 3;
            this.Datos_Habitacion.DoubleClick += new System.EventHandler(this.Datos_Habitacion_DoubleClick);
            // 
            // datos_reserva
            // 
            this.datos_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_reserva.Location = new System.Drawing.Point(6, 5);
            this.datos_reserva.Name = "datos_reserva";
            this.datos_reserva.Size = new System.Drawing.Size(260, 120);
            this.datos_reserva.TabIndex = 3;
            this.datos_reserva.DoubleClick += new System.EventHandler(this.datos_reserva_DoubleClick);
            // 
            // datos_precio_habitacion
            // 
            this.datos_precio_habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_precio_habitacion.Location = new System.Drawing.Point(6, 5);
            this.datos_precio_habitacion.Name = "datos_precio_habitacion";
            this.datos_precio_habitacion.Size = new System.Drawing.Size(260, 120);
            this.datos_precio_habitacion.TabIndex = 3;
            this.datos_precio_habitacion.DoubleClick += new System.EventHandler(this.datos_precio_habitacion_DoubleClick);
            // 
            // datos_habitacion_reserva
            // 
            this.datos_habitacion_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_habitacion_reserva.Location = new System.Drawing.Point(12, 271);
            this.datos_habitacion_reserva.Name = "datos_habitacion_reserva";
            this.datos_habitacion_reserva.Size = new System.Drawing.Size(603, 185);
            this.datos_habitacion_reserva.TabIndex = 5;
            // 
            // boton_guardar
            // 
            this.boton_guardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_guardar.Image = ((System.Drawing.Image)(resources.GetObject("boton_guardar.Image")));
            this.boton_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boton_guardar.Location = new System.Drawing.Point(6, 3);
            this.boton_guardar.Name = "boton_guardar";
            this.boton_guardar.Size = new System.Drawing.Size(146, 64);
            this.boton_guardar.TabIndex = 6;
            this.boton_guardar.Text = "GUARDAR";
            this.boton_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boton_guardar.UseVisualStyleBackColor = true;
            this.boton_guardar.Click += new System.EventHandler(this.boton_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.boton_guardar);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(342, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 70);
            this.panel1.TabIndex = 7;
            // 
            // HabitacionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datos_habitacion_reserva);
            this.Controls.Add(this.panel_de_control);
            this.Controls.Add(this.groupBox1);
            this.Name = "HabitacionReserva";
            this.Text = "HabitacionReserva";
            this.Load += new System.EventHandler(this.HabitacionReserva_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel_de_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Habitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_precio_habitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_habitacion_reserva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox No_habitacion;
        private System.Windows.Forms.TextBox Id_reserva;
        private System.Windows.Forms.DateTimePicker fecha_de_entrada;
        private System.Windows.Forms.DateTimePicker fecha_de_salida;
        private System.Windows.Forms.TextBox Precio_habitacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl panel_de_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Datos_Habitacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView datos_reserva;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView datos_precio_habitacion;
        private System.Windows.Forms.DataGridView datos_habitacion_reserva;
        private System.Windows.Forms.Button boton_guardar;
        private System.Windows.Forms.Panel panel1;
    }
}