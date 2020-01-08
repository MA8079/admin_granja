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
    public partial class Registrar_toro : Form
    {
        E_toros notor = new E_toros();   
        public Registrar_toro()
        {
            InitializeComponent();
        }

        private void Busq_img_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg;*.jpeg;*.png|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb.Image = Image.FromFile(openFileDialog1.FileName);
                tb_ruta.Text = openFileDialog1.FileName;
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                String reporte = "";
                notor.raza = tb_raza.Text;
                notor.l_origen = tb_origen.Text;
                notor.fech_nac = dtp.Value;
                notor.foto_toro = img_bit(tb_ruta.Text);

                reporte = notor.Registrar_entrada();
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

        private void Limpiar()
        {
            tb_raza.Clear();
            tb_origen.Clear();
            tb_ruta.Clear();
            pb.Image = null;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        Inicio f_inicio = new Inicio();
        private void Btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registrar_toro_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_inicio.Show();
        }
    }
}
