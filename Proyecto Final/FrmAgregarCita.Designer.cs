
namespace Proyecto_Final
{
    partial class FrmAgregarCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpAgregarNuevaCita = new System.Windows.Forms.TableLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarPacientePorCedula = new System.Windows.Forms.Button();
            this.DgvPacientesEnCitas = new System.Windows.Forms.DataGridView();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.btnSiguentePaso = new System.Windows.Forms.Button();
            this.lblBuscarPaciente = new System.Windows.Forms.Label();
            this.tlpAgregarNuevaCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesEnCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAgregarNuevaCita
            // 
            this.tlpAgregarNuevaCita.ColumnCount = 3;
            this.tlpAgregarNuevaCita.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.94737F));
            this.tlpAgregarNuevaCita.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tlpAgregarNuevaCita.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tlpAgregarNuevaCita.Controls.Add(this.btnVolver, 0, 4);
            this.tlpAgregarNuevaCita.Controls.Add(this.btnBuscarPacientePorCedula, 0, 2);
            this.tlpAgregarNuevaCita.Controls.Add(this.DgvPacientesEnCitas, 0, 0);
            this.tlpAgregarNuevaCita.Controls.Add(this.txtBuscarCedula, 1, 1);
            this.tlpAgregarNuevaCita.Controls.Add(this.btnDeseleccionar, 2, 4);
            this.tlpAgregarNuevaCita.Controls.Add(this.btnSiguentePaso, 2, 3);
            this.tlpAgregarNuevaCita.Controls.Add(this.lblBuscarPaciente, 2, 0);
            this.tlpAgregarNuevaCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgregarNuevaCita.Location = new System.Drawing.Point(0, 0);
            this.tlpAgregarNuevaCita.Name = "tlpAgregarNuevaCita";
            this.tlpAgregarNuevaCita.RowCount = 5;
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.12752F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.87248F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarNuevaCita.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarNuevaCita.Size = new System.Drawing.Size(750, 336);
            this.tlpAgregarNuevaCita.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.Chocolate;
            this.btnVolver.Location = new System.Drawing.Point(3, 293);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(147, 40);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscarPacientePorCedula
            // 
            this.btnBuscarPacientePorCedula.BackColor = System.Drawing.Color.Black;
            this.btnBuscarPacientePorCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarPacientePorCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPacientePorCedula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarPacientePorCedula.ForeColor = System.Drawing.Color.Chocolate;
            this.btnBuscarPacientePorCedula.Location = new System.Drawing.Point(533, 115);
            this.btnBuscarPacientePorCedula.Name = "btnBuscarPacientePorCedula";
            this.btnBuscarPacientePorCedula.Size = new System.Drawing.Size(214, 41);
            this.btnBuscarPacientePorCedula.TabIndex = 5;
            this.btnBuscarPacientePorCedula.Text = "Buscar Cedula";
            this.btnBuscarPacientePorCedula.UseVisualStyleBackColor = false;
            // 
            // DgvPacientesEnCitas
            // 
            this.DgvPacientesEnCitas.AllowUserToAddRows = false;
            this.DgvPacientesEnCitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPacientesEnCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPacientesEnCitas.BackgroundColor = System.Drawing.Color.Black;
            this.DgvPacientesEnCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPacientesEnCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPacientesEnCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPacientesEnCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpAgregarNuevaCita.SetColumnSpan(this.DgvPacientesEnCitas, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPacientesEnCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvPacientesEnCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPacientesEnCitas.GridColor = System.Drawing.Color.Black;
            this.DgvPacientesEnCitas.Location = new System.Drawing.Point(3, 3);
            this.DgvPacientesEnCitas.MultiSelect = false;
            this.DgvPacientesEnCitas.Name = "DgvPacientesEnCitas";
            this.DgvPacientesEnCitas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPacientesEnCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPacientesEnCitas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tlpAgregarNuevaCita.SetRowSpan(this.DgvPacientesEnCitas, 4);
            this.DgvPacientesEnCitas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvPacientesEnCitas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvPacientesEnCitas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvPacientesEnCitas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPacientesEnCitas.RowTemplate.Height = 25;
            this.DgvPacientesEnCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPacientesEnCitas.ShowCellErrors = false;
            this.DgvPacientesEnCitas.ShowCellToolTips = false;
            this.DgvPacientesEnCitas.ShowEditingIcon = false;
            this.DgvPacientesEnCitas.ShowRowErrors = false;
            this.DgvPacientesEnCitas.Size = new System.Drawing.Size(524, 284);
            this.DgvPacientesEnCitas.TabIndex = 2;
            this.DgvPacientesEnCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientes_CellContentClick);
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.BackColor = System.Drawing.Color.Black;
            this.txtBuscarCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCedula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBuscarCedula.ForeColor = System.Drawing.Color.White;
            this.txtBuscarCedula.Location = new System.Drawing.Point(533, 86);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(214, 23);
            this.txtBuscarCedula.TabIndex = 6;
            this.txtBuscarCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.Black;
            this.btnDeseleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDeseleccionar.Location = new System.Drawing.Point(533, 293);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(214, 40);
            this.btnDeseleccionar.TabIndex = 7;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Visible = false;
            // 
            // btnSiguentePaso
            // 
            this.btnSiguentePaso.BackColor = System.Drawing.Color.Black;
            this.btnSiguentePaso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSiguentePaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguentePaso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguentePaso.ForeColor = System.Drawing.Color.Chocolate;
            this.btnSiguentePaso.Location = new System.Drawing.Point(533, 242);
            this.btnSiguentePaso.Name = "btnSiguentePaso";
            this.btnSiguentePaso.Size = new System.Drawing.Size(214, 45);
            this.btnSiguentePaso.TabIndex = 9;
            this.btnSiguentePaso.Text = "Siguiente Paso";
            this.btnSiguentePaso.UseVisualStyleBackColor = false;
            this.btnSiguentePaso.Visible = false;
            this.btnSiguentePaso.Click += new System.EventHandler(this.btnSiguentePaso_Click);
            // 
            // lblBuscarPaciente
            // 
            this.lblBuscarPaciente.AutoSize = true;
            this.lblBuscarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscarPaciente.Font = new System.Drawing.Font("Haettenschweiler", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarPaciente.Location = new System.Drawing.Point(533, 0);
            this.lblBuscarPaciente.Name = "lblBuscarPaciente";
            this.lblBuscarPaciente.Size = new System.Drawing.Size(214, 78);
            this.lblBuscarPaciente.TabIndex = 10;
            this.lblBuscarPaciente.Text = "Buscar Paciente";
            this.lblBuscarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 336);
            this.Controls.Add(this.tlpAgregarNuevaCita);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAgregarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregando un nueva Cita";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAgregarMedico_FormClosed);
            this.Load += new System.EventHandler(this.FrmAgregarCita_Load);
            this.tlpAgregarNuevaCita.ResumeLayout(false);
            this.tlpAgregarNuevaCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPacientesEnCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAgregarNuevaCita;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.DataGridView DgvPacientesEnCitas;
        private System.Windows.Forms.Button btnBuscarPacientePorCedula;
        private System.Windows.Forms.TextBox txtBuscarCedula;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnSiguentePaso;
        private System.Windows.Forms.Label lblBuscarPaciente;
        private System.Windows.Forms.Button btnVolver;
    }
}