﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class PaginaConsultas : Form
    {
        public PaginaConsultas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Consultas formConsu = new Consultas();
            this.Hide();
            formConsu.ShowDialog();
        }
    }
}
