using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_negocio;
using System.IO;

namespace Capa_de_presentacion
{

    public partial class Registrar_vaca : Form
    {
        E_vacas novac = new E_vacas();
        public Registrar_vaca()
        {
            InitializeComponent();
        }

        private void Busq_img_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg;*.jpeg;*.png|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Pb1.Image = Image.FromFile(openFileDialog1.FileName);
                tbfilename.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_reg_Click(object sender, EventArgs e)
        {
            try
            {
                String reporte = "";
                novac.raza = tbraza.Text;
                novac.l_origen = tblorigen.Text;
                novac.fech_nac = datetime.Value;
                novac.foto_vaca = img_bit(tbfilename.Text);

                reporte = novac.Registrar_entrada();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private Byte[] img_bit(String filepath)
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

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            tbraza.Clear();
            tblorigen.Clear();
            tbfilename.Clear();
            Pb1.Image = null;
        }
        Inicio f_inicio = new Inicio();
        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registrar_vaca_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_inicio.Show();
        }
    }
}
