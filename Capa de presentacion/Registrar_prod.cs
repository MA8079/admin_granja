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

namespace Capa_de_presentacion
{
    public partial class Registrar_prod : Form
    {
        E_prod nopro = new E_prod();
        public Registrar_prod()
        {
            InitializeComponent();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                String reporte = "";
                nopro.litros = float.Parse(tblitro.Text);
                nopro.fech_reg = datetime.Value;
                nopro.cod_vaca = int.Parse(tbcod_vac.Text);

                reporte=nopro.registrar_prod();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar() {
            tblitro.Clear();
            tbcod_vac.Clear();
        }
        Inicio f_inicio = new Inicio();
        private void Btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registrar_prod_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_inicio.Show();
        }
    }
}
