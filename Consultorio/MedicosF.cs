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
    public partial class MedicosF : Form
    {
        public MedicosF()
        {
            InitializeComponent();

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
                dtMedico.DataSource = consulta.ToList();
                }
            }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMedico am = new AgregarMedico(dtMedico, false);

            am.ShowDialog();

        }
        
        private void dtMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgregarMedico am = new AgregarMedico(dtMedico, true);
            am.mostrarDatosActualFila();
            am.ShowDialog();

        }
    }
    }
