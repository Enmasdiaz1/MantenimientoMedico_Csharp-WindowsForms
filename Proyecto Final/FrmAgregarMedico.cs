using Datos;
using Datos.Modelos;
using Proyecto_Final.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class FrmAgregarMedico : Form
    {
        public int? id;
        public int? selectedIndex;
        private MedicosBD _medicos;
        private string _filename;
        public FrmAgregarMedico()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _medicos = new MedicosBD(connection);
            _filename = "";
            id = FrmMedicos.id.Value;

        }

        private void AddPhoto()
        {
            DialogResult result = FotoDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = FotoDialog.FileName;

                _filename = file;

                pboxSubirFoto.ImageLocation = file;
            }
        }
        private void SavePhoto()
        {
            if (!string.IsNullOrEmpty(_filename))
            {
                int _id = id.Value == 0 ? _medicos.UltimoId() : id.Value;


                string directory = @"Imagenes\Medicos\" + _id + "\\";

                string[] fileNameSplit = _filename.Split('\\');
                string filename = fileNameSplit[(fileNameSplit.Length - 1)];

                CreateDirectory(directory);

                string destination = directory + filename;

                File.Copy(_filename, destination, true);

                _medicos.GuardarFoto(_id, destination);
            }


        }
        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }





        private void FrmAgregarMedico_Load(object sender, EventArgs e)
        {
            if (id.Value > 0)
            {
                LoadEditPersona();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
            this.Hide();
        }
        private void Validar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Nombre", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Apellidos", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Correo", "ERROR");
            }
            else if (!txtTelefono.MaskCompleted)
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Telefono", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Cedula", "ERROR");
            }
            else if (pboxAgregarMedico.Image==null)
            {
                MessageBox.Show("Debe Subir una Foto de Perfil", "ERROR");
            }
            else
            {
                if (id.Value == 0)
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
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            pboxSubirFoto.Image = pboxSubirFoto.Image;
            selectedIndex = null;
        }
        private void Agregar()
        {
            Medicos medicos = new Medicos();
            medicos.Nombre = txtNombre.Text;
            medicos.Apellido = txtApellidos.Text;
            medicos.Correo = txtCorreo.Text;
            medicos.Telefono = txtTelefono.Text;
            medicos.Cedula = txtCedula.Text;

            bool result = _medicos.Agregar(medicos);
            SavePhoto();

            

            if (result)
            {
                FrmMedicos form = new FrmMedicos();

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
        private void Editar()
        {
            FrmMedicos form = new FrmMedicos();
            Medicos medicos = new Medicos();
            medicos.Id = id.Value;
            medicos.Nombre = txtNombre.Text;
            medicos.Apellido = txtApellidos.Text;
            medicos.Correo = txtCorreo.Text;
            medicos.Telefono = txtTelefono.Text;
            medicos.Cedula = txtCedula.Text;

            bool result = _medicos.Editar(medicos);
            SavePhoto();

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
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Validar();            
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
        private void LoadEditPersona()
        {
            Medicos medicos = _medicos.ObtenerporID(id.Value);

            txtNombre.Text = medicos.Nombre;
            txtApellidos.Text = medicos.Apellido;
            txtCorreo.Text = medicos.Correo;
            txtTelefono.Text = medicos.Telefono;
            txtTelefono.Text = medicos.Telefono;
            txtCedula.Text = medicos.Cedula;

            if (medicos.Foto == "No hay foto")
            {
                pboxSubirFoto.Image = pboxSubirFoto.Image;
            }

            else
            {
                pboxSubirFoto.ImageLocation = medicos.Foto;
            }


        }
        private void pboxSubirFoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }
    }
}
