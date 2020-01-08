namespace Capa_de_presentacion
{
    partial class Registrar_toro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_raza = new System.Windows.Forms.TextBox();
            this.tb_origen = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.pb = new System.Windows.Forms.PictureBox();
            this.busq_img = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ruta = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lugar de origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // tb_raza
            // 
            this.tb_raza.BackColor = System.Drawing.Color.DarkGray;
            this.tb_raza.Location = new System.Drawing.Point(204, 53);
            this.tb_raza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_raza.Name = "tb_raza";
            this.tb_raza.Size = new System.Drawing.Size(132, 21);
            this.tb_raza.TabIndex = 3;
            // 
            // tb_origen
            // 
            this.tb_origen.BackColor = System.Drawing.Color.DarkGray;
            this.tb_origen.Location = new System.Drawing.Point(204, 93);
            this.tb_origen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_origen.Name = "tb_origen";
            this.tb_origen.Size = new System.Drawing.Size(132, 21);
            this.tb_origen.TabIndex = 4;
            // 
            // dtp
            // 
            this.dtp.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dtp.Location = new System.Drawing.Point(204, 132);
            this.dtp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(265, 21);
            this.dtp.TabIndex = 5;
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb.Location = new System.Drawing.Point(204, 183);
            this.pb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(285, 212);
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            // 
            // busq_img
            // 
            this.busq_img.BackColor = System.Drawing.Color.Green;
            this.busq_img.Location = new System.Drawing.Point(204, 414);
            this.busq_img.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.busq_img.Name = "busq_img";
            this.busq_img.Size = new System.Drawing.Size(285, 40);
            this.busq_img.TabIndex = 7;
            this.busq_img.Text = "Buscar imagen";
            this.busq_img.UseVisualStyleBackColor = false;
            this.busq_img.Click += new System.EventHandler(this.Busq_img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 478);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ruta de imagen";
            // 
            // tb_ruta
            // 
            this.tb_ruta.BackColor = System.Drawing.Color.DarkGray;
            this.tb_ruta.Location = new System.Drawing.Point(204, 474);
            this.tb_ruta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_ruta.Name = "tb_ruta";
            this.tb_ruta.Size = new System.Drawing.Size(284, 21);
            this.tb_ruta.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.Location = new System.Drawing.Point(559, 219);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 43);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Green;
            this.btn_cancel.Location = new System.Drawing.Point(559, 324);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 43);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Green;
            this.btn_home.Location = new System.Drawing.Point(559, 459);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(176, 38);
            this.btn_home.TabIndex = 12;
            this.btn_home.Text = "Volver a Menú";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // Registrar_toro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(761, 519);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_ruta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.busq_img);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.tb_origen);
            this.Controls.Add(this.tb_raza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Registrar_toro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Toro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registrar_toro_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_raza;
        private System.Windows.Forms.TextBox tb_origen;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button busq_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ruta;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_home;
    }
}