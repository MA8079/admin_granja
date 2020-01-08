namespace Capa_de_presentacion
{
    partial class Registrar_peso
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
            this.tbpeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // tbpeso
            // 
            this.tbpeso.BackColor = System.Drawing.Color.DarkGray;
            this.tbpeso.Location = new System.Drawing.Point(82, 161);
            this.tbpeso.Name = "tbpeso";
            this.tbpeso.Size = new System.Drawing.Size(116, 20);
            this.tbpeso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // datetime
            // 
            this.datetime.CalendarMonthBackground = System.Drawing.Color.Silver;
            this.datetime.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.datetime.Location = new System.Drawing.Point(247, 161);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(233, 20);
            this.datetime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código de ganado";
            // 
            // tb_code
            // 
            this.tb_code.BackColor = System.Drawing.Color.DarkGray;
            this.tb_code.Location = new System.Drawing.Point(247, 209);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(116, 20);
            this.tb_code.TabIndex = 8;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(119, 260);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 33);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Registrar";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Gold;
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(297, 260);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(98, 33);
            this.btncancel.TabIndex = 12;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.Btncancel_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Gold;
            this.btnhome.ForeColor = System.Drawing.Color.Black;
            this.btnhome.Location = new System.Drawing.Point(119, 326);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(276, 35);
            this.btnhome.TabIndex = 13;
            this.btnhome.Text = "Volver a Menú";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.Btnhome_Click);
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.Gainsboro;
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(176, 81);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(140, 21);
            this.cb1.TabIndex = 14;
            this.cb1.Text = "Desplegar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Seleccione opción de registro";
            // 
            // Registrar_peso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbpeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Registrar_peso";
            this.Text = "Control de Peso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registrar_peso_FormClosing);
            this.Load += new System.EventHandler(this.Registrar_peso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label7;
    }
}