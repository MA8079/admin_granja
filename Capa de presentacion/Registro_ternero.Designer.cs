namespace Capa_de_presentacion
{
    partial class Registro_ternero
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.tbraza = new System.Windows.Forms.TextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.tb_codp = new System.Windows.Forms.TextBox();
            this.tb_codm = new System.Windows.Forms.TextBox();
            this.tbtip_proc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.busq_img = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código de padre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de madre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de procreación";
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb1.Location = new System.Drawing.Point(190, 224);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(214, 165);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // tbraza
            // 
            this.tbraza.Location = new System.Drawing.Point(190, 30);
            this.tbraza.Name = "tbraza";
            this.tbraza.Size = new System.Drawing.Size(143, 20);
            this.tbraza.TabIndex = 6;
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(190, 65);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 7;
            // 
            // tb_codp
            // 
            this.tb_codp.Location = new System.Drawing.Point(190, 99);
            this.tb_codp.Name = "tb_codp";
            this.tb_codp.Size = new System.Drawing.Size(143, 20);
            this.tb_codp.TabIndex = 8;
            // 
            // tb_codm
            // 
            this.tb_codm.Location = new System.Drawing.Point(190, 134);
            this.tb_codm.Name = "tb_codm";
            this.tb_codm.Size = new System.Drawing.Size(143, 20);
            this.tb_codm.TabIndex = 9;
            // 
            // tbtip_proc
            // 
            this.tbtip_proc.Location = new System.Drawing.Point(190, 171);
            this.tbtip_proc.Name = "tbtip_proc";
            this.tbtip_proc.Size = new System.Drawing.Size(143, 20);
            this.tbtip_proc.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre de archivo";
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(203, 433);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(177, 20);
            this.tbfname.TabIndex = 12;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(434, 264);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 35);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Registrar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(434, 329);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(106, 35);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.Btncancel_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(434, 418);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(106, 35);
            this.btnhome.TabIndex = 15;
            this.btnhome.Text = "Volver a Menú";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.Btnhome_Click);
            // 
            // busq_img
            // 
            this.busq_img.Location = new System.Drawing.Point(190, 395);
            this.busq_img.Name = "busq_img";
            this.busq_img.Size = new System.Drawing.Size(214, 21);
            this.busq_img.TabIndex = 16;
            this.busq_img.Text = "Buscar imagen";
            this.busq_img.UseVisualStyleBackColor = true;
            this.busq_img.Click += new System.EventHandler(this.Busq_img_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Registro_ternero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 465);
            this.Controls.Add(this.busq_img);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbtip_proc);
            this.Controls.Add(this.tb_codm);
            this.Controls.Add(this.tb_codp);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.tbraza);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro_ternero";
            this.Text = "Registrar Ternero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_ternero_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox tbraza;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.TextBox tb_codp;
        private System.Windows.Forms.TextBox tb_codm;
        private System.Windows.Forms.TextBox tbtip_proc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button busq_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}