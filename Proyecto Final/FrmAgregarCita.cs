using Proyecto_Final.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmAgregarCita : Form
    {
        public FrmAgregarCita()
        {
            InitializeComponent();
        }

       

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            FrmMedicos form = new FrmMedicos();
            form.Show();
            this.Hide();
        }

        private void FrmAgregarMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMedicos form = new FrmMedicos();
            form.Show();
            this.Hide();
        }

        private void DgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSiguentePaso_Click(object sender, EventArgs e)
        {
            FrmAgregarCitaMedico form = new FrmAgregarCitaMedico();
            form.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmCitas form = new FrmCitas();
            form.Show();
            this.Hide();
        }

        private void FrmAgregarCita_Load(object sender, EventArgs e)
        {

        }
    }
}
