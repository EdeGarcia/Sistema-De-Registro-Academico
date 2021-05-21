namespace NaMaE.GUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarGradosYSeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarGradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarSeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeSecciónAMaestroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsablesYEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeResponsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarMateriasAGradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.gestionarGradosYSeccionesToolStripMenuItem,
            this.responsablesYEstudiantesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.matriculasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(795, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeEmpleadosToolStripMenuItem,
            this.gestiónDeUsuariosToolStripMenuItem,
            this.rolesDelSistemaToolStripMenuItem,
            this.permisosToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // gestiónDeEmpleadosToolStripMenuItem
            // 
            this.gestiónDeEmpleadosToolStripMenuItem.Name = "gestiónDeEmpleadosToolStripMenuItem";
            this.gestiónDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.gestiónDeEmpleadosToolStripMenuItem.Text = "Gestión de empleados";
            this.gestiónDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeEmpleadosToolStripMenuItem_Click);
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // rolesDelSistemaToolStripMenuItem
            // 
            this.rolesDelSistemaToolStripMenuItem.Name = "rolesDelSistemaToolStripMenuItem";
            this.rolesDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.rolesDelSistemaToolStripMenuItem.Text = "Roles del sistema";
            this.rolesDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.rolesDelSistemaToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // gestionarGradosYSeccionesToolStripMenuItem
            // 
            this.gestionarGradosYSeccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarGradosToolStripMenuItem,
            this.gestionarSeccionesToolStripMenuItem,
            this.asignaciónDeSecciónAMaestroToolStripMenuItem});
            this.gestionarGradosYSeccionesToolStripMenuItem.Name = "gestionarGradosYSeccionesToolStripMenuItem";
            this.gestionarGradosYSeccionesToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionarGradosYSeccionesToolStripMenuItem.Text = "Grados y secciones";
            // 
            // gestionarGradosToolStripMenuItem
            // 
            this.gestionarGradosToolStripMenuItem.Name = "gestionarGradosToolStripMenuItem";
            this.gestionarGradosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.gestionarGradosToolStripMenuItem.Text = "Gestionar grados";
            this.gestionarGradosToolStripMenuItem.Click += new System.EventHandler(this.gestionarGradosToolStripMenuItem_Click);
            // 
            // gestionarSeccionesToolStripMenuItem
            // 
            this.gestionarSeccionesToolStripMenuItem.Name = "gestionarSeccionesToolStripMenuItem";
            this.gestionarSeccionesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.gestionarSeccionesToolStripMenuItem.Text = "Gestionar secciones";
            this.gestionarSeccionesToolStripMenuItem.Click += new System.EventHandler(this.gestionarSeccionesToolStripMenuItem_Click);
            // 
            // asignaciónDeSecciónAMaestroToolStripMenuItem
            // 
            this.asignaciónDeSecciónAMaestroToolStripMenuItem.Name = "asignaciónDeSecciónAMaestroToolStripMenuItem";
            this.asignaciónDeSecciónAMaestroToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.asignaciónDeSecciónAMaestroToolStripMenuItem.Text = "Asignación de sección a maestro";
            this.asignaciónDeSecciónAMaestroToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeSecciónAMaestroToolStripMenuItem_Click);
            // 
            // responsablesYEstudiantesToolStripMenuItem
            // 
            this.responsablesYEstudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeResponsablesToolStripMenuItem,
            this.gestiónDeEstudiantesToolStripMenuItem});
            this.responsablesYEstudiantesToolStripMenuItem.Name = "responsablesYEstudiantesToolStripMenuItem";
            this.responsablesYEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.responsablesYEstudiantesToolStripMenuItem.Text = "Responsables y estudiantes";
            // 
            // gestiónDeResponsablesToolStripMenuItem
            // 
            this.gestiónDeResponsablesToolStripMenuItem.Name = "gestiónDeResponsablesToolStripMenuItem";
            this.gestiónDeResponsablesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gestiónDeResponsablesToolStripMenuItem.Text = "Gestión de responsables";
            this.gestiónDeResponsablesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeResponsablesToolStripMenuItem_Click);
            // 
            // gestiónDeEstudiantesToolStripMenuItem
            // 
            this.gestiónDeEstudiantesToolStripMenuItem.Name = "gestiónDeEstudiantesToolStripMenuItem";
            this.gestiónDeEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gestiónDeEstudiantesToolStripMenuItem.Text = "Gestión de estudiantes";
            this.gestiónDeEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeEstudiantesToolStripMenuItem_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeMateriasToolStripMenuItem,
            this.asignarMateriasAGradosToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // gestiónDeMateriasToolStripMenuItem
            // 
            this.gestiónDeMateriasToolStripMenuItem.Name = "gestiónDeMateriasToolStripMenuItem";
            this.gestiónDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gestiónDeMateriasToolStripMenuItem.Text = "Gestión de materias";
            this.gestiónDeMateriasToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeMateriasToolStripMenuItem_Click);
            // 
            // asignarMateriasAGradosToolStripMenuItem
            // 
            this.asignarMateriasAGradosToolStripMenuItem.Name = "asignarMateriasAGradosToolStripMenuItem";
            this.asignarMateriasAGradosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.asignarMateriasAGradosToolStripMenuItem.Text = "Asignar materias a grados";
            this.asignarMateriasAGradosToolStripMenuItem.Click += new System.EventHandler(this.asignarMateriasAGradosToolStripMenuItem_Click);
            // 
            // matriculasToolStripMenuItem
            // 
            this.matriculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarMatriculaToolStripMenuItem});
            this.matriculasToolStripMenuItem.Name = "matriculasToolStripMenuItem";
            this.matriculasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.matriculasToolStripMenuItem.Text = "Matriculas";
            // 
            // gestionarMatriculaToolStripMenuItem
            // 
            this.gestionarMatriculaToolStripMenuItem.Name = "gestionarMatriculaToolStripMenuItem";
            this.gestionarMatriculaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gestionarMatriculaToolStripMenuItem.Text = "Gestionar matricula";
            this.gestionarMatriculaToolStripMenuItem.Click += new System.EventHandler(this.gestionarMatriculaToolStripMenuItem_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(42, 17);
            this.lblUsuario.Text = "Estado";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip.Location = new System.Drawing.Point(0, 463);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(795, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarGradosYSeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarGradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarSeccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsablesYEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeResponsablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarMateriasAGradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeSecciónAMaestroToolStripMenuItem;
    }
}



