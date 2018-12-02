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
    public partial class MenuPrincipal : Form
    {
        String nom, apell, rol, user;

       

        public MenuPrincipal(String nombres, String apellidos, String role, String usuario)
        {
            this.nom = nombres;
            this.apell = apellidos;
            this.rol = role;
            this.user = usuario;

            InitializeComponent();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pacientes obj = new Pacientes(nom, apell, rol, user);

            obj.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users obj = new Users();

            obj.ShowDialog();
        }
    }
}
