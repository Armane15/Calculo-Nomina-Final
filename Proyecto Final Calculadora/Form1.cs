using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Calculadora
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void calculadoraDeSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Este codigo muestra la ventana del Formulario 2, el cual es el calculo de salario.
            frmcalculosalario form2 = new frmcalculosalario();
            form2.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmempleado form3 = new frmempleado();
            form3.Show();
        }

        private void ingresoDeEmpleadoPorProfesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmingresoempleado form4 = new frmingresoempleado();
            form4.Show();
        }
    }
}
