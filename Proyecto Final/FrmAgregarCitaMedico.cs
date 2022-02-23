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
    public partial class FrmAgregarCitaMedico : Form
    {
        public FrmAgregarCitaMedico()
        {
            InitializeComponent();
        }

        //private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        //{
        //    CargandoCbx();
        //}


        //#region Login Iniciar Sesion
        //public void Logueo()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand cmd = new SqlCommand("SELECT Nombre_Usuario, Contra FROM Usuarios where Nombre_Usuario ='" + txtTelefono.Text + "' AND Contra ='" + txtCedula.Text + "'", connection))
        //        {
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            if (dr.Read())
        //            {
        //                MessageBox.Show("ESTA LOGUEADO", "Info");
        //            }
        //            else
        //            {
        //                MessageBox.Show("HA OCURRIDO UN ERROR", "ERROR");

        //            }
        //        }
        //    }
        //}
        //#endregion

        //private void CargandoCbx()
        //{
        //    #region LLENANDO COMBOBOX 
        //    LlenandoComboBox opcionDefecto = new LlenandoComboBox
        //    {
        //        Texto = "Seleccione",
        //        Valor = null

        //    };
        //    LlenandoComboBox fumador2 = new LlenandoComboBox
        //    {
        //        Texto = "Si",
        //        Valor = 1

        //    };
        //    LlenandoComboBox fumador3 = new LlenandoComboBox
        //    {
        //        Texto = "No",
        //        Valor = 2

        //    };

        //    #endregion


        //    #region ASIGNANDOLE VALOR AL COMBOBOX 
        //    cbxFumador.Items.Add(opcionDefecto);
        //    cbxFumador.Items.Add(fumador2);
        //    cbxFumador.Items.Add(fumador3);
        //    cbxFumador.SelectedItem = opcionDefecto;
        //    #endregion

        //    #region LLENANDO COMBOBOX 
           
        //    LlenandoComboBox alergico1 = new LlenandoComboBox
        //    {
        //        Texto = "Si",
        //        Valor = 1

        //    };
        //    LlenandoComboBox alergico2 = new LlenandoComboBox
        //    {
        //        Texto = "No",
        //        Valor = 2

        //    };

        //    #endregion


        //    #region ASIGNANDOLE VALOR AL COMBOBOX 
        //    cbxAlergico.Items.Add(opcionDefecto);
        //    cbxAlergico.Items.Add(alergico1);
        //    cbxAlergico.Items.Add(alergico2);
        //    cbxAlergico.SelectedItem = opcionDefecto;
        //    #endregion
        //}
               
     

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
            FrmAgregarCitaFINAL form = new FrmAgregarCitaFINAL();
            form.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmAgregarCita form = new FrmAgregarCita();
            form.Show();
            this.Hide();
        }

        private void FrmAgregarCitaMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
