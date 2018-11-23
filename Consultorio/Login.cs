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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }



        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtusuario.Text) || String.IsNullOrEmpty(txtcontrasena.Text))
            {
                MessageBox.Show("Tiene que completar todos los campos.");
                return;
                
            }

            String user, role;

            using (var db = new ConsultorioDBEntities())
            {
                var consulta = from s in db.usuarios
                               where s.usuario1 == txtusuario.Text
                               where s.contrasena == txtcontrasena.Text
                               select s;
                if (consulta.ToList().Count > 0)
                {
                    usuario selected = consulta.FirstOrDefault();
                    user = txtusuario.Text;
                    role = selected.usuario_role;
                   
                    MenuPrincipal menu = new MenuPrincipal(selected.nombres, selected.apellidos, role, user);
                    this.Hide();
                    menu.ShowDialog();

                    
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el usuario");
                    txtcontrasena.Clear();
                }

                };
                
            
        }


    }
}




