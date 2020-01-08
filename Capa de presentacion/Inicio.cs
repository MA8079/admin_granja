using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_de_presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ToroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_toro r_tor = new Registrar_toro();
            r_tor.Show();
            this.Hide();

        }

        private void VacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_vaca r_vac = new Registrar_vaca();
            r_vac.Show();
            this.Hide();
        }

        private void TerneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_ternero r_ter = new Registro_ternero();
            r_ter.Show();
            this.Hide();
        }

        private void VentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_venta r_venta = new Registro_venta();
            r_venta.Show();
            this.Hide();
        }

        private void ControlVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_tto r_veterinario = new Registro_tto();
            r_veterinario.Show();
            this.Hide();

        }

        private void ControlDePesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_peso r_peso = new Registrar_peso();
            r_peso.Show();
            this.Hide();
        }

        private void ControlDeProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar_prod r_produccion = new Registrar_prod();
            r_produccion.Show();
            this.Hide();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form_Registros nfr = new Form_Registros();
            nfr.Show();
            this.Hide();
        }
    }
}
