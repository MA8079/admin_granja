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
    public partial class Registrar_peso : Form
    {
        Ectrl_peso nocp = new Ectrl_peso();
        public Registrar_peso()
        {
            
            InitializeComponent();
            
        }

        //Validar las opciones del control ComboBox
        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedItem.Equals("Toro"))
            {
                Reg_pes_toro();
            }
            else if (cb1.SelectedItem.Equals("Vaca"))
            {
                Reg_peso_vaca();
            }
            else if (cb1.SelectedItem.Equals("Ternero"))
            {
                Reg_peso_ternero();
            }
            else  {
                MessageBox.Show("Seleccione una opción");
            }
           
        }
        //Método de registro de ganados
        private void Reg_pes_toro() {
            try
            {
                String reporte = "";
                nocp.peso = Double.Parse(tbpeso.Text);
                nocp.fech_ctrl = datetime.Value;
                nocp.cod_toro = int.Parse(tb_code.Text);
                //nocp.cod_vaca = int.Parse(tb_codvaca.Text);
                //nocp.cod_ternero = int.Parse(tb_codter.Text);

                reporte = nocp.reg_peso_toro();
                MessageBox.Show(reporte);
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Reg_peso_vaca() {
            try
            {
                String reporte = "";
                nocp.peso = Double.Parse(tbpeso.Text);
                nocp.fech_ctrl = datetime.Value;
                //nocp.cod_toro = int.Parse(tb_codtoro.Text);
                nocp.cod_vaca = int.Parse(tb_code.Text);
                //nocp.cod_ternero = int.Parse(tb_codter.Text);

                reporte = nocp.reg_peso_toro();
                MessageBox.Show(reporte);
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void Reg_peso_ternero() {
            try
            {
                String reporte = "";
                nocp.peso = Double.Parse(tbpeso.Text);
                nocp.fech_ctrl = datetime.Value;
                //nocp.cod_toro = int.Parse(tb_codtoro.Text);
                //nocp.cod_vaca = int.Parse(tb_codvaca.Text);
                nocp.cod_ternero = int.Parse(tb_code.Text);

                reporte = nocp.reg_peso_ternero();
                MessageBox.Show(reporte);
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }
        //Cancelar registro de ganado
        private void Btncancel_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //Limpiar formulario de registro
        private void Limpiar() {
            tbpeso.Clear();
            tb_code.Clear();
            tb_code.Clear();
        }
        //Cargar lista de items del control ComboBox
        private void Registrar_peso_Load(object sender, EventArgs e)
        {
            cb1.Items.Add("Toro");
            cb1.Items.Add("Vaca");
            cb1.Items.Add("Ternero");
        }
        Inicio f_inicio = new Inicio();
        private void Btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registrar_peso_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            f_inicio.Show();
        }
    }
}
