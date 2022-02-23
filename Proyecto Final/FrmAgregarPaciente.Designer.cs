
namespace Proyecto_Final
{
    partial class FrmAgregarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpAgregarMedico = new System.Windows.Forms.TableLayoutPanel();
            this.pboxAgregarPaciente = new System.Windows.Forms.PictureBox();
            this.tlpAgregandotxtYlbl = new System.Windows.Forms.TableLayoutPanel();
            this.lblAgregarMedico = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tlpAgregarBTN = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pboxSubirFoto = new System.Windows.Forms.PictureBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFumador = new System.Windows.Forms.Label();
            this.cbxFumador = new System.Windows.Forms.ComboBox();
            this.lblAlergico = new System.Windows.Forms.Label();
            this.cbxAlergico = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.FotoDialog = new System.Windows.Forms.OpenFileDialog();
            this.tlpAgregarMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarPaciente)).BeginInit();
            this.tlpAgregandotxtYlbl.SuspendLayout();
            this.tlpAgregarBTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubirFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAgregarMedico
            // 
            this.tlpAgregarMedico.ColumnCount = 2;
            this.tlpAgregarMedico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.98851F));
            this.tlpAgregarMedico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.01149F));
            this.tlpAgregarMedico.Controls.Add(this.pboxAgregarPaciente, 0, 0);
            this.tlpAgregarMedico.Controls.Add(this.tlpAgregandotxtYlbl, 1, 0);
            this.tlpAgregarMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgregarMedico.Location = new System.Drawing.Point(0, 0);
            this.tlpAgregarMedico.Name = "tlpAgregarMedico";
            this.tlpAgregarMedico.RowCount = 2;
            this.tlpAgregarMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregarMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregarMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarMedico.Size = new System.Drawing.Size(826, 600);
            this.tlpAgregarMedico.TabIndex = 0;
            // 
            // pboxAgregarPaciente
            // 
            this.pboxAgregarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxAgregarPaciente.Image = global::Proyecto_Final.Properties.Resources.Paciente1;
            this.pboxAgregarPaciente.Location = new System.Drawing.Point(3, 3);
            this.pboxAgregarPaciente.Name = "pboxAgregarPaciente";
            this.tlpAgregarMedico.SetRowSpan(this.pboxAgregarPaciente, 2);
            this.pboxAgregarPaciente.Size = new System.Drawing.Size(349, 594);
            this.pboxAgregarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxAgregarPaciente.TabIndex = 0;
            this.pboxAgregarPaciente.TabStop = false;
            // 
            // tlpAgregandotxtYlbl
            // 
            this.tlpAgregandotxtYlbl.ColumnCount = 3;
            this.tlpAgregandotxtYlbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.511811F));
            this.tlpAgregandotxtYlbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.48819F));
            this.tlpAgregandotxtYlbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblAgregarMedico, 0, 0);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblNombre, 1, 1);
            this.tlpAgregandotxtYlbl.Controls.Add(this.txtNombre, 1, 2);
            this.tlpAgregandotxtYlbl.Controls.Add(this.tlpAgregarBTN, 0, 18);
            this.tlpAgregandotxtYlbl.Controls.Add(this.pboxSubirFoto, 1, 11);
            this.tlpAgregandotxtYlbl.Controls.Add(this.txtDireccion, 1, 6);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblDireccion, 1, 5);
            this.tlpAgregandotxtYlbl.Controls.Add(this.txtApellidos, 2, 4);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblApellidos, 2, 3);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblFechaNacimiento, 2, 11);
            this.tlpAgregandotxtYlbl.Controls.Add(this.txtTelefono, 2, 8);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblTelefono, 2, 7);
            this.tlpAgregandotxtYlbl.Controls.Add(this.txtCedula, 1, 10);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblCedula, 1, 9);
            this.tlpAgregandotxtYlbl.Controls.Add(this.comboBox1, 2, 18);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblFumador, 2, 13);
            this.tlpAgregandotxtYlbl.Controls.Add(this.cbxFumador, 2, 14);
            this.tlpAgregandotxtYlbl.Controls.Add(this.lblAlergico, 2, 15);
            this.tlpAgregandotxtYlbl.Controls.Add(this.cbxAlergico, 2, 16);
            this.tlpAgregandotxtYlbl.Controls.Add(this.dtFecha, 2, 12);
            this.tlpAgregandotxtYlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgregandotxtYlbl.Location = new System.Drawing.Point(358, 3);
            this.tlpAgregandotxtYlbl.Name = "tlpAgregandotxtYlbl";
            this.tlpAgregandotxtYlbl.RowCount = 20;
            this.tlpAgregarMedico.SetRowSpan(this.tlpAgregandotxtYlbl, 2);
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpAgregandotxtYlbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregandotxtYlbl.Size = new System.Drawing.Size(465, 594);
            this.tlpAgregandotxtYlbl.TabIndex = 1;
            // 
            // lblAgregarMedico
            // 
            this.lblAgregarMedico.AutoSize = true;
            this.tlpAgregandotxtYlbl.SetColumnSpan(this.lblAgregarMedico, 3);
            this.lblAgregarMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAgregarMedico.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAgregarMedico.Location = new System.Drawing.Point(3, 0);
            this.lblAgregarMedico.Name = "lblAgregarMedico";
            this.lblAgregarMedico.Size = new System.Drawing.Size(459, 67);
            this.lblAgregarMedico.TabIndex = 2;
            this.lblAgregarMedico.Text = "Mantenimiento Paciente";
            this.lblAgregarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNombre.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(14, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(186, 29);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(14, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 23);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpAgregarBTN
            // 
            this.tlpAgregarBTN.ColumnCount = 2;
            this.tlpAgregandotxtYlbl.SetColumnSpan(this.tlpAgregarBTN, 3);
            this.tlpAgregarBTN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.52941F));
            this.tlpAgregarBTN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.47059F));
            this.tlpAgregarBTN.Controls.Add(this.btnCancelar, 0, 1);
            this.tlpAgregarBTN.Controls.Add(this.btnAceptar, 0, 1);
            this.tlpAgregarBTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgregarBTN.Location = new System.Drawing.Point(3, 537);
            this.tlpAgregarBTN.Name = "tlpAgregarBTN";
            this.tlpAgregarBTN.RowCount = 2;
            this.tlpAgregarBTN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAgregarBTN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpAgregarBTN.Size = new System.Drawing.Size(459, 53);
            this.tlpAgregarBTN.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Haettenschweiler", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.Location = new System.Drawing.Point(225, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(231, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Haettenschweiler", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnAceptar.Location = new System.Drawing.Point(3, 7);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(216, 43);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // pboxSubirFoto
            // 
            this.pboxSubirFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxSubirFoto.Image = global::Proyecto_Final.Properties.Resources.SubirFotoPaciente;
            this.pboxSubirFoto.Location = new System.Drawing.Point(14, 333);
            this.pboxSubirFoto.Name = "pboxSubirFoto";
            this.tlpAgregandotxtYlbl.SetRowSpan(this.pboxSubirFoto, 8);
            this.pboxSubirFoto.Size = new System.Drawing.Size(186, 198);
            this.pboxSubirFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSubirFoto.TabIndex = 15;
            this.pboxSubirFoto.TabStop = false;
            this.pboxSubirFoto.Click += new System.EventHandler(this.pboxSubirFoto_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Black;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(14, 208);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(186, 23);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDireccion.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(14, 178);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(186, 27);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Black;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtApellidos.ForeColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(206, 157);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(256, 23);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblApellidos.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidos.Location = new System.Drawing.Point(206, 121);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(256, 33);
            this.lblApellidos.TabIndex = 9;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(206, 330);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(256, 27);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            this.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Black;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(206, 256);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(256, 23);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTelefono.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(206, 227);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(256, 26);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.Black;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCedula.ForeColor = System.Drawing.Color.White;
            this.txtCedula.Location = new System.Drawing.Point(14, 308);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(186, 23);
            this.txtCedula.TabIndex = 8;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCedula.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCedula.Location = new System.Drawing.Point(14, 279);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(186, 26);
            this.lblCedula.TabIndex = 10;
            this.lblCedula.Text = "Cedula";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Black;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 596);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(4, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // lblFumador
            // 
            this.lblFumador.AutoSize = true;
            this.lblFumador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFumador.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFumador.Location = new System.Drawing.Point(206, 385);
            this.lblFumador.Name = "lblFumador";
            this.lblFumador.Size = new System.Drawing.Size(256, 30);
            this.lblFumador.TabIndex = 3;
            this.lblFumador.Text = "¿Fumador?";
            this.lblFumador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxFumador
            // 
            this.cbxFumador.BackColor = System.Drawing.Color.Black;
            this.cbxFumador.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxFumador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxFumador.ForeColor = System.Drawing.Color.White;
            this.cbxFumador.FormattingEnabled = true;
            this.cbxFumador.Location = new System.Drawing.Point(206, 418);
            this.cbxFumador.Name = "cbxFumador";
            this.cbxFumador.Size = new System.Drawing.Size(256, 23);
            this.cbxFumador.TabIndex = 16;
            // 
            // lblAlergico
            // 
            this.lblAlergico.AutoSize = true;
            this.lblAlergico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAlergico.Font = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlergico.Location = new System.Drawing.Point(206, 443);
            this.lblAlergico.Name = "lblAlergico";
            this.lblAlergico.Size = new System.Drawing.Size(256, 29);
            this.lblAlergico.TabIndex = 3;
            this.lblAlergico.Text = "¿Alergico?";
            this.lblAlergico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxAlergico
            // 
            this.cbxAlergico.BackColor = System.Drawing.Color.Black;
            this.cbxAlergico.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxAlergico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAlergico.ForeColor = System.Drawing.Color.White;
            this.cbxAlergico.FormattingEnabled = true;
            this.cbxAlergico.Location = new System.Drawing.Point(206, 475);
            this.cbxAlergico.Name = "cbxAlergico";
            this.cbxAlergico.Size = new System.Drawing.Size(256, 23);
            this.cbxAlergico.TabIndex = 16;
            // 
            // dtFecha
            // 
            this.dtFecha.AllowDrop = true;
            this.dtFecha.CalendarFont = new System.Drawing.Font("Javanese Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dtFecha.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtFecha.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtFecha.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtFecha.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtFecha.Location = new System.Drawing.Point(206, 360);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(256, 23);
            this.dtFecha.TabIndex = 17;
            // 
            // FotoDialog
            // 
            this.FotoDialog.FileName = "FotoDialog";
            // 
            // FrmAgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(826, 600);
            this.Controls.Add(this.tlpAgregarMedico);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(842, 639);
            this.Name = "FrmAgregarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantanimiento Paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAgregarMedico_FormClosed);
            this.Load += new System.EventHandler(this.FrmAgregarPaciente_Load);
            this.tlpAgregarMedico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarPaciente)).EndInit();
            this.tlpAgregandotxtYlbl.ResumeLayout(false);
            this.tlpAgregandotxtYlbl.PerformLayout();
            this.tlpAgregarBTN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSubirFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAgregarMedico;
        private System.Windows.Forms.PictureBox pboxAgregarPaciente;
        private System.Windows.Forms.TableLayoutPanel tlpAgregandotxtYlbl;
        private System.Windows.Forms.Label lblAgregarMedico;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TableLayoutPanel tlpAgregarBTN;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.PictureBox pboxSubirFoto;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblFumador;
        private System.Windows.Forms.Label lblAlergico;
        private System.Windows.Forms.ComboBox cbxFumador;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbxAlergico;
        private System.Windows.Forms.OpenFileDialog FotoDialog;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}