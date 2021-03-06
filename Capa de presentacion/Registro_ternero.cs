﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Capa_de_negocio;

namespace Capa_de_presentacion
{
    public partial class Registro_ternero : Form
    {
        E_terneros noter = new E_terneros();
        public Registro_ternero()
        {
            InitializeComponent();
        }

        private void Busq_img_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg;*.jpeg;*.png|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb1.Image = Image.FromFile(openFileDialog1.FileName);
                tbfname.Text = openFileDialog1.FileName;
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String reporte = "";
                noter.raza = tbraza.Text;
                noter.fech_nac = datetime.Value;
                noter.cod_padre = int.Parse(tb_codp.Text);
                noter.cod_madre = int.Parse(tb_codm.Text);
                noter.tip_procreacion = tbtip_proc.Text;
                noter.foto_ternero =Img_bit(tbfname.Text);

                reporte=noter.Registrar_entrada();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private Byte[] Img_bit(String filepath)
        {
            MemoryStream ms = new MemoryStream();
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            ms.SetLength(fs.Length);

            fs.Read(ms.GetBuffer(), 0, (int)fs.Length);

            Byte[] arrimg = ms.GetBuffer();
            ms.Flush();
            fs.Close();
            return arrimg;
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            tbraza.Clear();
            tbfname.Clear();
            tbtip_proc.Clear();
            tb_codp.Clear();
            tb_codm.Clear();
            pb1.Image = null;
        }
        Inicio f_inicio = new Inicio();
        private void Btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registro_ternero_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_inicio.Show();
        }
    }
}
