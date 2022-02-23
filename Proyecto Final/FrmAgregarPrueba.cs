using Correo;
using Datos;
using Datos.Modelos;
using Logica;
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
    public partial class FrmAgregarPrueba : Form
    {
        public int? id;
        public int? selectedIndex;
        private Pruebas_LaboratorioBD _pruebas;

        public FrmAgregarPrueba()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _pruebas = new Pruebas_LaboratorioBD(connection);
            id = FrmPruebasLaboratorio.id.Value;

        }


        private void Validar()
        {
            if (String.IsNullOrEmpty(txtNombrePrueba.Text))
            {
                MessageBox.Show("Debe Proporcinarme un Nombre para la Prueba", "ERROR");
            }
            else 
            {
                if (id.Value== 0)
                {
                    Agregar();
                }

                else
                {
                    Editar();
                }
                
            }
        }
        public void ClearData()
        {
            txtNombrePrueba.Clear();
            selectedIndex = null;
        }
        private void Agregar()
        {
            Pruebas_Laboratorio prueba = new Pruebas_Laboratorio();
            prueba.Nombre = txtNombrePrueba.Text;
            prueba.Id = id.Value;

            bool result = _pruebas.Agregar(prueba);
            FrmPruebasLaboratorio form = new FrmPruebasLaboratorio();

            
            if (result)
            {
                MessageBox.Show("AGREGADO CON EXITO", "Notificacion");
                form.LoadData();
                ClearData();
                form.Deselect();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR, Algo no anda bien", "Notificacion");
            }

           
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Validar();            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmPruebasLaboratorio form = new FrmPruebasLaboratorio();
            form.Show();
            this.Hide();
        }
        private void FrmAgregarPrueba_Load(object sender, EventArgs e)
        {
            if (id.Value > 0)
            {
                LoadEditPersona();
            }
        }
        private void Editar()
        {
            FrmPruebasLaboratorio form = new FrmPruebasLaboratorio();
            Pruebas_Laboratorio usuario = new Pruebas_Laboratorio();
            usuario.Id = id.Value;
            usuario.Nombre = txtNombrePrueba.Text;

            bool result = _pruebas.Editar(usuario);

            if (result)
            {
                MessageBox.Show("Editado CON EXITO", "Notificacion");
                form.LoadData();
                ClearData();
                form.Deselect();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ERROR, Algo no anda bien", "Notificacion");
            }


        }
        private void LoadEditPersona()
        {
            Pruebas_Laboratorio prueba = _pruebas.ObtenerporID(id.Value);

            txtNombrePrueba.Text = prueba.Nombre;

        }
    }
}
