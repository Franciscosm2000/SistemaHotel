﻿namespace SistemaHotel.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarHabitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porHabitaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.recaudacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogoToolStripMenuItem
            // 
            this.catálogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
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
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservaToolStripMenuItem.Text = "Reserva";
            this.reservaToolStripMenuItem.Click += new System.EventHandler(this.reservaToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponibilidadDeHabitacionesToolStripMenuItem,
            this.reservarHabitaciónToolStripMenuItem});
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
            // reservarHabitaciónToolStripMenuItem
            // 
            this.reservarHabitaciónToolStripMenuItem.Name = "reservarHabitaciónToolStripMenuItem";
            this.reservarHabitaciónToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.reservarHabitaciónToolStripMenuItem.Text = "Reservar Habitación";
            this.reservarHabitaciónToolStripMenuItem.Click += new System.EventHandler(this.reservarHabitaciónToolStripMenuItem_Click);
            // 
            // recaudacionesToolStripMenuItem
            // 
            this.recaudacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porHabitaciónToolStripMenuItem});
            this.recaudacionesToolStripMenuItem.Name = "recaudacionesToolStripMenuItem";
            this.recaudacionesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.recaudacionesToolStripMenuItem.Text = "Recaudaciones";
            // 
            // porHabitaciónToolStripMenuItem
            // 
            this.porHabitaciónToolStripMenuItem.Name = "porHabitaciónToolStripMenuItem";
            this.porHabitaciónToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.porHabitaciónToolStripMenuItem.Text = " Recaudaciones y Bonificaciones";
            this.porHabitaciónToolStripMenuItem.Click += new System.EventHandler(this.porHabitaciónToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 514);
            this.panel1.TabIndex = 2;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(938, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainFrm";
            this.Text = "Sistema Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarHabitaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porHabitaciónToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}