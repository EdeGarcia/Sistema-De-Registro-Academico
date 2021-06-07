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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
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
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnEstudiantes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMatriculas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNotas = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.gestionarGradosYSeccionesToolStripMenuItem,
            this.responsablesYEstudiantesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.matriculasToolStripMenuItem,
            this.noToolStripMenuItem,
            this.informesToolStripMenuItem});
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
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarNotasToolStripMenuItem});
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.noToolStripMenuItem.Text = "Notas";
            // 
            // gestionarNotasToolStripMenuItem
            // 
            this.gestionarNotasToolStripMenuItem.Name = "gestionarNotasToolStripMenuItem";
            this.gestionarNotasToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gestionarNotasToolStripMenuItem.Text = "Gestionar notas";
            this.gestionarNotasToolStripMenuItem.Click += new System.EventHandler(this.gestionarNotasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem,
            this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem,
            this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // reporteDeResponsablesDeUnaSecciónToolStripMenuItem
            // 
            this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem.Name = "reporteDeResponsablesDeUnaSecciónToolStripMenuItem";
            this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem.Text = "Reporte de responsables de una sección";
            this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem.Click += new System.EventHandler(this.reporteDeResponsablesDeUnaSecciónToolStripMenuItem_Click);
            // 
            // reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem
            // 
            this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem.Name = "reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem";
            this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem.Text = "Reporte de estudiantes matriculados en una sección";
            this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem_Click);
            // 
            // reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem
            // 
            this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem.Name = "reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem";
            this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem.Size = new System.Drawing.Size(348, 22);
            this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem.Text = "Reporte de notas de estudiantes de una sección";
            this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem.Click += new System.EventHandler(this.reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 17);
            this.lblUsuario.Text = "USUARIO:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip.Location = new System.Drawing.Point(0, 463);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblRol
            // 
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 17);
            this.lblRol.Text = "ROL:";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEstudiantes,
            this.toolStripSeparator1,
            this.btnMatriculas,
            this.toolStripSeparator2,
            this.btnNotas});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(795, 47);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Image = ((System.Drawing.Image)(resources.GetObject("btnEstudiantes.Image")));
            this.btnEstudiantes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(71, 44);
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstudiantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // btnMatriculas
            // 
            this.btnMatriculas.Image = ((System.Drawing.Image)(resources.GetObject("btnMatriculas.Image")));
            this.btnMatriculas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMatriculas.Name = "btnMatriculas";
            this.btnMatriculas.Size = new System.Drawing.Size(66, 44);
            this.btnMatriculas.Text = "Matriculas";
            this.btnMatriculas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMatriculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMatriculas.Click += new System.EventHandler(this.btnMatriculas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // btnNotas
            // 
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(93, 44);
            this.btnNotas.Text = "Gestionar notas";
            this.btnNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 485);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeResponsablesDeUnaSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstudiatesMatriculadosEnUnaSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeNotasDeEstudiantesDeUnaSecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnEstudiantes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMatriculas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNotas;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
    }
}



