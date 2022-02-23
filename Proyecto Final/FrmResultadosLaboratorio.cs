using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmResultadosLaboratorio : Form
    {
        public FrmResultadosLaboratorio()
        {
            InitializeComponent();
        }

        private void tlpUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }

        private void FrmResultadosLaboratorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }

        private void btnReportarResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
