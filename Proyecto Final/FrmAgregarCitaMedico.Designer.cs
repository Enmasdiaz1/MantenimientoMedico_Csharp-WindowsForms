
namespace Proyecto_Final
{
    partial class FrmAgregarCitaMedico
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
            this.tlpAgregarCitaMedico = new System.Windows.Forms.TableLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscarMedicoPorCedula = new System.Windows.Forms.Button();
            this.DgvMedicosEnCitas = new System.Windows.Forms.DataGridView();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.btnSiguentePaso = new System.Windows.Forms.Button();
            this.lblBuscarMedico = new System.Windows.Forms.Label();
            this.tlpAgregarCitaMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosEnCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAgregarCitaMedico
            // 
            this.tlpAgregarCitaMedico.ColumnCount = 3;
            this.tlpAgregarCitaMedico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.94737F));
            this.tlpAgregarCitaMedico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.05264F));
            this.tlpAgregarCitaMedico.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpAgregarCitaMedico.Controls.Add(this.btnVolver, 0, 4);
            this.tlpAgregarCitaMedico.Controls.Add(this.btnBuscarMedicoPorCedula, 0, 2);
            this.tlpAgregarCitaMedico.Controls.Add(this.DgvMedicosEnCitas, 0, 0);
            this.tlpAgregarCitaMedico.Controls.Add(this.txtBuscarCedula, 1, 1);
            this.tlpAgregarCitaMedico.Controls.Add(this.btnDeseleccionar, 2, 4);
            this.tlpAgregarCitaMedico.Controls.Add(this.btnSiguentePaso, 2, 3);
            this.tlpAgregarCitaMedico.Controls.Add(this.lblBuscarMedico, 2, 0);
            this.tlpAgregarCitaMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgregarCitaMedico.Location = new System.Drawing.Point(0, 0);
            this.tlpAgregarCitaMedico.Name = "tlpAgregarCitaMedico";
            this.tlpAgregarCitaMedico.RowCount = 5;
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.12752F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.87248F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarCitaMedico.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAgregarCitaMedico.Size = new System.Drawing.Size(750, 336);
            this.tlpAgregarCitaMedico.TabIndex = 0;
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
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscarMedicoPorCedula
            // 
            this.btnBuscarMedicoPorCedula.BackColor = System.Drawing.Color.Black;
            this.btnBuscarMedicoPorCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarMedicoPorCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMedicoPorCedula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarMedicoPorCedula.ForeColor = System.Drawing.Color.Chocolate;
            this.btnBuscarMedicoPorCedula.Location = new System.Drawing.Point(532, 115);
            this.btnBuscarMedicoPorCedula.Name = "btnBuscarMedicoPorCedula";
            this.btnBuscarMedicoPorCedula.Size = new System.Drawing.Size(215, 41);
            this.btnBuscarMedicoPorCedula.TabIndex = 5;
            this.btnBuscarMedicoPorCedula.Text = "Buscar Cedula";
            this.btnBuscarMedicoPorCedula.UseVisualStyleBackColor = false;
            // 
            // DgvMedicosEnCitas
            // 
            this.DgvMedicosEnCitas.AllowUserToAddRows = false;
            this.DgvMedicosEnCitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicosEnCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMedicosEnCitas.BackgroundColor = System.Drawing.Color.Black;
            this.DgvMedicosEnCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvMedicosEnCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMedicosEnCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMedicosEnCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpAgregarCitaMedico.SetColumnSpan(this.DgvMedicosEnCitas, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMedicosEnCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMedicosEnCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMedicosEnCitas.GridColor = System.Drawing.Color.Black;
            this.DgvMedicosEnCitas.Location = new System.Drawing.Point(3, 3);
            this.DgvMedicosEnCitas.MultiSelect = false;
            this.DgvMedicosEnCitas.Name = "DgvMedicosEnCitas";
            this.DgvMedicosEnCitas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMedicosEnCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicosEnCitas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tlpAgregarCitaMedico.SetRowSpan(this.DgvMedicosEnCitas, 4);
            this.DgvMedicosEnCitas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvMedicosEnCitas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvMedicosEnCitas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvMedicosEnCitas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicosEnCitas.RowTemplate.Height = 25;
            this.DgvMedicosEnCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicosEnCitas.ShowCellErrors = false;
            this.DgvMedicosEnCitas.ShowCellToolTips = false;
            this.DgvMedicosEnCitas.ShowEditingIcon = false;
            this.DgvMedicosEnCitas.ShowRowErrors = false;
            this.DgvMedicosEnCitas.Size = new System.Drawing.Size(523, 284);
            this.DgvMedicosEnCitas.TabIndex = 2;
            this.DgvMedicosEnCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPacientes_CellContentClick);
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.BackColor = System.Drawing.Color.Black;
            this.txtBuscarCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCedula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBuscarCedula.ForeColor = System.Drawing.Color.White;
            this.txtBuscarCedula.Location = new System.Drawing.Point(532, 86);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(215, 23);
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
            this.btnDeseleccionar.Location = new System.Drawing.Point(532, 293);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(215, 40);
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
            this.btnSiguentePaso.Location = new System.Drawing.Point(532, 242);
            this.btnSiguentePaso.Name = "btnSiguentePaso";
            this.btnSiguentePaso.Size = new System.Drawing.Size(215, 45);
            this.btnSiguentePaso.TabIndex = 9;
            this.btnSiguentePaso.Text = "Siguiente Paso";
            this.btnSiguentePaso.UseVisualStyleBackColor = false;
            this.btnSiguentePaso.Visible = false;
            this.btnSiguentePaso.Click += new System.EventHandler(this.btnSiguentePaso_Click);
            // 
            // lblBuscarMedico
            // 
            this.lblBuscarMedico.AutoSize = true;
            this.lblBuscarMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBuscarMedico.Font = new System.Drawing.Font("Haettenschweiler", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarMedico.Location = new System.Drawing.Point(532, 0);
            this.lblBuscarMedico.Name = "lblBuscarMedico";
            this.lblBuscarMedico.Size = new System.Drawing.Size(215, 78);
            this.lblBuscarMedico.TabIndex = 10;
            this.lblBuscarMedico.Text = "Buscar Medico";
            this.lblBuscarMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAgregarCitaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 336);
            this.Controls.Add(this.tlpAgregarCitaMedico);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAgregarCitaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregando un nuevo Medico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAgregarMedico_FormClosed);
            this.Load += new System.EventHandler(this.FrmAgregarCitaMedico_Load);
            this.tlpAgregarCitaMedico.ResumeLayout(false);
            this.tlpAgregarCitaMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicosEnCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAgregarCitaMedico;
        private System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.DataGridView DgvMedicosEnCitas;
        private System.Windows.Forms.Button btnBuscarMedicoPorCedula;
        private System.Windows.Forms.TextBox txtBuscarCedula;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnSiguentePaso;
        private System.Windows.Forms.Label lblBuscarMedico;
    }
}