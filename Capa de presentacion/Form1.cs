﻿using System;
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
    public partial class Form1 : Form
    {
        E_ventas tbv = new E_ventas();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = tbv.Listar_ventas();
            dgv1.DataSource = dt;
        }
    }
}
