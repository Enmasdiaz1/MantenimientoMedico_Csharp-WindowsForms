
namespace Proyecto_Final
{
    partial class FrmPruebasLaboratorio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.DgvPruebasDeLab = new System.Windows.Forms.DataGridView();
            this.tlpPruebasLab = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoPruebaLab = new System.Windows.Forms.Button();
            this.btnEliminarPruebaLab = new System.Windows.Forms.Button();
            this.btnEditarPruebaLab = new System.Windows.Forms.Button();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.lblListadoPruebasDeLab = new System.Windows.Forms.Label();
            this.tlpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPruebasDeLab)).BeginInit();
            this.tlpPruebasLab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 3;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.24799F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.75201F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpUsuarios.Controls.Add(this.btnVolver, 0, 2);
            this.tlpUsuarios.Controls.Add(this.DgvPruebasDeLab, 0, 1);
            this.tlpUsuarios.Controls.Add(this.tlpPruebasLab, 2, 1);
            this.tlpUsuarios.Controls.Add(this.btnDeseleccionar, 2, 2);
            this.tlpUsuarios.Controls.Add(this.lblListadoPruebasDeLab, 0, 0);
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
            this.btnVolver.Size = new System.Drawing.Size(149, 44);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DgvPruebasDeLab
            // 
            this.DgvPruebasDeLab.AllowUserToAddRows = false;
            this.DgvPruebasDeLab.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPruebasDeLab.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvPruebasDeLab.BackgroundColor = System.Drawing.Color.Black;
            this.DgvPruebasDeLab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvPruebasDeLab.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPruebasDeLab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvPruebasDeLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpUsuarios.SetColumnSpan(this.DgvPruebasDeLab, 2);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPruebasDeLab.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvPruebasDeLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPruebasDeLab.GridColor = System.Drawing.Color.Black;
            this.DgvPruebasDeLab.Location = new System.Drawing.Point(3, 81);
            this.DgvPruebasDeLab.MultiSelect = false;
            this.DgvPruebasDeLab.Name = "DgvPruebasDeLab";
            this.DgvPruebasDeLab.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPruebasDeLab.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPruebasDeLab.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvPruebasDeLab.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvPruebasDeLab.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvPruebasDeLab.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvPruebasDeLab.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvPruebasDeLab.RowTemplate.Height = 25;
            this.DgvPruebasDeLab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPruebasDeLab.ShowCellErrors = false;
            this.DgvPruebasDeLab.ShowCellToolTips = false;
            this.DgvPruebasDeLab.ShowEditingIcon = false;
            this.DgvPruebasDeLab.ShowRowErrors = false;
            this.DgvPruebasDeLab.Size = new System.Drawing.Size(585, 312);
            this.DgvPruebasDeLab.TabIndex = 1;
            this.DgvPruebasDeLab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPruebasDeLab_CellClick);
            // 
            // tlpPruebasLab
            // 
            this.tlpPruebasLab.ColumnCount = 1;
            this.tlpPruebasLab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPruebasLab.Controls.Add(this.btnNuevoPruebaLab, 0, 0);
            this.tlpPruebasLab.Controls.Add(this.btnEliminarPruebaLab, 0, 2);
            this.tlpPruebasLab.Controls.Add(this.btnEditarPruebaLab, 0, 3);
            this.tlpPruebasLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPruebasLab.Location = new System.Drawing.Point(594, 81);
            this.tlpPruebasLab.Name = "tlpPruebasLab";
            this.tlpPruebasLab.RowCount = 5;
            this.tlpPruebasLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
            this.tlpPruebasLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
            this.tlpPruebasLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpPruebasLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpPruebasLab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpPruebasLab.Size = new System.Drawing.Size(203, 312);
            this.tlpPruebasLab.TabIndex = 2;
            // 
            // btnNuevoPruebaLab
            // 
            this.btnNuevoPruebaLab.BackColor = System.Drawing.Color.Black;
            this.btnNuevoPruebaLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoPruebaLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPruebaLab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoPruebaLab.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevoPruebaLab.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoPruebaLab.Name = "btnNuevoPruebaLab";
            this.btnNuevoPruebaLab.Size = new System.Drawing.Size(197, 41);
            this.btnNuevoPruebaLab.TabIndex = 1;
            this.btnNuevoPruebaLab.Text = "Nueva Prueba de Lab.";
            this.btnNuevoPruebaLab.UseVisualStyleBackColor = false;
            this.btnNuevoPruebaLab.Click += new System.EventHandler(this.btnNuevoPruebaLab_Click);
            // 
            // btnEliminarPruebaLab
            // 
            this.btnEliminarPruebaLab.BackColor = System.Drawing.Color.Black;
            this.btnEliminarPruebaLab.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarPruebaLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPruebaLab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarPruebaLab.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarPruebaLab.Location = new System.Drawing.Point(3, 75);
            this.btnEliminarPruebaLab.Name = "btnEliminarPruebaLab";
            this.btnEliminarPruebaLab.Size = new System.Drawing.Size(197, 48);
            this.btnEliminarPruebaLab.TabIndex = 2;
            this.btnEliminarPruebaLab.Text = "Eliminar Prueba de Lab.";
            this.btnEliminarPruebaLab.UseVisualStyleBackColor = false;
            this.btnEliminarPruebaLab.Click += new System.EventHandler(this.btnEliminarPruebaLab_Click);
            // 
            // btnEditarPruebaLab
            // 
            this.btnEditarPruebaLab.BackColor = System.Drawing.Color.Black;
            this.btnEditarPruebaLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarPruebaLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPruebaLab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarPruebaLab.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarPruebaLab.Location = new System.Drawing.Point(3, 162);
            this.btnEditarPruebaLab.Name = "btnEditarPruebaLab";
            this.btnEditarPruebaLab.Size = new System.Drawing.Size(197, 42);
            this.btnEditarPruebaLab.TabIndex = 3;
            this.btnEditarPruebaLab.Text = "Editar Prueba de Lab.";
            this.btnEditarPruebaLab.UseVisualStyleBackColor = false;
            this.btnEditarPruebaLab.Click += new System.EventHandler(this.btnEditarPruebaLab_Click);
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.Black;
            this.btnDeseleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDeseleccionar.Location = new System.Drawing.Point(594, 399);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(203, 44);
            this.btnDeseleccionar.TabIndex = 4;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // lblListadoPruebasDeLab
            // 
            this.lblListadoPruebasDeLab.AutoSize = true;
            this.tlpUsuarios.SetColumnSpan(this.lblListadoPruebasDeLab, 3);
            this.lblListadoPruebasDeLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoPruebasDeLab.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoPruebasDeLab.Location = new System.Drawing.Point(3, 0);
            this.lblListadoPruebasDeLab.Name = "lblListadoPruebasDeLab";
            this.lblListadoPruebasDeLab.Size = new System.Drawing.Size(794, 78);
            this.lblListadoPruebasDeLab.TabIndex = 0;
            this.lblListadoPruebasDeLab.Text = "Pruebas de Laboratorio en el Sistema";
            this.lblListadoPruebasDeLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPruebasLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.tlpUsuarios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "FrmPruebasLaboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Pruebas de Laboratorio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPruebasLaboratorio_FormClosed);
            this.Load += new System.EventHandler(this.FrmPruebasLaboratorio_Load);
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPruebasDeLab)).EndInit();
            this.tlpPruebasLab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.Label lblListadoPruebasDeLab;
        public System.Windows.Forms.DataGridView DgvPruebasDeLab;
        private System.Windows.Forms.TableLayoutPanel tlpPruebasLab;
        private System.Windows.Forms.Button btnNuevoPruebaLab;
        private System.Windows.Forms.Button btnEliminarPruebaLab;
        private System.Windows.Forms.Button btnEditarPruebaLab;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnVolver;
    }
}

