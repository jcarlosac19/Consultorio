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
    public partial class ListaPacientes : Form
    {
        public ListaPacientes()
        {
            InitializeComponent();

            using (var db = new ConsultorioDBEntities())
            {
                var consulta = from s in db.pacientes

                               select new
                               {
                                   ID = s.id_paciente,
                                   Nombres = s.nombres,
                                   Apellidos = s.apellidos,
                                   Telefono = s.telefono,
                                   Tipo_Sangre = s.tipo_sangre,
                                   Genero = s.genero,
                                   Ocupacion = s.ocupacion,
                                   Fecha_Nacimiento = s.fecha_nacimiento,
                                   Direccion = s.direccion,
                                   Medico = s.no_medico,
                                   Informacion = s.informacion,
                               };
                dtvPacientes.DataSource = consulta.ToList();
            }
        }

        private void dtvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
