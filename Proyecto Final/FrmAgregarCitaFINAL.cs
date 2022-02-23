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
    public partial class FrmAgregarCitaFINAL : Form
    {
        public FrmAgregarCitaFINAL()
        {
            InitializeComponent();
        }
        
      

       

       



        

        private void FrmAgregarUsuario_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
            this.Hide();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            FrmCitas form = new FrmCitas();
            form.Show();
            this.Hide();
        }

        private void Validar()
        {
            if (String.IsNullOrEmpty(txtFecha.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Nombre", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtHora.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Apellidos", "ERROR");
            }
            else if (String.IsNullOrEmpty(txtCausadelaCita.Text))
            {
                MessageBox.Show("Debe proporcionarme un valor en el Campo Correo", "ERROR");
            }
            
            



        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Validar();
            MessageBox.Show("SE HA CREADO LA CITA");
        }

        private void FrmAgregarCitaFINAL_Load(object sender, EventArgs e)
        {

        }
    }
}
