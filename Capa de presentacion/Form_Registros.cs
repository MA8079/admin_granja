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
    public partial class Form_Registros : Form
    {
        E_toros etor = new E_toros();
        E_vacas evac = new E_vacas();
        E_terneros eter = new E_terneros();
        E_ttos etto = new E_ttos();
        E_ventas even = new E_ventas();
        E_prod eprod = new E_prod();
        Ectrl_peso epes = new Ectrl_peso();
        DataTable dt;
        public Form_Registros()
        {
            InitializeComponent();
        }

        private void TorosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = etor.Listar_toros();
            dgv.DataSource = dt;
        }

        private void VacasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dt = evac.Listar_datos();
            dgv.DataSource = dt;
        }

        private void TernerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = eter.listar_terneros();
            dgv.DataSource = dt;
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = even.Listar_ventas();
            dgv.DataSource = dt;
        }

        private void ControlDePesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = epes.listar_peso();
            dgv.DataSource = dt;
        }

        private void ProducciónDeLecheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = eprod.listar_prod();
            dgv.DataSource = dt;
        }

        private void ControlVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt = etto.Listar_ttos();
            dgv.DataSource = dt;
        }
        Inicio f_inicio = new Inicio();
        private void Form_Registros_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            f_inicio.Show();
        }
    }
}
