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
    public partial class FrmCitas: Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            FrmAgregarCita form = new FrmAgregarCita();
            form.Show();
            this.Hide();
        }

        private void FrmCitas_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
