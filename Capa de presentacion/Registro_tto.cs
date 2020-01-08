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

using System.Data.SqlTypes;

namespace Capa_de_presentacion
{
    public partial class Registro_tto : Form
    {
        E_ttos notto = new E_ttos();
        public Registro_tto()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("Toro"))
            {
                Reg_tto_toro();
            }
            else if (comboBox1.SelectedItem.Equals("Vaca"))
            {
                Reg_tto_vaca();
            }
            else if (comboBox1.SelectedItem.Equals("Ternero"))
            {
                Reg_tto_ternero();
            }
            else
            {
                MessageBox.Show("ATENCIÓN! Seleccionar ganado");
            }


        }

        private void Reg_tto_toro() {
            try
            {
                String reporte = "";
                notto.descrip = tbdesc.Text;
                notto.medicamento = tbmed.Text;
                notto.fecha_tto = datetime.Value;
                //Datos NULL
                notto.cod_toro = int.Parse(tb_code.Text);
                //notto.cod_vaca = int.Parse(tbcodv.Text);
                //notto.cod_ternero = int.Parse(tbcodter.Text);

                reporte = notto.Registrar_tto_toro();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reg_tto_vaca() {
            try
            {
                String reporte = "";
                notto.descrip = tbdesc.Text;
                notto.medicamento = tbmed.Text;
                notto.fecha_tto = datetime.Value;
                //Datos NULL
                notto.cod_vaca = int.Parse(tb_code.Text);

                reporte = notto.Registrar_tto_vaca();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Reg_tto_ternero() {
            try
            {
                String reporte = "";
                notto.descrip = tbdesc.Text;
                notto.medicamento = tbmed.Text;
                notto.fecha_tto = datetime.Value;
                //Datos NULL
                notto.cod_ternero = int.Parse(tb_code.Text);

                reporte = notto.Registrar_tto_ternero();
                MessageBox.Show(reporte);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {

            tb_code.Clear();
            tbdesc.Clear();
            tbmed.Clear();
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Registro_tto_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Toro");
            comboBox1.Items.Add("Vaca");
            comboBox1.Items.Add("Ternero");
        }
        Inicio f_inicio = new Inicio();
        private void Btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            f_inicio.Show();
        }

        private void Registro_tto_FormClosing(object sender, FormClosingEventArgs e)
        {
            f_inicio.Show();
        }
    }
}
