namespace SistemaHotel.Views
{
    partial class mainFrm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControlUsuario = new System.Windows.Forms.Panel();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.habitaciónToolStripMenuItem,
            this.reservaToolStripMenuItem});
            this.catálogoToolStripMenuItem.Name = "catálogoToolStripMenuItem";
            this.catálogoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.catálogoToolStripMenuItem.Text = "Catálogo  ";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // habitaciónToolStripMenuItem
            // 
            this.habitaciónToolStripMenuItem.Name = "habitaciónToolStripMenuItem";
            this.habitaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habitaciónToolStripMenuItem.Text = "Habitación ";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponibilidadDeHabitacionesToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // disponibilidadDeHabitacionesToolStripMenuItem
            // 
            this.disponibilidadDeHabitacionesToolStripMenuItem.Name = "disponibilidadDeHabitacionesToolStripMenuItem";
            this.disponibilidadDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.disponibilidadDeHabitacionesToolStripMenuItem.Text = "Disponibilidad de Habitaciones";
            this.disponibilidadDeHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadDeHabitacionesToolStripMenuItem_Click);
            // 
            // pnlControlUsuario
            // 
            this.pnlControlUsuario.AutoSize = true;
            this.pnlControlUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlControlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlUsuario.Location = new System.Drawing.Point(0, 24);
            this.pnlControlUsuario.Name = "pnlControlUsuario";
            this.pnlControlUsuario.Size = new System.Drawing.Size(584, 337);
            this.pnlControlUsuario.TabIndex = 1;
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlControlUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrm";
            this.Text = "SistemaHotel";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlControlUsuario;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
    }
}