namespace SistemaHotel.Views
{
    partial class recaudacionesDlg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mydtpicker = new System.Windows.Forms.DateTimePicker();
            this.recservBtn = new System.Windows.Forms.Button();
            this.recxhabBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainGV = new System.Windows.Forms.DataGridView();
            this.bonif_emplBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bonif_emplBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mydtpicker);
            this.panel1.Controls.Add(this.recservBtn);
            this.panel1.Controls.Add(this.recxhabBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes y año ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mydtpicker
            // 
            this.mydtpicker.CustomFormat = "MM-yyyy";
            this.mydtpicker.Location = new System.Drawing.Point(518, 40);
            this.mydtpicker.Name = "mydtpicker";
            this.mydtpicker.Size = new System.Drawing.Size(200, 20);
            this.mydtpicker.TabIndex = 1;
            // 
            // recservBtn
            // 
            this.recservBtn.Location = new System.Drawing.Point(115, 41);
            this.recservBtn.Name = "recservBtn";
            this.recservBtn.Size = new System.Drawing.Size(199, 23);
            this.recservBtn.TabIndex = 1;
            this.recservBtn.Text = "Ver Recaudaciones por servicio";
            this.recservBtn.UseVisualStyleBackColor = true;
            this.recservBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // recxhabBtn
            // 
            this.recxhabBtn.Location = new System.Drawing.Point(115, 12);
            this.recxhabBtn.Name = "recxhabBtn";
            this.recxhabBtn.Size = new System.Drawing.Size(199, 23);
            this.recxhabBtn.TabIndex = 0;
            this.recxhabBtn.Text = "Ver Recaudaciones por Habitación";
            this.recxhabBtn.UseVisualStyleBackColor = true;
            this.recxhabBtn.Click += new System.EventHandler(this.recxhabBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mainGV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // mainGV
            // 
            this.mainGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGV.Location = new System.Drawing.Point(0, 0);
            this.mainGV.Name = "mainGV";
            this.mainGV.Size = new System.Drawing.Size(800, 350);
            this.mainGV.TabIndex = 0;
            // 
            // bonif_emplBtn
            // 
            this.bonif_emplBtn.Location = new System.Drawing.Point(115, 70);
            this.bonif_emplBtn.Name = "bonif_emplBtn";
            this.bonif_emplBtn.Size = new System.Drawing.Size(199, 23);
            this.bonif_emplBtn.TabIndex = 3;
            this.bonif_emplBtn.Text = "Ver Bonificaciones a Empleados";
            this.bonif_emplBtn.UseVisualStyleBackColor = true;
            this.bonif_emplBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // recaudacionesDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "recaudacionesDlg";
            this.Text = "recaudacionesDlg";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker mydtpicker;
        private System.Windows.Forms.Button recservBtn;
        private System.Windows.Forms.Button recxhabBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView mainGV;
        private System.Windows.Forms.Button bonif_emplBtn;
    }
}