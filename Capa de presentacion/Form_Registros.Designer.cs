﻿namespace Capa_de_presentacion
{
    partial class Form_Registros
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ternerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDePesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producciónDeLecheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlVeterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torosToolStripMenuItem,
            this.vacasToolStripMenuItem,
            this.ternerosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.controlDePesoToolStripMenuItem,
            this.producciónDeLecheToolStripMenuItem,
            this.controlVeterinarioToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // torosToolStripMenuItem
            // 
            this.torosToolStripMenuItem.Name = "torosToolStripMenuItem";
            this.torosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.torosToolStripMenuItem.Text = "Toros";
            this.torosToolStripMenuItem.Click += new System.EventHandler(this.TorosToolStripMenuItem_Click);
            // 
            // vacasToolStripMenuItem
            // 
            this.vacasToolStripMenuItem.Name = "vacasToolStripMenuItem";
            this.vacasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.vacasToolStripMenuItem.Text = "Vacas";
            this.vacasToolStripMenuItem.Click += new System.EventHandler(this.VacasToolStripMenuItem_Click);
            // 
            // ternerosToolStripMenuItem
            // 
            this.ternerosToolStripMenuItem.Name = "ternerosToolStripMenuItem";
            this.ternerosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ternerosToolStripMenuItem.Text = "Terneros";
            this.ternerosToolStripMenuItem.Click += new System.EventHandler(this.TernerosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.VentasToolStripMenuItem_Click);
            // 
            // controlDePesoToolStripMenuItem
            // 
            this.controlDePesoToolStripMenuItem.Name = "controlDePesoToolStripMenuItem";
            this.controlDePesoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.controlDePesoToolStripMenuItem.Text = "Control de peso";
            this.controlDePesoToolStripMenuItem.Click += new System.EventHandler(this.ControlDePesoToolStripMenuItem_Click);
            // 
            // producciónDeLecheToolStripMenuItem
            // 
            this.producciónDeLecheToolStripMenuItem.Name = "producciónDeLecheToolStripMenuItem";
            this.producciónDeLecheToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.producciónDeLecheToolStripMenuItem.Text = "Producción de Leche";
            this.producciónDeLecheToolStripMenuItem.Click += new System.EventHandler(this.ProducciónDeLecheToolStripMenuItem_Click);
            // 
            // controlVeterinarioToolStripMenuItem
            // 
            this.controlVeterinarioToolStripMenuItem.Name = "controlVeterinarioToolStripMenuItem";
            this.controlVeterinarioToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.controlVeterinarioToolStripMenuItem.Text = "Control Veterinario";
            this.controlVeterinarioToolStripMenuItem.Click += new System.EventHandler(this.ControlVeterinarioToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 73);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(604, 292);
            this.dgv.TabIndex = 1;
            // 
            // Form_Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 384);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Registros";
            this.Text = "Form_Registros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Registros_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDePesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producciónDeLecheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlVeterinarioToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
    }
}