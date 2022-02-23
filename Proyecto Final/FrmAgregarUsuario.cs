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
    public partial class FrmAgregarUsuario : Form
    {
        public int? id;
        public int? selectedIndex;       
        private UsuariosCrud _usuarios;
        public FrmAgregarUsuario()
        {

            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            _usuarios = new UsuariosCrud(connection);
            id = FrmUsuario.id.Value;
        }
        
        private void FrmAgregarUsuario_Load_1(object sender, EventArgs e)
        {
            CargandoCbx();

            if (id.Value > 0)
            {
                LoadEditPersona();
            }
        }       
        private void CargandoCbx()
        {
            #region LLENANDO COMBOBOX 
            LlenandoComboBox opcionDefecto = new LlenandoComboBox
            {
                Texto = "Seleccione",
                Valor = null

            };
            LlenandoComboBox admin = new LlenandoComboBox
            {
                Texto = "Administrador",
                Valor = 1

            };
            LlenandoComboBox medico = new LlenandoComboBox
            {
                Texto = "Medico",
                Valor = 2

            };

            #endregion


            #region ASIGNANDOLE VALOR AL COMBOBOX 
            cbxTipoUsuario.Items.Add(opcionDefecto);
            cbxTipoUsuario.Items.Add(admin);
            cbxTipoUsuario.Items.Add(medico);
            cbxTipoUsuario.SelectedItem = opcionDefecto;
            #endregion
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
            this.Hide();
        }
        public void ClearData()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
            txtPass.Clear();
            txtPass2.Clear();
            txtValidarUsuarioAdmin.Clear();
            selectedIndex = null;
        }
        private void Agregar()
        {          

            if (txtValidarUsuarioAdmin.Visible == true)
            {
                Usuarios user = new Usuarios();
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellidos.Text;
                user.Correo = txtCorreo.Text;
                user.Usuario = txtUsuario.Text;
                user.Contra = txtPass.Text;
                user.Rol = "Administrador";
                user.Id = id.Value;

                bool result = _usuarios.Agregar(user);
                FrmUsuario form = new FrmUsuario();
                
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
            else
            {
                Usuarios user = new Usuarios();
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellidos.Text;
                user.Correo = txtCorreo.Text;
                user.Usuario = txtUsuario.Text;
                user.Contra = txtPass.Text;
                user.Rol = "Medico";
                user.Id = id.Value;


                bool result = _usuarios.Agregar(user);

                if (result)
                {
                    MessageBox.Show("AGREGADO CON EXITO", "Notificacion");

                }
                else
                {
                    MessageBox.Show("ERROR, Algo no anda bien", "Notificacion");
                }

                FrmUsuario form = new FrmUsuario();
                form.LoadData();
                ClearData();
                form.Deselect();

            }


        }
        private void Editar()
        {
            Usuarios usuario = new Usuarios();
            usuario.Id = id.Value;
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellidos.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Usuario = txtUsuario.Text;
            usuario.Contra = txtPass.Text;
            usuario.Contra = txtPass2.Text;
            usuario.Rol = Convert.ToString(cbxTipoUsuario.Text);

            bool result = _usuarios.Editar(usuario);

            if (result)
            {
                FrmUsuario form = new FrmUsuario();
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
            Usuarios usuario = _usuarios.ObtenerporID(id.Value);

            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellido;
            txtCorreo.Text = usuario.Correo;
            txtUsuario.Text = usuario.Usuario;
            txtPass.Text = usuario.Contra;
            cbxTipoUsuario.Text = usuario.Rol;          


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
            else if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Usuario", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Contraseña", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtPass2.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Confirmar Contraseña", "ERROR");
            }
            else if (txtValidarUsuarioAdmin.Visible == true)
            {
                if (String.IsNullOrEmpty(txtValidarUsuarioAdmin.Text))
                {
                    MessageBox.Show("Debe proporcionarme una Clave Admin para ser Administrador", "ERROR");
                }
                else if (txtValidarUsuarioAdmin.Text!= "AMKO-POIU-MNBV" && txtValidarUsuarioAdmin.Text != "QWER-REDS-CVBN" && txtValidarUsuarioAdmin.Text != "QAZX-TGBV-HGFD")
                {                        
                    MessageBox.Show("Debe proporcionarme una Clave Admin CORRECTA para ser Administrador", "ERROR");
                }
                else
                {
                    MessageBox.Show("Clave Admin Correcta", "INFO");
                    Agregar();
                }
                
            }
            else if (cbxTipoUsuario.Text == "Seleccione")
            {

                MessageBox.Show("Debe Seleccionar un tipo de Usuario", "ERROR");
            }            
            else if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Las Contraseñas Deben Ser Iguales", "ERROR");
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
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Validar();
        }
        private void cbxTipoUsuario_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cbxTipoUsuario.Text == "Administrador")
            {

                lblValidadAdmin.Visible = true;
                txtValidarUsuarioAdmin.Visible = true;

            }
            else if (cbxTipoUsuario.Text == "Medico")
            {

                lblValidadAdmin.Visible = false;
                txtValidarUsuarioAdmin.Visible = false;
            }
            else if (!String.IsNullOrEmpty(txtUsuario.Text) || !String.IsNullOrEmpty(txtApellidos.Text))
            {
                
            MessageBox.Show("SE HA AGREGADO CORRECTAMENTE");
            }
        }
        private void FrmAgregarUsuario_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
            this.Hide();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
            this.Hide();
        }

      
    }
}
