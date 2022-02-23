
namespace Proyecto_Final
{
    partial class FrmMedicos
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
            this.DgvMedicos = new System.Windows.Forms.DataGridView();
            this.tlpMedicos = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoMedico = new System.Windows.Forms.Button();
            this.btnEliminarMedico = new System.Windows.Forms.Button();
            this.btnEditarMedico = new System.Windows.Forms.Button();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.lblListadoMedicos = new System.Windows.Forms.Label();
            this.tlpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).BeginInit();
            this.tlpMedicos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 3;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.24799F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.75201F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tlpUsuarios.Controls.Add(this.btnVolver, 0, 2);
            this.tlpUsuarios.Controls.Add(this.DgvMedicos, 0, 1);
            this.tlpUsuarios.Controls.Add(this.tlpMedicos, 2, 1);
            this.tlpUsuarios.Controls.Add(this.btnDeseleccionar, 2, 2);
            this.tlpUsuarios.Controls.Add(this.lblListadoMedicos, 0, 0);
            this.tlpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.RowCount = 3;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.73094F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.26906F));
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpUsuarios.Size = new System.Drawing.Size(800, 446);
            this.tlpUsuarios.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.Location = new System.Drawing.Point(3, 399);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(148, 44);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DgvMedicos
            // 
            this.DgvMedicos.AllowUserToAddRows = false;
            this.DgvMedicos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMedicos.BackgroundColor = System.Drawing.Color.Black;
            this.DgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvMedicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMedicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpUsuarios.SetColumnSpan(this.DgvMedicos, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMedicos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMedicos.GridColor = System.Drawing.Color.Black;
            this.DgvMedicos.Location = new System.Drawing.Point(3, 81);
            this.DgvMedicos.MultiSelect = false;
            this.DgvMedicos.Name = "DgvMedicos";
            this.DgvMedicos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMedicos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvMedicos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvMedicos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvMedicos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvMedicos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvMedicos.RowTemplate.Height = 25;
            this.DgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMedicos.ShowCellErrors = false;
            this.DgvMedicos.ShowCellToolTips = false;
            this.DgvMedicos.ShowEditingIcon = false;
            this.DgvMedicos.ShowRowErrors = false;
            this.DgvMedicos.Size = new System.Drawing.Size(582, 312);
            this.DgvMedicos.TabIndex = 1;
            this.DgvMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicos_CellClick);
            // 
            // tlpMedicos
            // 
            this.tlpMedicos.ColumnCount = 1;
            this.tlpMedicos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMedicos.Controls.Add(this.btnNuevoMedico, 0, 0);
            this.tlpMedicos.Controls.Add(this.btnEliminarMedico, 0, 2);
            this.tlpMedicos.Controls.Add(this.btnEditarMedico, 0, 3);
            this.tlpMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMedicos.Location = new System.Drawing.Point(591, 81);
            this.tlpMedicos.Name = "tlpMedicos";
            this.tlpMedicos.RowCount = 5;
            this.tlpMedicos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
            this.tlpMedicos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
            this.tlpMedicos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpMedicos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpMedicos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpMedicos.Size = new System.Drawing.Size(206, 312);
            this.tlpMedicos.TabIndex = 2;
            // 
            // btnNuevoMedico
            // 
            this.btnNuevoMedico.BackColor = System.Drawing.Color.Black;
            this.btnNuevoMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoMedico.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoMedico.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoMedico.Name = "btnNuevoMedico";
            this.btnNuevoMedico.Size = new System.Drawing.Size(200, 41);
            this.btnNuevoMedico.TabIndex = 1;
            this.btnNuevoMedico.Text = "Nuevo Medico";
            this.btnNuevoMedico.UseVisualStyleBackColor = false;
            this.btnNuevoMedico.Click += new System.EventHandler(this.btnNuevoMedico_Click);
            // 
            // btnEliminarMedico
            // 
            this.btnEliminarMedico.BackColor = System.Drawing.Color.Black;
            this.btnEliminarMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarMedico.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarMedico.Location = new System.Drawing.Point(3, 75);
            this.btnEliminarMedico.Name = "btnEliminarMedico";
            this.btnEliminarMedico.Size = new System.Drawing.Size(200, 48);
            this.btnEliminarMedico.TabIndex = 2;
            this.btnEliminarMedico.Text = "Eliminar Medico";
            this.btnEliminarMedico.UseVisualStyleBackColor = false;
            this.btnEliminarMedico.Click += new System.EventHandler(this.btnEliminarMedico_Click);
            // 
            // btnEditarMedico
            // 
            this.btnEditarMedico.BackColor = System.Drawing.Color.Black;
            this.btnEditarMedico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarMedico.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarMedico.Location = new System.Drawing.Point(3, 162);
            this.btnEditarMedico.Name = "btnEditarMedico";
            this.btnEditarMedico.Size = new System.Drawing.Size(200, 42);
            this.btnEditarMedico.TabIndex = 3;
            this.btnEditarMedico.Text = "Editar Medico";
            this.btnEditarMedico.UseVisualStyleBackColor = false;
            this.btnEditarMedico.Click += new System.EventHandler(this.btnEditarMedico_Click);
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.Black;
            this.btnDeseleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDeseleccionar.Location = new System.Drawing.Point(591, 399);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(206, 44);
            this.btnDeseleccionar.TabIndex = 4;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // lblListadoMedicos
            // 
            this.lblListadoMedicos.AutoSize = true;
            this.tlpUsuarios.SetColumnSpan(this.lblListadoMedicos, 3);
            this.lblListadoMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoMedicos.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoMedicos.Location = new System.Drawing.Point(3, 0);
            this.lblListadoMedicos.Name = "lblListadoMedicos";
            this.lblListadoMedicos.Size = new System.Drawing.Size(794, 78);
            this.lblListadoMedicos.TabIndex = 0;
            this.lblListadoMedicos.Text = "Medicos Registrados en el Sistema";
            this.lblListadoMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.tlpUsuarios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "FrmMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Medicos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMedicos_FormClosed);
            this.Load += new System.EventHandler(this.FrmMedicos_Load);
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMedicos)).EndInit();
            this.tlpMedicos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.Label lblListadoMedicos;
        public System.Windows.Forms.DataGridView DgvMedicos;
        private System.Windows.Forms.TableLayoutPanel tlpMedicos;
        private System.Windows.Forms.Button btnNuevoMedico;
        private System.Windows.Forms.Button btnEliminarMedico;
        private System.Windows.Forms.Button btnEditarMedico;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnVolver;
    }
}

