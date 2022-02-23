
namespace Proyecto_Final
{
    partial class FrmCitas
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
            this.DgvCitas = new System.Windows.Forms.DataGridView();
            this.tlpCitas = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnDeseleccionar = new System.Windows.Forms.Button();
            this.lblListadoCitas = new System.Windows.Forms.Label();
            this.tlpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCitas)).BeginInit();
            this.tlpCitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 3;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.24799F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.75201F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlpUsuarios.Controls.Add(this.btnVolver, 0, 2);
            this.tlpUsuarios.Controls.Add(this.DgvCitas, 0, 1);
            this.tlpUsuarios.Controls.Add(this.tlpCitas, 2, 1);
            this.tlpUsuarios.Controls.Add(this.btnDeseleccionar, 2, 2);
            this.tlpUsuarios.Controls.Add(this.lblListadoCitas, 0, 0);
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
            this.btnVolver.ForeColor = System.Drawing.Color.Chocolate;
            this.btnVolver.Location = new System.Drawing.Point(3, 399);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(148, 44);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver Atras";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DgvCitas
            // 
            this.DgvCitas.AllowUserToAddRows = false;
            this.DgvCitas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCitas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCitas.BackgroundColor = System.Drawing.Color.Black;
            this.DgvCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpUsuarios.SetColumnSpan(this.DgvCitas, 2);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCitas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCitas.GridColor = System.Drawing.Color.Black;
            this.DgvCitas.Location = new System.Drawing.Point(3, 81);
            this.DgvCitas.MultiSelect = false;
            this.DgvCitas.Name = "DgvCitas";
            this.DgvCitas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCitas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCitas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.DgvCitas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.DgvCitas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.DgvCitas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DgvCitas.RowTemplate.Height = 25;
            this.DgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCitas.ShowCellErrors = false;
            this.DgvCitas.ShowCellToolTips = false;
            this.DgvCitas.ShowEditingIcon = false;
            this.DgvCitas.ShowRowErrors = false;
            this.DgvCitas.Size = new System.Drawing.Size(583, 312);
            this.DgvCitas.TabIndex = 1;
            // 
            // tlpCitas
            // 
            this.tlpCitas.ColumnCount = 1;
            this.tlpCitas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCitas.Controls.Add(this.btnNuevaCita, 0, 0);
            this.tlpCitas.Controls.Add(this.btnEliminarCita, 0, 2);
            this.tlpCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCitas.Location = new System.Drawing.Point(592, 81);
            this.tlpCitas.Name = "tlpCitas";
            this.tlpCitas.RowCount = 5;
            this.tlpCitas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.22222F));
            this.tlpCitas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tlpCitas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpCitas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpCitas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpCitas.Size = new System.Drawing.Size(205, 312);
            this.tlpCitas.TabIndex = 2;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.BackColor = System.Drawing.Color.Black;
            this.btnNuevaCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaCita.ForeColor = System.Drawing.Color.Chocolate;
            this.btnNuevaCita.Location = new System.Drawing.Point(3, 3);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(199, 46);
            this.btnNuevaCita.TabIndex = 1;
            this.btnNuevaCita.Text = "Nueva Cita";
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.btnNuevaCita_Click);
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.BackColor = System.Drawing.Color.Black;
            this.btnEliminarCita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCita.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCita.ForeColor = System.Drawing.Color.Chocolate;
            this.btnEliminarCita.Location = new System.Drawing.Point(3, 75);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(199, 48);
            this.btnEliminarCita.TabIndex = 2;
            this.btnEliminarCita.Text = "Eliminar Cita";
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.BackColor = System.Drawing.Color.Black;
            this.btnDeseleccionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeseleccionar.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDeseleccionar.Location = new System.Drawing.Point(592, 399);
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Size = new System.Drawing.Size(205, 44);
            this.btnDeseleccionar.TabIndex = 4;
            this.btnDeseleccionar.Text = "Deseleccionar";
            this.btnDeseleccionar.UseVisualStyleBackColor = false;
            // 
            // lblListadoCitas
            // 
            this.lblListadoCitas.AutoSize = true;
            this.tlpUsuarios.SetColumnSpan(this.lblListadoCitas, 3);
            this.lblListadoCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListadoCitas.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoCitas.Location = new System.Drawing.Point(3, 0);
            this.lblListadoCitas.Name = "lblListadoCitas";
            this.lblListadoCitas.Size = new System.Drawing.Size(794, 78);
            this.lblListadoCitas.TabIndex = 0;
            this.lblListadoCitas.Text = "Citas Registradas en el Sistema";
            this.lblListadoCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.tlpUsuarios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(816, 485);
            this.Name = "FrmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Citas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCitas_FormClosed);
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            this.tlpUsuarios.ResumeLayout(false);
            this.tlpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCitas)).EndInit();
            this.tlpCitas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuarios;
        private System.Windows.Forms.Label lblListadoCitas;
        public System.Windows.Forms.DataGridView DgvCitas;
        private System.Windows.Forms.TableLayoutPanel tlpCitas;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Button btnDeseleccionar;
        private System.Windows.Forms.Button btnVolver;
    }
}

