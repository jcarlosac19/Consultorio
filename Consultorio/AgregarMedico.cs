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
    public partial class AgregarMedico : Form
    {
        DataGridView dtvMedicos;
        bool modo_;

        public AgregarMedico(DataGridView dtMedico, bool modo)
        {
            this.dtvMedicos = dtMedico;
            this.modo_ = modo;
            InitializeComponent();

            ArrayList arregloUsuario = new ArrayList();

            using (var db = new ConsultorioDBEntities())
            {

                var users = from m in db.usuarios
                                where m.usuario_role == "Medico"
                                select m;

                foreach (usuario usuario in users)
                {
                    arregloUsuario.Add(usuario.usuario1);
                }

            }

            cmbUsuario.DataSource = arregloUsuario;
        }
        bool revisar_blancos()
        {
            if (
                String.IsNullOrEmpty(txtEspecialidad.Text) ||
                String.IsNullOrEmpty(cmbGenero.Text) ||
                String.IsNullOrEmpty(cmbUsuario.Text) ||
                String.IsNullOrEmpty(dtpFechaNacimiento.Text)
               ) return true;
            else
                return false;
        }

        bool existe()
        {
            using (var db = new ConsultorioDBEntities())
            {
                var consulta = from s in db.medicos
                               where s.usuario_medico == cmbUsuario.Text
                               select s;
                if (consulta.ToList().Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            };

        }
        void refrescar()
        {

            using (var db = new ConsultorioDBEntities())
            {
                //LINQ
                var consulta = from s in db.medicos
                                   //where s.carrera == "Informatica"
                                   //orderby s.nombres ascending
                               select new
                               {
                                   No_Medico = s.no_medico,
                                   Usuario = s.usuario_medico,
                                   Especialidad = s.especialidad,
                                   Nacimiento = s.fecha_nacimiento,
                                   Genero = s.genero
                               };
                dtvMedicos.DataSource = consulta.ToList();
            }
        }
    

        public void mostrarDatosActualFila()
        {
            cmbUsuario.Text = this.dtvMedicos.CurrentRow.Cells["Usuario"].Value.ToString();
            txtEspecialidad.Text = this.dtvMedicos.CurrentRow.Cells["Especialidad"].Value.ToString();
            dtpFechaNacimiento.Value =DateTime.Parse(this.dtvMedicos.CurrentRow.Cells["Nacimiento"].Value.ToString());
            cmbGenero.Text = this.dtvMedicos.CurrentRow.Cells["Genero"].Value.ToString();

        }

        //Incia programacion para guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (revisar_blancos())
                {
                    MessageBox.Show("No se permiten campos en blanco");
                    return;
                }

                using (var db = new ConsultorioDBEntities())
                {
                    if (!modo_)
                    {
                        if (existe())
                        {
                            MessageBox.Show("El medico ya existe, intente con otro usuario.");
                            return;
                        }

                        medico m = new medico();

                        m.usuario_medico = cmbUsuario.Text;
                        m.especialidad = txtEspecialidad.Text;
                        m.fecha_nacimiento = dtpFechaNacimiento.Value;
                        m.genero = cmbGenero.Text;

                        db.medicos.Add(m);

                        int filasAfectadas = db.SaveChanges();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El medico fue agregado exitosamente");
                            refrescar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el medico");
                        }
                    }
                    else
                    {
                        //Programacion modificar

                        var consulta = from s in db.medicos
                                       where s.usuario_medico == cmbUsuario.Text
                                       select s;
                        if (consulta.ToList().Count > 0)
                        {
                            medico med = consulta.FirstOrDefault();
                            med.usuario_medico = cmbUsuario.Text;
                            med.especialidad = txtEspecialidad.Text;
                            med.fecha_nacimiento = dtpFechaNacimiento.Value;
                            med.genero = cmbGenero.Text;

                            int filasAfectadas = db.SaveChanges();
                            if (filasAfectadas > 0)
                            {

                                refrescar();
                                MessageBox.Show("Alumno modificado exitosamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar.");
                            }


                            //Termina programacion modificar
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbUsuario.Text = null;
            txtEspecialidad.Clear();
            dtpFechaNacimiento.Text = null;
            cmbGenero.Text = null;
        }
    }
        //Termina programacion de guardar
    }

