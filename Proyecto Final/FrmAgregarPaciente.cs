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
    public partial class FrmAgregarPaciente : Form
    {

        public int? id;
        public int? selectedIndex;
        private PacientesBD _pacientes;
        private string _filename;
        public FrmAgregarPaciente()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _pacientes = new PacientesBD(connection);
            _filename = "";
            id = FrmPacientes.id.Value;
      
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
                int _id = id.Value == 0 ? _pacientes.UltimoId() : id.Value;


                string directory = @"Imagenes\Pacientes\" + _id + "\\";

                string[] fileNameSplit = _filename.Split('\\');
                string filename = fileNameSplit[(fileNameSplit.Length - 1)];

                CreateDirectory(directory);

                string destination = directory + filename;

                File.Copy(_filename, destination, true);

                _pacientes.GuardarFoto(_id, destination);
            }


        }
        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
        private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        {
            CargandoCbx();

            if (id.Value>0)
            {
                LoadEditPersona();
            }

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
            else if (String.IsNullOrEmpty(txtDireccion.Text))
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
            else if (String.IsNullOrEmpty(dtFecha.Text))
            {
                MessageBox.Show("Debe proporcionarme una Fecha", "ERROR");
            }
            else if (cbxFumador.Text == "Seleccione")
            {
                MessageBox.Show("Debe Seleccionar si es Fumador", "ERROR");
            }
            else if (cbxAlergico.Text == "Seleccione")
            {
                MessageBox.Show("Debe Seleccionar si es Alergico", "ERROR");
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
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            pboxSubirFoto.Image = pboxSubirFoto.Image;
            selectedIndex = null;
        }
        private void Agregar()
        {
            FrmPacientes form = new FrmPacientes();
            Pacientes paciente = new Pacientes();
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellidos.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Fecha_Nacimiento = dtFecha.Value;
            paciente.Fumador = Convert.ToString(cbxFumador.Text);
            paciente.Alergias = Convert.ToString(cbxAlergico.Text);

            bool result = _pacientes.Agregar(paciente);
            SavePhoto();

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
        private void Editar()
        {
            FrmPacientes form = new FrmPacientes();
            Pacientes paciente = new Pacientes();
            paciente.Id = id.Value;
            paciente.Nombre = txtNombre.Text;
            paciente.Apellido = txtApellidos.Text;
            paciente.Direccion = txtDireccion.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Cedula = txtCedula.Text;
            paciente.Fecha_Nacimiento = dtFecha.Value;
            paciente.Fumador = Convert.ToString(cbxFumador.Text);
            paciente.Alergias = Convert.ToString(cbxAlergico.Text);

            bool result = _pacientes.Editar(paciente);
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
        private void LoadEditPersona()
        {
            Pacientes pacientes = _pacientes.ObtenerporID(id.Value);

            txtNombre.Text = pacientes.Nombre;
            txtApellidos.Text = pacientes.Apellido;
            txtDireccion.Text = pacientes.Direccion;
            txtTelefono.Text = pacientes.Telefono;
            txtCedula.Text = pacientes.Cedula;
            dtFecha.Value = pacientes.Fecha_Nacimiento;
            cbxFumador.Text = pacientes.Fumador;
            cbxAlergico.Text = pacientes.Alergias;

            if (pacientes.Foto == "No hay foto")
            {
                pboxSubirFoto.Image = pboxSubirFoto.Image;
            }

            else
            {
                pboxSubirFoto.ImageLocation = pacientes.Foto;
            }
            

        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Validar();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            FrmPacientes form = new FrmPacientes    ();
            form.Show();
            this.Hide();
        }
        private void FrmAgregarMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPacientes form = new FrmPacientes();
            form.Show();
            this.Hide();
        }
        private void pboxSubirFoto_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }
        private void CargandoCbx()
        {
            #region LLENANDO COMBOBOX 
            LlenandoComboBox opcionDefecto = new LlenandoComboBox
            {
                Texto = "Seleccione",
                Valor = null

            };
            LlenandoComboBox fumador2 = new LlenandoComboBox
            {
                Texto = "Si",
                Valor = 1

            };
            LlenandoComboBox fumador3 = new LlenandoComboBox
            {
                Texto = "No",
                Valor = 2

            };

            #endregion


            #region ASIGNANDOLE VALOR AL COMBOBOX 
            cbxFumador.Items.Add(opcionDefecto);
            cbxFumador.Items.Add(fumador2);
            cbxFumador.Items.Add(fumador3);
            cbxFumador.SelectedItem = opcionDefecto;
            #endregion

            #region LLENANDO COMBOBOX 

            LlenandoComboBox alergico1 = new LlenandoComboBox
            {
                Texto = "Si",
                Valor = 1

            };
            LlenandoComboBox alergico2 = new LlenandoComboBox
            {
                Texto = "No",
                Valor = 2

            };

            #endregion


            #region ASIGNANDOLE VALOR AL COMBOBOX 
            cbxAlergico.Items.Add(opcionDefecto);
            cbxAlergico.Items.Add(alergico1);
            cbxAlergico.Items.Add(alergico2);
            cbxAlergico.SelectedItem = opcionDefecto;
            #endregion
        }
    }
}
