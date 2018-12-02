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
    public partial class Pacientes : Form
    {
        String nom, apell, rol, user;

        public Pacientes(String nombres, String apellidos, String role, String usuario)
        {
            this.nom = nombres;
            this.apell = apellidos;
            this.rol = role;
            this.user = usuario;

            InitializeComponent();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var db = new ConsultorioDBEntities())
            {
                paciente p = new paciente();

                p.id_paciente = txtIDPaciente.Text;
                p.nombres = txtNombres.Text;
                p.apellidos = txtApellidos.Text;
                p.telefono = txtTelefonos.Text;
                p.tipo_sangre = cmbSangre.Text;
                p.genero = cmbGenero.Text;
                p.ocupacion = txtOcupacion.Text;
                p.fecha_nacimiento = txtFecha.Value;
                p.direccion = txtDireccion.Text;
                p.no_medico = Int32.Parse(txtMedico.Text);
                p.informacion = txtInformacion.Text;
                p.usuario_creador = user;
                p.fecha_hora_creacion = new DateTime();
                db.pacientes.Add(p);
                db.SaveChanges();

            };

        }
    }
}
