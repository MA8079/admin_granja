namespace Capa_de_presentacion
{
    partial class Registro_tto
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
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbdesc
            // 
            this.tbdesc.Location = new System.Drawing.Point(51, 82);
            this.tbdesc.Multiline = true;
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(413, 124);
            this.tbdesc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tratamiento Veterinario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medicamento";
            // 
            // tbmed
            // 
            this.tbmed.Location = new System.Drawing.Point(148, 223);
            this.tbmed.Name = "tbmed";
            this.tbmed.Size = new System.Drawing.Size(200, 20);
            this.tbmed.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha";
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(148, 268);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Código de ganado";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(391, 312);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(68, 20);
            this.tb_code.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(206, 398);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 38);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(39, 398);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(108, 38);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.Btncancel_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(366, 398);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(112, 38);
            this.btnhome.TabIndex = 15;
            this.btnhome.Text = "Volver a Menú";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.Btnhome_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 311);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Seleccionar ganado";
            // 
            // Registro_tto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 456);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbmed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdesc);
            this.Name = "Registro_tto";
            this.Text = "Registro Veterinario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_tto_FormClosing);
            this.Load += new System.EventHandler(this.Registro_tto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbdesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbmed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}