using Datos;
using Datos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmPacientes: Form
    {
        private PacientesBD _pacientes;
        public static int? id;
        public FrmPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            id = 0;
            _pacientes = new PacientesBD(connection);
        }

        public void LoadData()
        {
            DgvPacientes.DataSource = _pacientes.ObtenerTodo();
            DgvPacientes.ClearSelection();
        }
        public void Deselect()
        {
            DgvPacientes.ClearSelection();
            btnDeseleccionar.Visible = false;
            id = null;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }

        private void btnNuevoPaciente_Click(object sender, EventArgs e)
        {
            id = 0;
            FrmAgregarPaciente form = new FrmAgregarPaciente();
            form.Show();
            this.Hide();
        }

        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Notificacion");
            }
            else
            {
                FrmAgregarPaciente form = new FrmAgregarPaciente();
                form.Show();
                this.Hide();
            }
        }

        private void FrmPacientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }

        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deselect();
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            
            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Notificacion");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este paciente", "Advertencia",
                    MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool result = _pacientes.Eliminar(id.Value);

                    if (result)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Notificacion");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Ha sucedido un error", "Error");
                    }

                    LoadData();
                    Deselect();
                }

            }

        }

        private void DgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvPacientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeseleccionar.Visible = true;
            }

        }

    }
}
