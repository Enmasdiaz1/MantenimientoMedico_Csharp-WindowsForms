using Datos;
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
    public partial class FrmMedicos : Form
    {
        private MedicosBD _medicos;
        public static int? id;
        public FrmMedicos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            id = 0;
            _medicos = new MedicosBD(connection);
        }
        private void btnNuevoMedico_Click(object sender, EventArgs e)
        {
            id = 0;
            FrmAgregarMedico form = new FrmAgregarMedico();
            form.Show();
            this.Hide();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }
        public void LoadData()
        {
            DgvMedicos.DataSource = _medicos.ObtenerTodo();
            DgvMedicos.ClearSelection();
        }
        public void Deselect()
        {
            DgvMedicos.ClearSelection();
            btnDeseleccionar.Visible = false;
            id = null;
        }        
        private void FrmMedicos_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FrmMedicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }       
        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void btnEditarMedico_Click(object sender, EventArgs e)
        {
            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Notificacion");
            }
            else
            {
                FrmAgregarMedico form = new FrmAgregarMedico();
                form.Show();
                this.Hide();
            }

        }
        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {

            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un Medicos", "Notificacion");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este Medico?", "Advertencia",
                    MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool result = _medicos.Eliminar(id.Value);

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
        private void DgvMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeseleccionar.Visible = true;
            }
        }
    }
}
