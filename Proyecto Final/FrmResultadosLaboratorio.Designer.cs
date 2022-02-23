
namespace Proyecto_Final
{
    partial class FrmResultadosLaboratorio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.DgvResultadosLab = new System.Windows.Forms.DataGridView();
            this.tlpResultadosPendientes = new System.Windows.Forms.TableLayoutPanel();
            this.btnReportarResultado = new System.Windows.Forms.Button();
            this.btnBuscarUsuarioPorCedula = new System.Windows.Forms.Button();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.lblListadoResultadoLab = new System.Windows.Forms.Label();
            this.tlpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultadosLab)).BeginInit();
            this.tlpResultadosPendientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 3;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.24799F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.75201F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tlpUsuarios.Controls.Add(this.btnVolver, 0, 2);
            this.tlpUsuarios.Controls.Add(this.DgvResultadosLab, 0, 1);
            this.tlpUsuarios.Controls.Add(this.tlpResultadosPendientes, 2, 1);
            this.tlpUsuarios.Controls.Add(this.btnDeseleccionar, 2, 2);
            this.tlpUsuarios.Controls.Add(this.lblListadoResultadoLab, 0, 0);
            this.tlpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 3;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.73094F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.26906F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpUsuarios.Size = new System.Drawing.Size(800, 446);
            this.tlpUsuarios.TabIndex = 0;
            this.tlpUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpUsuarios_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.Chocolate;
            this.btnVolver.Location = new System.Drawing.Point(3, 398);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(148, 45);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DgvResultadosLab
            // 
            this.DgvResultadosLab.AllowUserToAddRows = false;
            this.DgvResultadosLab.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvResultadosLab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvResultadosLab.BackgroundColor = System.Drawing.Color.Black;
            this.DgvResultadosLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvResultadosLab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvResultadosLab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvResultadosLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpUsuarios.SetColumnSpan(this.DgvResultadosLab, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvResultadosLab.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvResultadosLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResultadosLab.GridColor = System.Drawing.Color.Black;
            this.DgvResultadosLab.Location = new System.Drawing.Point(3, 81);
            this.DgvResultadosLab.MultiSelect = false;
            this.DgvResultadosLab.Name = "DgvResultadosLab";
            this.DgvResultadosLab.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvResultadosLab.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvResultadosLab.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvResultadosLab.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvResultadosLab.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvResultadosLab.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvResultadosLab.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvResultadosLab.RowTemplate.Height = 25;
            this.DgvResultadosLab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvResultadosLab.ShowCellErrors = false;
            this.DgvResultadosLab.ShowCellToolTips = false;
            this.DgvResultadosLab.ShowEditingIcon = false;
            this.DgvResultadosLab.ShowRowErrors = false;
            this.DgvResultadosLab.Size = new System.Drawing.Size(580, 311);
            this.DgvResultadosLab.TabIndex = 1;
            // 
            // tlpResultadosPendientes
            // 
            this.tlpResultadosPendientes.ColumnCount = 1;
            this.tlpResultadosPendientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpResultadosPendientes.Controls.Add(this.btnReportarResultado, 0, 3);
            this.tlpResultadosPendientes.Controls.Add(this.btnBuscarUsuarioPorCedula, 0, 2);
            this.tlpResultadosPendientes.Controls.Add(this.txtBuscarCedula, 0, 0);
            this.tlpResultadosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResultadosPendientes.Location = new System.Drawing.Point(589, 81);
            this.tlpResultadosPendientes.Name = "tlpResultadosPendientes";
            this.tlpResultadosPendientes.RowCount = 6;
            this.tlpResultadosPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tlpResultadosPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpResultadosPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpResultadosPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpResultadosPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpResultadosPendientes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpResultadosPendientes.Size = new System.Drawing.Size(208, 311);
            this.tlpResultadosPendientes.TabIndex = 2;
            this.tlpResultadosPendientes.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnReportarResultado
            // 
            this.btnReportarResultado.BackColor = System.Drawing.Color.Black;
            this.btnReportarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportarResultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReportarResultado.ForeColor = System.Drawing.Color.Chocolate;
            this.btnReportarResultado.Location = new System.Drawing.Point(3, 166);
            this.btnReportarResultado.Name = "btnReportarResultado";
            this.btnReportarResultado.Size = new System.Drawing.Size(190, 48);
            this.btnReportarResultado.TabIndex = 2;
            this.btnReportarResultado.Text = "Reportar Resultado";
            this.btnReportarResultado.UseVisualStyleBackColor = false;
            this.btnReportarResultado.Visible = false;
            this.btnReportarResultado.Click += new System.EventHandler(this.btnReportarResultado_Click);
            // 
            // btnBuscarUsuarioPorCedula
            // 
            this.btnBuscarUsuarioPorCedula.BackColor = System.Drawing.Color.Black;
            this.btnBuscarUsuarioPorCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUsuarioPorCedula.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarUsuarioPorCedula.ForeColor = System.Drawing.Color.Chocolate;
            this.btnBuscarUsuarioPorCedula.Location = new System.Drawing.Point(3, 44);
            this.btnBuscarUsuarioPorCedula.Name = "btnBuscarUsuarioPorCedula";
            this.btnBuscarUsuarioPorCedula.Size = new System.Drawing.Size(190, 41);
            this.btnBuscarUsuarioPorCedula.TabIndex = 1;
            this.btnBuscarUsuarioPorCedula.Text = "Buscar Cedula";
            this.btnBuscarUsuarioPorCedula.UseVisualStyleBackColor = false;
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.BackColor = System.Drawing.Color.Black;
            this.txtBuscarCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCedula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarCedula.ForeColor = System.Drawing.Color.White;
            this.txtBuscarCedula.Location = new System.Drawing.Point(3, 3);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(202, 23);
            this.txtBuscarCedula.TabIndex = 4;
            this.txtBuscarCedula.Text = "Buscar Cedula";
            this.txtBuscarCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.Black;
            this.btnDeseleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDeseleccionar.Location = new System.Drawing.Point(589, 398);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(208, 45);
            this.btnDeseleccionar.TabIndex = 4;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            // 
            // lblListadoResultadoLab
            // 
            this.lblListadoResultadoLab.AutoSize = true;
            this.tlpUsuarios.SetColumnSpan(this.lblListadoResultadoLab, 3);
            this.lblListadoResultadoLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoResultadoLab.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoResultadoLab.Location = new System.Drawing.Point(3, 0);
            this.lblListadoResultadoLab.Name = "lblListadoResultadoLab";
            this.lblListadoResultadoLab.Size = new System.Drawing.Size(794, 78);
            this.lblListadoResultadoLab.TabIndex = 0;
            this.lblListadoResultadoLab.Text = "Resultados de Laboratorio Pendientes";
            this.lblListadoResultadoLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmResultadosLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.tlpUsuarios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "FrmResultadosLaboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Resultados de Laboratorio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmResultadosLaboratorio_FormClosed);
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultadosLab)).EndInit();
            this.tlpResultadosPendientes.ResumeLayout(false);
            this.tlpResultadosPendientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.Label lblListadoResultadoLab;
        public System.Windows.Forms.DataGridView DgvResultadosLab;
        private System.Windows.Forms.TableLayoutPanel tlpResultadosPendientes;
        private System.Windows.Forms.Button btnBuscarUsuarioPorCedula;
        private System.Windows.Forms.Button btnReportarResultado;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtBuscarCedula;
    }
}

