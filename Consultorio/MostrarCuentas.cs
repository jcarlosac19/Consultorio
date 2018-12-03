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
    public partial class MostrarCuentas : Form
    {
        public MostrarCuentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users formU = new Users(this.dtvCuentas, false);
            formU.ShowDialog();
        }

        private void MostrarCuentas_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }


        //ocurre cuando se le da doble clic a una fila de la tabla de alumnos
        private void dtvCuentas_DoubleClick(object sender, EventArgs e)
        {
            Users Cuentas = new Users(this.dtvCuentas, true);
            Cuentas.mostrarDatosActualFila();
            Cuentas.ShowDialog();
        }
    }
    }

