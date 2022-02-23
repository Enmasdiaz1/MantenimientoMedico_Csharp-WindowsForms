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
    public partial class FrmPruebasLaboratorio: Form
    {
        private Pruebas_LaboratorioBD _pruebas;
        public static int? id;
        public FrmPruebasLaboratorio()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);            
            _pruebas = new Pruebas_LaboratorioBD(connection);
            id = 0;
        }

      
        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }
        private void btnNuevoPruebaLab_Click(object sender, EventArgs e)
        {
            id = 0;
            FrmAgregarPrueba form = new FrmAgregarPrueba();
            form.Show();
            this.Hide();
        }
        private void FrmPruebasLaboratorio_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmInicio form = new FrmInicio();
            form.Show();
            this.Hide();
        }
        public void LoadData()
        {
            DgvPruebasDeLab.DataSource = _pruebas.ObtenerTodo();
            DgvPruebasDeLab.ClearSelection();
        }
        public void Deselect()
        {
            DgvPruebasDeLab.ClearSelection();
            btnDeseleccionar.Visible = false;
            id = null;
        }
        private void FrmPruebasLaboratorio_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void btnEditarPruebaLab_Click(object sender, EventArgs e)
        {
            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Notificacion");
            }
            else
            {
                FrmAgregarPrueba form = new FrmAgregarPrueba();
                form.Show();
                this.Hide();
            }
        }
        private void DgvPruebasDeLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvPruebasDeLab.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeseleccionar.Visible = true;
            }
        }
        private void Eliminar()
        {

            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar una Prueba", "Notificacion");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar esta Prueba?", "Advertencia",
                    MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool result = _pruebas.Eliminar(id.Value);

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
        private void btnEliminarPruebaLab_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
