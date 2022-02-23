using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void lblMedico_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUsuario form = new FrmUsuario();
            form.Show();
            this.Hide();
        }

        private void mantenimientoDeMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicos form = new FrmMedicos();
            form.Show();
            this.Hide();
        }

        private void mantenimientoDePruebasDeLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPruebasLaboratorio form = new FrmPruebasLaboratorio();
            form.Show();
            this.Hide();
        }

        private void mantenimientoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPacientes form = new FrmPacientes();
            form.Show();
            this.Hide();
        }

        private void mantenimientoDeCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCitas form = new FrmCitas();
            form.Show();
            this.Hide();
        }

        private void mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResultadosLaboratorio form = new FrmResultadosLaboratorio();
            form.Show();
            this.Hide();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

    }
}
