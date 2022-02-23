using Correo;
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
    public partial class FrmUsuario : Form
    {

        private UsuariosBD _usuarios;
        public static int? id;

        public FrmUsuario()
        {            
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _usuarios = new UsuariosBD(connection);
            id = 0;
        }
            
       

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            id = 0;
            FrmAgregarUsuario form = new FrmAgregarUsuario();
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
            DgvUsuarios.DataSource = _usuarios.ObtenerTodo();
            DgvUsuarios.ClearSelection();
            btnEditarUsuario.Visible = false;
        }
        public void Deselect()
        {
            DgvUsuarios.ClearSelection();
            btnDeseleccionar.Visible = false;
            id = null;
           
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Notificacion");
            }
            else
            {
                FrmAgregarUsuario form = new FrmAgregarUsuario();
                form.Show();
                this.Hide();
            }
           
        }
        private void btnDeseleccionar_Click(object sender, EventArgs e)
        {
            Deselect();
        }
        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnDeseleccionar.Visible = true;
                btnEditarUsuario.Visible = true;
            }
        }
        private void Eliminar()
        {

            if (id.Value < 0)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Notificacion");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea eliminar este Usuario?", "Advertencia",
                    MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool result = _usuarios.Eliminar(id.Value);

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
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
