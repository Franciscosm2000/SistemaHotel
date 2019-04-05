namespace SistemaHotel.Views
{
    partial class clienteDlg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clienteDlg));
            this.gbxdatos = new System.Windows.Forms.GroupBox();
            this.btnGuardarNuevoscambios = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSa = new System.Windows.Forms.Label();
            this.txbSnombre = new System.Windows.Forms.TextBox();
            this.lblPn = new System.Windows.Forms.Label();
            this.txbPnombre = new System.Windows.Forms.TextBox();
            this.lblSn = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txbPapellido = new System.Windows.Forms.TextBox();
            this.txbCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPa = new System.Windows.Forms.Label();
            this.txbSapellido = new System.Windows.Forms.TextBox();
            this.btnBuscarRegistro = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxlistacliente = new System.Windows.Forms.GroupBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnactualizarestado = new System.Windows.Forms.Button();
            this.mainGV = new System.Windows.Forms.DataGridView();
            this.gbxdatos.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxlistacliente.SuspendLayout();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxdatos
            // 
            this.gbxdatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.gbxdatos.Controls.Add(this.btnGuardarNuevoscambios);
            this.gbxdatos.Controls.Add(this.btnguardar);
            this.gbxdatos.Controls.Add(this.tableLayoutPanel2);
            this.gbxdatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxdatos.Location = new System.Drawing.Point(3, 3);
            this.gbxdatos.Name = "gbxdatos";
            this.gbxdatos.Size = new System.Drawing.Size(442, 433);
            this.gbxdatos.TabIndex = 0;
            this.gbxdatos.TabStop = false;
            this.gbxdatos.Text = "Datos";
            // 
            // btnGuardarNuevoscambios
            // 
            this.btnGuardarNuevoscambios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGuardarNuevoscambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardarNuevoscambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarNuevoscambios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarNuevoscambios.Location = new System.Drawing.Point(111, 268);
            this.btnGuardarNuevoscambios.Name = "btnGuardarNuevoscambios";
            this.btnGuardarNuevoscambios.Size = new System.Drawing.Size(157, 26);
            this.btnGuardarNuevoscambios.TabIndex = 2;
            this.btnGuardarNuevoscambios.Text = "Guardar Nuevos Cambios";
            this.btnGuardarNuevoscambios.UseVisualStyleBackColor = false;
            this.btnGuardarNuevoscambios.Click += new System.EventHandler(this.btnGuardarNuevoscambios_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguardar.Location = new System.Drawing.Point(111, 266);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(157, 28);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.84694F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.15306F));
            this.tableLayoutPanel2.Controls.Add(this.txbTel, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblTel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txbDireccion, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblDireccion, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblSa, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txbSnombre, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbPnombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCorreo, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txbPapellido, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbCorreo, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblPa, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbSapellido, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarRegistro, 1, 7);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49809F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50027F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(392, 190);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(120, 118);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(240, 22);
            this.txbTel.TabIndex = 12;
            this.txbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(3, 115);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(62, 15);
            this.lblTel.TabIndex = 11;
            this.lblTel.Text = "Teléfono  :";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(120, 95);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(240, 22);
            this.txbDireccion.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(3, 92);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 15);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección  :";
            // 
            // lblSa
            // 
            this.lblSa.AutoSize = true;
            this.lblSa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSa.Location = new System.Drawing.Point(3, 69);
            this.lblSa.Name = "lblSa";
            this.lblSa.Size = new System.Drawing.Size(107, 15);
            this.lblSa.TabIndex = 7;
            this.lblSa.Text = "Segundo Apellido :";
            // 
            // txbSnombre
            // 
            this.txbSnombre.Location = new System.Drawing.Point(120, 26);
            this.txbSnombre.Name = "txbSnombre";
            this.txbSnombre.Size = new System.Drawing.Size(240, 22);
            this.txbSnombre.TabIndex = 4;
            this.txbSnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSnombre_KeyPress);
            // 
            // lblPn
            // 
            this.lblPn.AutoSize = true;
            this.lblPn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPn.Location = new System.Drawing.Point(3, 0);
            this.lblPn.Name = "lblPn";
            this.lblPn.Size = new System.Drawing.Size(95, 15);
            this.lblPn.TabIndex = 0;
            this.lblPn.Text = "Primer Nombre :";
            // 
            // txbPnombre
            // 
            this.txbPnombre.Location = new System.Drawing.Point(120, 3);
            this.txbPnombre.Name = "txbPnombre";
            this.txbPnombre.Size = new System.Drawing.Size(240, 22);
            this.txbPnombre.TabIndex = 1;
            this.txbPnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPnombre_KeyPress);
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSn.Location = new System.Drawing.Point(3, 23);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(107, 15);
            this.lblSn.TabIndex = 1;
            this.lblSn.Text = "Segundo Nombre :";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(3, 138);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(49, 15);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo :";
            // 
            // txbPapellido
            // 
            this.txbPapellido.Location = new System.Drawing.Point(120, 49);
            this.txbPapellido.Name = "txbPapellido";
            this.txbPapellido.Size = new System.Drawing.Size(240, 22);
            this.txbPapellido.TabIndex = 2;
            this.txbPapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPapellido_KeyPress);
            // 
            // txbCorreo
            // 
            this.txbCorreo.Location = new System.Drawing.Point(120, 141);
            this.txbCorreo.Name = "txbCorreo";
            this.txbCorreo.Size = new System.Drawing.Size(240, 22);
            this.txbCorreo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 6;
            // 
            // lblPa
            // 
            this.lblPa.AutoSize = true;
            this.lblPa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPa.Location = new System.Drawing.Point(3, 46);
            this.lblPa.Name = "lblPa";
            this.lblPa.Size = new System.Drawing.Size(95, 15);
            this.lblPa.TabIndex = 13;
            this.lblPa.Text = "Primer Apellido :";
            // 
            // txbSapellido
            // 
            this.txbSapellido.Location = new System.Drawing.Point(120, 72);
            this.txbSapellido.Name = "txbSapellido";
            this.txbSapellido.Size = new System.Drawing.Size(240, 22);
            this.txbSapellido.TabIndex = 8;
            this.txbSapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSapellido_KeyPress);
            // 
            // btnBuscarRegistro
            // 
            this.btnBuscarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnBuscarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarRegistro.Location = new System.Drawing.Point(120, 164);
            this.btnBuscarRegistro.Name = "btnBuscarRegistro";
            this.btnBuscarRegistro.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarRegistro.TabIndex = 3;
            this.btnBuscarRegistro.Text = "Buscar";
            this.btnBuscarRegistro.UseVisualStyleBackColor = false;
            this.btnBuscarRegistro.Click += new System.EventHandler(this.btnBuscarRegistro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 613F));
            this.tableLayoutPanel1.Controls.Add(this.gbxlistacliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxdatos, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1061, 439);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbxlistacliente
            // 
            this.gbxlistacliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.gbxlistacliente.Controls.Add(this.pnl1);
            this.gbxlistacliente.Controls.Add(this.mainGV);
            this.gbxlistacliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxlistacliente.Location = new System.Drawing.Point(451, 3);
            this.gbxlistacliente.Name = "gbxlistacliente";
            this.gbxlistacliente.Size = new System.Drawing.Size(607, 433);
            this.gbxlistacliente.TabIndex = 2;
            this.gbxlistacliente.TabStop = false;
            this.gbxlistacliente.Text = "Lista  De Clientes";
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(79)))), ((int)(((byte)(114)))));
            this.pnl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl1.Controls.Add(this.btnAgregar);
            this.pnl1.Controls.Add(this.btneditar);
            this.pnl1.Controls.Add(this.btnbuscar);
            this.pnl1.Controls.Add(this.btnactualizarestado);
            this.pnl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl1.Location = new System.Drawing.Point(89, 266);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(424, 100);
            this.pnl1.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(3, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Location = new System.Drawing.Point(112, 38);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 1;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Location = new System.Drawing.Point(327, 38);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnactualizarestado
            // 
            this.btnactualizarestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnactualizarestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizarestado.Location = new System.Drawing.Point(206, 38);
            this.btnactualizarestado.Name = "btnactualizarestado";
            this.btnactualizarestado.Size = new System.Drawing.Size(105, 23);
            this.btnactualizarestado.TabIndex = 2;
            this.btnactualizarestado.Text = "Cambiar Estado";
            this.btnactualizarestado.UseVisualStyleBackColor = false;
            this.btnactualizarestado.Click += new System.EventHandler(this.btnactualizarestado_Click);
            // 
            // mainGV
            // 
            this.mainGV.AllowUserToAddRows = false;
            this.mainGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.mainGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mainGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.mainGV.EnableHeadersVisualStyles = false;
            this.mainGV.GridColor = System.Drawing.Color.SteelBlue;
            this.mainGV.Location = new System.Drawing.Point(6, 47);
            this.mainGV.Name = "mainGV";
            this.mainGV.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.mainGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.mainGV.Size = new System.Drawing.Size(592, 179);
            this.mainGV.TabIndex = 0;
            this.mainGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGV_CellClick);
            this.mainGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGV_CellContentClick);
            // 
            // clienteDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1092, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clienteDlg";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.clienteDlg_Load);
            this.gbxdatos.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxlistacliente.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxdatos;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbSapellido;
        private System.Windows.Forms.Label lblSa;
        private System.Windows.Forms.TextBox txbSnombre;
        private System.Windows.Forms.Label lblPn;
        private System.Windows.Forms.TextBox txbPnombre;
        private System.Windows.Forms.Label lblSn;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txbPapellido;
        private System.Windows.Forms.TextBox txbCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxlistacliente;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnactualizarestado;
        private System.Windows.Forms.DataGridView mainGV;
        private System.Windows.Forms.Button btnGuardarNuevoscambios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarRegistro;
    }
}