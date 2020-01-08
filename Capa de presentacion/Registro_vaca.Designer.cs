namespace Capa_de_presentacion
{
    partial class Registrar_vaca
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
            this.tbraza = new System.Windows.Forms.TextBox();
            this.tblorigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbfilename = new System.Windows.Forms.TextBox();
            this.busq_img = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbraza
            // 
            this.tbraza.Location = new System.Drawing.Point(165, 31);
            this.tbraza.Name = "tbraza";
            this.tbraza.Size = new System.Drawing.Size(124, 20);
            this.tbraza.TabIndex = 0;
            // 
            // tblorigen
            // 
            this.tblorigen.Location = new System.Drawing.Point(165, 74);
            this.tblorigen.Name = "tblorigen";
            this.tblorigen.Size = new System.Drawing.Size(124, 20);
            this.tblorigen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lugar de origen";
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(165, 118);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // Pb1
            // 
            this.Pb1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Pb1.Location = new System.Drawing.Point(130, 157);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(214, 184);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb1.TabIndex = 7;
            this.Pb1.TabStop = false;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(382, 187);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(107, 40);
            this.btn_reg.TabIndex = 8;
            this.btn_reg.Text = "Registrar";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.Btn_reg_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre de archivo";
            // 
            // tbfilename
            // 
            this.tbfilename.Location = new System.Drawing.Point(130, 382);
            this.tbfilename.Name = "tbfilename";
            this.tbfilename.Size = new System.Drawing.Size(214, 20);
            this.tbfilename.TabIndex = 10;
            // 
            // busq_img
            // 
            this.busq_img.Location = new System.Drawing.Point(130, 347);
            this.busq_img.Name = "busq_img";
            this.busq_img.Size = new System.Drawing.Size(214, 29);
            this.busq_img.TabIndex = 11;
            this.busq_img.Text = "Buscar imagen";
            this.busq_img.UseVisualStyleBackColor = true;
            this.busq_img.Click += new System.EventHandler(this.Busq_img_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(382, 279);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 36);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(382, 366);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(107, 36);
            this.btn_home.TabIndex = 13;
            this.btn_home.Text = "Volver a Menú";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Registrar_vaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(501, 424);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.busq_img);
            this.Controls.Add(this.tbfilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.Pb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblorigen);
            this.Controls.Add(this.tbraza);
            this.Name = "Registrar_vaca";
            this.Text = "Registrar Vaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registrar_vaca_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbraza;
        private System.Windows.Forms.TextBox tblorigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbfilename;
        private System.Windows.Forms.Button busq_img;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}