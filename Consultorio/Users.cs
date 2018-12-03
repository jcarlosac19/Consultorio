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
        private DataGridView dataGridView;
        bool modoEdicion;

        public Users(DataGridView dataGridView, bool modoEdicion)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.modoEdicion = modoEdicion;
            RefrescarCuentas();
            if (modoEdicion)
            {
                btnCrear.Text = "Guardar";
                btnLimpiar.Enabled = true;
            }
            else
                btnCrear.Text = "Crear";
                btnLimpiar.Enabled = true;
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

        private void RefrescarCuentas()
        {
            using (var db = new ConsultorioDBEntities())
            {
                var consulta = from s in db.usuarios
                               select new
                               {
                                   No_Usuario = s.no_usuario,
                                   Nombres = s.nombres,
                                   Apellidos = s.apellidos,
                                   Usuario = s.usuario1,
                                   Contrasena = s.contrasena,
                                   Role = s.usuario_role
                               };
                dataGridView.DataSource = consulta.ToList();
            }
        }

        //muestra en el formulario los datos de la fila a la que se le dio doble clic
        public void mostrarDatosActualFila()
        {
            tbNombres.Text = this.dataGridView.CurrentRow.Cells["Nombres"].Value.ToString();
            tbApellidos.Text = this.dataGridView.CurrentRow.Cells["Apellidos"].Value.ToString();
            tbUsuario.Text = this.dataGridView.CurrentRow.Cells["Usuario"].Value.ToString();
            tbPassword.Text = this.dataGridView.CurrentRow.Cells["Contrasena"].Value.ToString();
            tbRol.Text = this.dataGridView.CurrentRow.Cells["Role"].Value.ToString();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Validando que los campos no queden vacios
            if (tbNombres.Text == "" || tbApellidos.Text == "" || tbPassword.Text == "" || tbUsuario.Text == "" || tbRol.Text == "")
            {
                MessageBox.Show("Ingrese la informacion");
                return;
            }

            using (var db = new ConsultorioDBEntities())
            {
                if (modoEdicion)
                {
                    var consulta = from s in db.usuarios select s;
                    //Modificando la informacion de la cuenta
                    if (consulta.ToList().Count > 0)
                    {
                        usuario c1 = consulta.FirstOrDefault();
                        c1.nombres = tbNombres.Text;
                        c1.apellidos = tbApellidos.Text;
                        c1.contrasena = tbPassword.Text;
                        //c1.usuario1 = tbUsuario.Text;
                        c1.usuario_role = tbRol.Text;
                        int filasAfectadas = db.SaveChanges();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Se modifico la cuenta.");
                            RefrescarCuentas();
                        }
                        else
                            MessageBox.Show("No se pudo modificar.");
                    }
                    else
                        MessageBox.Show("No se encuentra la informacion");
                }
                else
                {
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
                        RefrescarCuentas();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido agregar el usuario");
                    }
                }
            }
        }

        private void dtvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


