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
    public partial class Registro_venta : Form
    {
        E_ventas noven = new E_ventas();
        public Registro_venta()
        {
            InitializeComponent();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Toro"))
            {
                Venta_toro();
            }
            else if (comboBox1.SelectedItem.Equals("Vaca"))
            {
                Venta_vaca();
            }
            else
            {
                MessageBox.Show("ATENCIÓN! Seleccionar ganado");
            }
            
        }

        private void Venta_toro() {
            try
            {
                String reporte = "";
                noven.precio = int.Parse(tbprecio.Text);
                noven.fecha = dateTimePicker1.Value;
                noven.cod_toro = int.Parse(tb_code.Text);
                

                reporte = noven.Registrar_venta_toro();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Venta_vaca() {
            try
            {
                String reporte = "";
                noven.precio = int.Parse(tbprecio.Text);
                noven.fecha = dateTimePicker1.Value;
                noven.cod_vaca = int.Parse(tb_code.Text);

                reporte = noven.Registrar_venta_vaca();
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
            tbprecio.Clear();
            tb_code.Clear();
            
        }

        private void Registro_venta_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toro");
            comboBox1.Items.Add("Vaca");
            
        }
        Inicio f_inicio = new Inicio();
        private void Btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registro_venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_inicio.Show();
        }
    }
}
