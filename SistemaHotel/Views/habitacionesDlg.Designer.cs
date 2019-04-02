namespace SistemaHotel.Views
{
    partial class habitacionesDlg
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
            this.fieldsPane = new System.Windows.Forms.Panel();
            this.nohabSelec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f_inDTP = new System.Windows.Forms.DateTimePicker();
            this.f_outDTP = new System.Windows.Forms.DateTimePicker();
            this.btnsPane = new System.Windows.Forms.FlowLayoutPanel();
            this.dtPane = new System.Windows.Forms.Panel();
            this.disponBtn = new System.Windows.Forms.Button();
            this.perfechasBtn = new System.Windows.Forms.Button();
            this.mainGridV = new System.Windows.Forms.DataGridView();
            this.fieldsPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nohabSelec)).BeginInit();
            this.btnsPane.SuspendLayout();
            this.dtPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridV)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldsPane
            // 
            this.fieldsPane.Controls.Add(this.f_outDTP);
            this.fieldsPane.Controls.Add(this.f_inDTP);
            this.fieldsPane.Controls.Add(this.nohabSelec);
            this.fieldsPane.Controls.Add(this.label3);
            this.fieldsPane.Controls.Add(this.label2);
            this.fieldsPane.Controls.Add(this.label1);
            this.fieldsPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldsPane.Location = new System.Drawing.Point(0, 0);
            this.fieldsPane.Name = "fieldsPane";
            this.fieldsPane.Size = new System.Drawing.Size(544, 100);
            this.fieldsPane.TabIndex = 0;
            // 
            // nohabSelec
            // 
            this.nohabSelec.Location = new System.Drawing.Point(251, 11);
            this.nohabSelec.Name = "nohabSelec";
            this.nohabSelec.Size = new System.Drawing.Size(200, 20);
            this.nohabSelec.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Habitación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // f_inDTP
            // 
            this.f_inDTP.Location = new System.Drawing.Point(251, 37);
            this.f_inDTP.Name = "f_inDTP";
            this.f_inDTP.Size = new System.Drawing.Size(200, 20);
            this.f_inDTP.TabIndex = 4;
            // 
            // f_outDTP
            // 
            this.f_outDTP.Location = new System.Drawing.Point(251, 65);
            this.f_outDTP.Name = "f_outDTP";
            this.f_outDTP.Size = new System.Drawing.Size(200, 20);
            this.f_outDTP.TabIndex = 5;
            // 
            // btnsPane
            // 
            this.btnsPane.Controls.Add(this.disponBtn);
            this.btnsPane.Controls.Add(this.perfechasBtn);
            this.btnsPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsPane.Location = new System.Drawing.Point(0, 271);
            this.btnsPane.Name = "btnsPane";
            this.btnsPane.Size = new System.Drawing.Size(544, 30);
            this.btnsPane.TabIndex = 1;
            // 
            // dtPane
            // 
            this.dtPane.Controls.Add(this.mainGridV);
            this.dtPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtPane.Location = new System.Drawing.Point(0, 100);
            this.dtPane.Name = "dtPane";
            this.dtPane.Size = new System.Drawing.Size(544, 171);
            this.dtPane.TabIndex = 2;
            // 
            // disponBtn
            // 
            this.disponBtn.Location = new System.Drawing.Point(3, 3);
            this.disponBtn.Name = "disponBtn";
            this.disponBtn.Size = new System.Drawing.Size(261, 23);
            this.disponBtn.TabIndex = 0;
            this.disponBtn.Text = "Disponibilidad de la habitación en rango de fechas";
            this.disponBtn.UseVisualStyleBackColor = true;
            this.disponBtn.Click += new System.EventHandler(this.disponBtn_Click);
            // 
            // perfechasBtn
            // 
            this.perfechasBtn.Location = new System.Drawing.Point(270, 3);
            this.perfechasBtn.Name = "perfechasBtn";
            this.perfechasBtn.Size = new System.Drawing.Size(249, 23);
            this.perfechasBtn.TabIndex = 1;
            this.perfechasBtn.Text = "Estado de Habitación en Rango de fechas";
            this.perfechasBtn.UseVisualStyleBackColor = true;
            this.perfechasBtn.Click += new System.EventHandler(this.perfechasBtn_Click);
            // 
            // mainGridV
            // 
            this.mainGridV.AllowUserToAddRows = false;
            this.mainGridV.AllowUserToDeleteRows = false;
            this.mainGridV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridV.Location = new System.Drawing.Point(0, 0);
            this.mainGridV.Name = "mainGridV";
            this.mainGridV.ReadOnly = true;
            this.mainGridV.Size = new System.Drawing.Size(544, 171);
            this.mainGridV.TabIndex = 0;
            // 
            // habitacionesDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 301);
            this.Controls.Add(this.dtPane);
            this.Controls.Add(this.btnsPane);
            this.Controls.Add(this.fieldsPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "habitacionesDlg";
            this.Text = "Consulta de Habitaciones";
            this.fieldsPane.ResumeLayout(false);
            this.fieldsPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nohabSelec)).EndInit();
            this.btnsPane.ResumeLayout(false);
            this.dtPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fieldsPane;
        private System.Windows.Forms.NumericUpDown nohabSelec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker f_outDTP;
        private System.Windows.Forms.DateTimePicker f_inDTP;
        private System.Windows.Forms.FlowLayoutPanel btnsPane;
        private System.Windows.Forms.Button disponBtn;
        private System.Windows.Forms.Button perfechasBtn;
        private System.Windows.Forms.Panel dtPane;
        private System.Windows.Forms.DataGridView mainGridV;
    }
}