using System;
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCuentas obj = new MostrarCuentas();
            obj.ShowDialog();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Login log = new Login();

            log.ShowDialog();

        }

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
    }
}
