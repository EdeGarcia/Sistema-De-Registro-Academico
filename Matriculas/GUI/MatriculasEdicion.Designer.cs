namespace Matriculas.GUI
{
    partial class MatriculasEdicion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculasEdicion));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.lblUno = new System.Windows.Forms.Label();
            this.txbCupo = new System.Windows.Forms.TextBox();
            this.Turno = new System.Windows.Forms.Label();
            this.txbTurno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSecciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeleccionarEstudiante = new System.Windows.Forms.Button();
            this.cbbGrados = new System.Windows.Forms.ComboBox();
            this.txbIDEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEstudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaMatricula);
            this.splitContainer1.Panel1.Controls.Add(this.lblUno);
            this.splitContainer1.Panel1.Controls.Add(this.txbCupo);
            this.splitContainer1.Panel1.Controls.Add(this.Turno);
            this.splitContainer1.Panel1.Controls.Add(this.txbTurno);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cbbSecciones);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.btnSeleccionarEstudiante);
            this.splitContainer1.Panel1.Controls.Add(this.cbbGrados);
            this.splitContainer1.Panel1.Controls.Add(this.txbIDEstudiante);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txbEstudiante);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txbIDMatricula);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnGuardar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCerrar);
            this.splitContainer1.Size = new System.Drawing.Size(491, 570);
            this.splitContainer1.SplitterDistance = 475;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fecha";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMatricula.Location = new System.Drawing.Point(11, 440);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(245, 23);
            this.dtpFechaMatricula.TabIndex = 15;
            // 
            // lblUno
            // 
            this.lblUno.AutoSize = true;
            this.lblUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUno.Location = new System.Drawing.Point(266, 359);
            this.lblUno.Name = "lblUno";
            this.lblUno.Size = new System.Drawing.Size(40, 16);
            this.lblUno.TabIndex = 14;
            this.lblUno.Text = "Cupo";
            // 
            // txbCupo
            // 
            this.txbCupo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCupo.Location = new System.Drawing.Point(262, 378);
            this.txbCupo.Name = "txbCupo";
            this.txbCupo.ReadOnly = true;
            this.txbCupo.Size = new System.Drawing.Size(216, 23);
            this.txbCupo.TabIndex = 13;
            // 
            // Turno
            // 
            this.Turno.AutoSize = true;
            this.Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turno.Location = new System.Drawing.Point(15, 359);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(43, 16);
            this.Turno.TabIndex = 12;
            this.Turno.Text = "Turno";
            // 
            // txbTurno
            // 
            this.txbTurno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTurno.Location = new System.Drawing.Point(11, 378);
            this.txbTurno.Name = "txbTurno";
            this.txbTurno.ReadOnly = true;
            this.txbTurno.Size = new System.Drawing.Size(245, 23);
            this.txbTurno.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sección";
            // 
            // cbbSecciones
            // 
            this.cbbSecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSecciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSecciones.FormattingEnabled = true;
            this.cbbSecciones.Location = new System.Drawing.Point(11, 308);
            this.cbbSecciones.Name = "cbbSecciones";
            this.cbbSecciones.Size = new System.Drawing.Size(467, 25);
            this.cbbSecciones.TabIndex = 9;
            this.cbbSecciones.SelectedIndexChanged += new System.EventHandler(this.cbbSecciones_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grado";
            // 
            // btnSeleccionarEstudiante
            // 
            this.btnSeleccionarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarEstudiante.Image")));
            this.btnSeleccionarEstudiante.Location = new System.Drawing.Point(403, 178);
            this.btnSeleccionarEstudiante.Name = "btnSeleccionarEstudiante";
            this.btnSeleccionarEstudiante.Size = new System.Drawing.Size(75, 28);
            this.btnSeleccionarEstudiante.TabIndex = 7;
            this.btnSeleccionarEstudiante.UseVisualStyleBackColor = true;
            this.btnSeleccionarEstudiante.Click += new System.EventHandler(this.btnSeleccionarEstudiante_Click);
            // 
            // cbbGrados
            // 
            this.cbbGrados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGrados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGrados.FormattingEnabled = true;
            this.cbbGrados.Location = new System.Drawing.Point(11, 237);
            this.cbbGrados.Name = "cbbGrados";
            this.cbbGrados.Size = new System.Drawing.Size(467, 25);
            this.cbbGrados.TabIndex = 6;
            this.cbbGrados.SelectedIndexChanged += new System.EventHandler(this.cbbGrados_SelectedIndexChanged);
            // 
            // txbIDEstudiante
            // 
            this.txbIDEstudiante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDEstudiante.Location = new System.Drawing.Point(11, 93);
            this.txbIDEstudiante.Name = "txbIDEstudiante";
            this.txbIDEstudiante.ReadOnly = true;
            this.txbIDEstudiante.Size = new System.Drawing.Size(100, 23);
            this.txbIDEstudiante.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Estudiante";
            // 
            // txbEstudiante
            // 
            this.txbEstudiante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEstudiante.Location = new System.Drawing.Point(11, 149);
            this.txbEstudiante.Name = "txbEstudiante";
            this.txbEstudiante.ReadOnly = true;
            this.txbEstudiante.Size = new System.Drawing.Size(467, 23);
            this.txbEstudiante.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estudiante";
            // 
            // txbIDMatricula
            // 
            this.txbIDMatricula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDMatricula.Location = new System.Drawing.Point(11, 27);
            this.txbIDMatricula.Name = "txbIDMatricula";
            this.txbIDMatricula.ReadOnly = true;
            this.txbIDMatricula.Size = new System.Drawing.Size(100, 23);
            this.txbIDMatricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(292, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 36);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(388, 42);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 36);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // MatriculasEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 570);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MatriculasEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Matriculas";
            this.Load += new System.EventHandler(this.MatriculasEdicion_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeleccionarEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.TextBox txbIDMatricula;
        public System.Windows.Forms.TextBox txbEstudiante;
        public System.Windows.Forms.TextBox txbIDEstudiante;
        private System.Windows.Forms.Label lblUno;
        public System.Windows.Forms.TextBox txbCupo;
        private System.Windows.Forms.Label Turno;
        public System.Windows.Forms.TextBox txbTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.ComboBox cbbGrados;
        public System.Windows.Forms.ComboBox cbbSecciones;
        public System.Windows.Forms.DateTimePicker dtpFechaMatricula;
    }
}