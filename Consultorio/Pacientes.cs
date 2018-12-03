using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Consultorio
{
    public partial class Pacientes : Form
    {
        string nom, apell, rol, user;

        public Pacientes(string nombres, string apellidos, string role, string usuario)
        {
            this.nom = nombres;
            this.apell = apellidos;
            this.rol = role;
            this.user = usuario;

            InitializeComponent();

            ArrayList arregloMedico = new ArrayList();

            using (var db = new ConsultorioDBEntities()) {

                var c_medicos = from m in db.medicos
                                
                                select m;
                             
                foreach ( medico medico in c_medicos)
                {
                    arregloMedico.Add(medico.no_medico);
                }
                
            }

            txtMedico.DataSource = arregloMedico;
        }

        bool revisar_blancos()
        {
            if (
            String.IsNullOrEmpty(txtApellidos.Text) ||
            String.IsNullOrEmpty(txtDireccion.Text) ||
            String.IsNullOrEmpty(txtFecha.Text) ||
            String.IsNullOrEmpty(txtIDPaciente.Text) ||
            String.IsNullOrEmpty(txtInformacion.Text) ||
            String.IsNullOrEmpty(txtMedico.Text) ||
            String.IsNullOrEmpty(txtNombres.Text) ||
            String.IsNullOrEmpty(txtOcupacion.Text) ||
            String.IsNullOrEmpty(txtTelefonos.Text) ||
            String.IsNullOrEmpty(cmbGenero.Text) ||
            String.IsNullOrEmpty(cmbSangre.Text)
            ) return true;
            else
                return false;

            
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

        }

        void limpiar()
        {
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtFecha.Text = null;
            txtIDPaciente.Clear();
            txtInformacion.Clear();
            txtMedico.Text = null;
            txtNombres.Clear();
            txtOcupacion.Clear();
            txtTelefonos.Clear();
            cmbGenero.Text = null;
            cmbSangre.Text = null;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (revisar_blancos() == true)
                {
                    MessageBox.Show("No se permiten campos en blanco");
                    return;
                }

                using (var db = new ConsultorioDBEntities())
                {
                    int med = Int32.Parse(txtMedico.Text);
                    paciente p = new paciente();

                    DateTime date = DateTime.Now;
                    DateTime fechaNacimiento = txtFecha.Value.Date;

                    p.id_paciente = txtIDPaciente.Text;
                    p.nombres = txtNombres.Text;
                    p.apellidos = txtApellidos.Text;
                    p.telefono = txtTelefonos.Text;
                    p.tipo_sangre = cmbSangre.Text;
                    p.genero = cmbGenero.Text;
                    p.ocupacion = txtOcupacion.Text;
                    p.fecha_nacimiento = fechaNacimiento;
                    p.direccion = txtDireccion.Text;
                    p.no_medico = med;
                    p.informacion = txtInformacion.Text;
                    p.usuario_creador = user;
                    p.fecha_hora_creacion = date;
                    db.pacientes.Add(p);
                    
                    int filasAfectadas = db.SaveChanges();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Se registro el paciente exitosamente.");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha registrado el paciente.");
                    }


                };

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
