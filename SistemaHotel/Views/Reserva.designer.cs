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
            this.boton_agregar = new System.Windows.Forms.Button();
            this.calendario_reserva = new System.Windows.Forms.MonthCalendar();
            this.fecha_entrada_txt = new System.Windows.Forms.TextBox();
            this.combo_stat = new System.Windows.Forms.ComboBox();
            this.combo_formadivisa = new System.Windows.Forms.ComboBox();
            this.combo_formapago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grupo_reserva.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupo_reserva
            // 
            this.grupo_reserva.Controls.Add(this.textBox3);
            this.grupo_reserva.Controls.Add(this.button2);
            this.grupo_reserva.Controls.Add(this.button1);
            this.grupo_reserva.Controls.Add(this.tableLayoutPanel1);
            this.grupo_reserva.Controls.Add(this.boton_agregar);
            this.grupo_reserva.Controls.Add(this.calendario_reserva);
            this.grupo_reserva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_reserva.Location = new System.Drawing.Point(23, 13);
            this.grupo_reserva.Name = "grupo_reserva";
            this.grupo_reserva.Size = new System.Drawing.Size(731, 274);
            this.grupo_reserva.TabIndex = 0;
            this.grupo_reserva.TabStop = false;
            this.grupo_reserva.Text = "Ingreso de datos de la reserva";
            // 
            // boton_agregar
            // 
            this.boton_agregar.Location = new System.Drawing.Point(294, 222);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(99, 37);
            this.boton_agregar.TabIndex = 18;
            this.boton_agregar.Text = "AGREGAR";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // calendario_reserva
            // 
            this.calendario_reserva.Location = new System.Drawing.Point(12, 167);
            this.calendario_reserva.Name = "calendario_reserva";
            this.calendario_reserva.TabIndex = 17;
            this.calendario_reserva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_reserva_DateChanged);
            // 
            // fecha_entrada_txt
            // 
            this.fecha_entrada_txt.Location = new System.Drawing.Point(303, 36);
            this.fecha_entrada_txt.Name = "fecha_entrada_txt";
            this.fecha_entrada_txt.Size = new System.Drawing.Size(142, 26);
            this.fecha_entrada_txt.TabIndex = 16;
            this.fecha_entrada_txt.TextChanged += new System.EventHandler(this.fecha_entrada_txt_TextChanged);
            // 
            // combo_stat
            // 
            this.combo_stat.FormattingEnabled = true;
            this.combo_stat.Items.AddRange(new object[] {
            "PAGADO",
            "RESERVADO",
            "PENALIZADO",
            "CANCELADO"});
            this.combo_stat.Location = new System.Drawing.Point(153, 102);
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
            this.combo_formadivisa.Location = new System.Drawing.Point(3, 102);
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
            this.combo_formapago.Location = new System.Drawing.Point(453, 36);
            this.combo_formapago.Name = "combo_formapago";
            this.combo_formapago.Size = new System.Drawing.Size(163, 27);
            this.combo_formapago.TabIndex = 12;
            this.combo_formapago.SelectedIndexChanged += new System.EventHandler(this.combo_formapago_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Stat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Divisa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forma Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 0);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 26);
            this.textBox2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.combo_stat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fecha_entrada_txt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.combo_formadivisa, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.combo_formapago, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 134);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 139);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "AGREGAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 26);
            this.textBox3.TabIndex = 23;
            // 
            // Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grupo_reserva);
            this.Name = "Reserva";
            this.Text = "Reserva";
            this.Load += new System.EventHandler(this.Reserva_Load);
            this.grupo_reserva.ResumeLayout(false);
            this.grupo_reserva.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.MonthCalendar calendario_reserva;
        private System.Windows.Forms.TextBox fecha_entrada_txt;
        private System.Windows.Forms.ComboBox combo_stat;
        private System.Windows.Forms.ComboBox combo_formadivisa;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}