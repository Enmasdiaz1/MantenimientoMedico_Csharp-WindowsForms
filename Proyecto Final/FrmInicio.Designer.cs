
namespace Proyecto_Final
{
    partial class FrmInicio
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
            this.tlpInicio = new System.Windows.Forms.TableLayoutPanel();
            this.mainInicio = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.tlpInicio.SuspendLayout();
            this.mainInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpInicio
            // 
            this.tlpInicio.ColumnCount = 3;
            this.tlpInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.70417F));
            this.tlpInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.66062F));
            this.tlpInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8167F));
            this.tlpInicio.Controls.Add(this.mainInicio, 0, 0);
            this.tlpInicio.Controls.Add(this.lblBienvenido, 1, 1);
            this.tlpInicio.Controls.Add(this.lblUsuario, 1, 2);
            this.tlpInicio.Controls.Add(this.lblMedico, 2, 2);
            this.tlpInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInicio.Location = new System.Drawing.Point(0, 0);
            this.tlpInicio.Name = "tlpInicio";
            this.tlpInicio.RowCount = 3;
            this.tlpInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.34043F));
            this.tlpInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.04255F));
            this.tlpInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.61702F));
            this.tlpInicio.Size = new System.Drawing.Size(551, 235);
            this.tlpInicio.TabIndex = 0;
            // 
            // mainInicio
            // 
            this.mainInicio.BackColor = System.Drawing.Color.Black;
            this.mainInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainInicio.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.mainInicio.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainInicio.Location = new System.Drawing.Point(0, 0);
            this.mainInicio.Name = "mainInicio";
            this.mainInicio.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainInicio.Size = new System.Drawing.Size(68, 29);
            this.mainInicio.TabIndex = 3;
            this.mainInicio.Text = "Main";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeUsuariosToolStripMenuItem,
            this.mantenimientoDeMédicosToolStripMenuItem,
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem,
            this.mantenimientoDePacientesToolStripMenuItem,
            this.mantenimientoDeCitasToolStripMenuItem,
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Haettenschweiler", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(56, 25);
            this.mantenimientosToolStripMenuItem.Text = "Mant.";
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            this.mantenimientoDeUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mantenimientoDeUsuariosToolStripMenuItem.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientoDeUsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            this.mantenimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(446, 24);
            this.mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de Usuarios";
            this.mantenimientoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // mantenimientoDeMédicosToolStripMenuItem
            // 
            this.mantenimientoDeMédicosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mantenimientoDeMédicosToolStripMenuItem.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientoDeMédicosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDeMédicosToolStripMenuItem.Name = "mantenimientoDeMédicosToolStripMenuItem";
            this.mantenimientoDeMédicosToolStripMenuItem.Size = new System.Drawing.Size(446, 24);
            this.mantenimientoDeMédicosToolStripMenuItem.Text = "Mantenimiento de Médicos";
            this.mantenimientoDeMédicosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeMédicosToolStripMenuItem_Click);
            // 
            // mantenimientoDePruebasDeLaboratorioToolStripMenuItem
            // 
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.Name = "mantenimientoDePruebasDeLaboratorioToolStripMenuItem";
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(446, 24);
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.Text = "Mantenimiento de Pruebas de Laboratorio";
            this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDePruebasDeLaboratorioToolStripMenuItem_Click);
            // 
            // mantenimientoDePacientesToolStripMenuItem
            // 
            this.mantenimientoDePacientesToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mantenimientoDePacientesToolStripMenuItem.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientoDePacientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDePacientesToolStripMenuItem.Name = "mantenimientoDePacientesToolStripMenuItem";
            this.mantenimientoDePacientesToolStripMenuItem.Size = new System.Drawing.Size(446, 24);
            this.mantenimientoDePacientesToolStripMenuItem.Text = "Mantenimiento de Pacientes";
            this.mantenimientoDePacientesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDePacientesToolStripMenuItem_Click);
            // 
            // mantenimientoDeCitasToolStripMenuItem
            // 
            this.mantenimientoDeCitasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mantenimientoDeCitasToolStripMenuItem.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientoDeCitasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDeCitasToolStripMenuItem.Name = "mantenimientoDeCitasToolStripMenuItem";
            this.mantenimientoDeCitasToolStripMenuItem.Size = new System.Drawing.Size(446, 24);
            this.mantenimientoDeCitasToolStripMenuItem.Text = "Mantenimiento de Citas";
            this.mantenimientoDeCitasToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeCitasToolStripMenuItem_Click);
            // 
            // mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem
            // 
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.Name = "mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem";
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(446, 24);
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.Text = "Mantenimiento de Resultados de Pruebas de Laboratorio";
            this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.tlpInicio.SetColumnSpan(this.lblBienvenido, 2);
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenido.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(72, 29);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(476, 67);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(72, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(195, 67);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMedico.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedico.Location = new System.Drawing.Point(273, 108);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(275, 67);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "...";
            this.lblMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMedico.Click += new System.EventHandler(this.lblMedico_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(551, 235);
            this.Controls.Add(this.tlpInicio);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.mainInicio;
            this.MinimumSize = new System.Drawing.Size(567, 274);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.tlpInicio.ResumeLayout(false);
            this.tlpInicio.PerformLayout();
            this.mainInicio.ResumeLayout(false);
            this.mainInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpInicio;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDePruebasDeLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeResultadosDePruebasDeLaboratorioToolStripMenuItem;
        public System.Windows.Forms.MenuStrip mainInicio;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMedico;
    }
}