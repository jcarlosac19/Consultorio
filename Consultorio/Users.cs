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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNombres.Clear();
            tbApellidos.Clear();
            tbUsuario.Clear();
            tbPassword.Clear();
            tbRol.Text = " ";
            tbNombres.Focus();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioDBEntities())
            {
                //Validando que los campos no queden vacios
                if (tbNombres.Text == "" || tbApellidos.Text == "" || tbPassword.Text == "" || tbUsuario.Text == "" || tbRol.Text == "")
                {
                    MessageBox.Show("Ingrese la informacion");
                }
                //Guarda un nuevo usuario en la DB
                usuario User = new usuario();

                User.nombres = tbNombres.Text;
                User.apellidos = tbApellidos.Text;
                User.contrasena = tbPassword.Text;
                User.usuario1 = tbUsuario.Text;
                User.usuario_role = tbRol.Text;
                db.usuarios.Add(User);
                int filasafectadas = db.SaveChanges();

                if (filasafectadas > 0)
                {
                    MessageBox.Show("Se ha agregado un nuevo usuario");
                }
                else
                {
                    MessageBox.Show("No se ha podido agregar el usuario");
                }

            }
        }
    }
}


