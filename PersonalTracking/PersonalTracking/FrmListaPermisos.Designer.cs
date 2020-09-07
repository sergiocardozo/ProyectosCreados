namespace PersonalTracking
{
    partial class FrmListaPermisos
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
            this.panelNoAdmin = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDiasPermiso = new System.Windows.Forms.TextBox();
            this.lblDiasPermiso = new System.Windows.Forms.Label();
            this.gbTareas = new System.Windows.Forms.GroupBox();
            this.rbTareas = new System.Windows.Forms.RadioButton();
            this.rbtDiaInicio = new System.Windows.Forms.RadioButton();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblUnicio = new System.Windows.Forms.Label();
            this.lblFechaTarea = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGListaPermisos = new System.Windows.Forms.DataGridView();
            this.panelNoAdmin.SuspendLayout();
            this.gbTareas.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGListaPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNoAdmin
            // 
            this.panelNoAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNoAdmin.Controls.Add(this.btnLimpiar);
            this.panelNoAdmin.Controls.Add(this.btnBuscar);
            this.panelNoAdmin.Controls.Add(this.txtDiasPermiso);
            this.panelNoAdmin.Controls.Add(this.lblDiasPermiso);
            this.panelNoAdmin.Controls.Add(this.gbTareas);
            this.panelNoAdmin.Controls.Add(this.dtpFin);
            this.panelNoAdmin.Controls.Add(this.dtpInicio);
            this.panelNoAdmin.Controls.Add(this.lblFin);
            this.panelNoAdmin.Controls.Add(this.lblUnicio);
            this.panelNoAdmin.Controls.Add(this.lblFechaTarea);
            this.panelNoAdmin.Controls.Add(this.panelAdmin);
            this.panelNoAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelNoAdmin.Name = "panelNoAdmin";
            this.panelNoAdmin.Size = new System.Drawing.Size(706, 158);
            this.panelNoAdmin.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(584, 110);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 35);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(584, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDiasPermiso
            // 
            this.txtDiasPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasPermiso.Location = new System.Drawing.Point(385, 90);
            this.txtDiasPermiso.Name = "txtDiasPermiso";
            this.txtDiasPermiso.Size = new System.Drawing.Size(146, 21);
            this.txtDiasPermiso.TabIndex = 2;
            this.txtDiasPermiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblDiasPermiso
            // 
            this.lblDiasPermiso.AutoSize = true;
            this.lblDiasPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasPermiso.Location = new System.Drawing.Point(286, 94);
            this.lblDiasPermiso.Name = "lblDiasPermiso";
            this.lblDiasPermiso.Size = new System.Drawing.Size(93, 15);
            this.lblDiasPermiso.TabIndex = 22;
            this.lblDiasPermiso.Text = "Dias Permiso";
            // 
            // gbTareas
            // 
            this.gbTareas.Controls.Add(this.rbTareas);
            this.gbTareas.Controls.Add(this.rbtDiaInicio);
            this.gbTareas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbTareas.Location = new System.Drawing.Point(537, 7);
            this.gbTareas.Name = "gbTareas";
            this.gbTareas.Size = new System.Drawing.Size(162, 65);
            this.gbTareas.TabIndex = 20;
            this.gbTareas.TabStop = false;
            // 
            // rbTareas
            // 
            this.rbTareas.AutoSize = true;
            this.rbTareas.Location = new System.Drawing.Point(15, 39);
            this.rbTareas.Name = "rbTareas";
            this.rbTareas.Size = new System.Drawing.Size(111, 17);
            this.rbTareas.TabIndex = 1;
            this.rbTareas.TabStop = true;
            this.rbTareas.Text = "Tarea En Proceso";
            this.rbTareas.UseVisualStyleBackColor = true;
            // 
            // rbtDiaInicio
            // 
            this.rbtDiaInicio.AutoSize = true;
            this.rbtDiaInicio.Location = new System.Drawing.Point(15, 16);
            this.rbtDiaInicio.Name = "rbtDiaInicio";
            this.rbtDiaInicio.Size = new System.Drawing.Size(69, 17);
            this.rbtDiaInicio.TabIndex = 0;
            this.rbtDiaInicio.TabStop = true;
            this.rbtDiaInicio.Text = "Dia Inicio";
            this.rbtDiaInicio.UseVisualStyleBackColor = true;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(385, 64);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(146, 20);
            this.dtpFin.TabIndex = 1;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(385, 38);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(146, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(286, 70);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(27, 15);
            this.lblFin.TabIndex = 19;
            this.lblFin.Text = "Fin";
            // 
            // lblUnicio
            // 
            this.lblUnicio.AutoSize = true;
            this.lblUnicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnicio.Location = new System.Drawing.Point(286, 46);
            this.lblUnicio.Name = "lblUnicio";
            this.lblUnicio.Size = new System.Drawing.Size(42, 15);
            this.lblUnicio.TabIndex = 18;
            this.lblUnicio.Text = "Inicio";
            // 
            // lblFechaTarea
            // 
            this.lblFechaTarea.AutoSize = true;
            this.lblFechaTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaTarea.Location = new System.Drawing.Point(286, 16);
            this.lblFechaTarea.Name = "lblFechaTarea";
            this.lblFechaTarea.Size = new System.Drawing.Size(87, 15);
            this.lblFechaTarea.TabIndex = 17;
            this.lblFechaTarea.Text = "Fecha Tarea";
            // 
            // panelAdmin
            // 
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdmin.Controls.Add(this.cmbPuesto);
            this.panelAdmin.Controls.Add(this.lblPuesto);
            this.panelAdmin.Controls.Add(this.cmbDepartamento);
            this.panelAdmin.Controls.Add(this.lblDepartamento);
            this.panelAdmin.Controls.Add(this.txtApellido);
            this.panelAdmin.Controls.Add(this.lblApellido);
            this.panelAdmin.Controls.Add(this.txtNombre);
            this.panelAdmin.Controls.Add(this.lblNombre);
            this.panelAdmin.Controls.Add(this.txtUsuario);
            this.panelAdmin.Controls.Add(this.lblUsuario);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(280, 154);
            this.panelAdmin.TabIndex = 0;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(135, 118);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(132, 23);
            this.cmbPuesto.TabIndex = 4;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(31, 123);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(51, 15);
            this.lblPuesto.TabIndex = 20;
            this.lblPuesto.Text = "Puesto";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(135, 89);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(132, 23);
            this.cmbDepartamento.TabIndex = 3;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(31, 94);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(98, 15);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(135, 62);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 21);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(31, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 15);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(135, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(135, 8);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 21);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(31, 12);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 15);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "Usuario";
            // 
            // panelControl
            // 
            this.panelControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControl.Controls.Add(this.btnDesaprobar);
            this.panelControl.Controls.Add(this.btnAprobar);
            this.panelControl.Controls.Add(this.btnCerrar);
            this.panelControl.Controls.Add(this.btnBorrar);
            this.panelControl.Controls.Add(this.btnActualizar);
            this.panelControl.Controls.Add(this.btnAgregar);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 323);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(706, 100);
            this.panelControl.TabIndex = 1;
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.AutoEllipsis = true;
            this.btnDesaprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesaprobar.Location = new System.Drawing.Point(12, 52);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Padding = new System.Windows.Forms.Padding(3);
            this.btnDesaprobar.Size = new System.Drawing.Size(124, 39);
            this.btnDesaprobar.TabIndex = 1;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            // 
            // btnAprobar
            // 
            this.btnAprobar.AutoEllipsis = true;
            this.btnAprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.Location = new System.Drawing.Point(12, 8);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Padding = new System.Windows.Forms.Padding(3);
            this.btnAprobar.Size = new System.Drawing.Size(124, 39);
            this.btnAprobar.TabIndex = 0;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(565, 34);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(124, 39);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(426, 34);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 39);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(287, 34);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 39);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(148, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 39);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGListaPermisos
            // 
            this.dataGListaPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGListaPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGListaPermisos.Location = new System.Drawing.Point(0, 158);
            this.dataGListaPermisos.Name = "dataGListaPermisos";
            this.dataGListaPermisos.Size = new System.Drawing.Size(706, 165);
            this.dataGListaPermisos.TabIndex = 2;
            // 
            // FrmListaPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 423);
            this.Controls.Add(this.dataGListaPermisos);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelNoAdmin);
            this.Name = "FrmListaPermisos";
            this.Text = "FrmListaPermisos";
            this.panelNoAdmin.ResumeLayout(false);
            this.panelNoAdmin.PerformLayout();
            this.gbTareas.ResumeLayout(false);
            this.gbTareas.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGListaPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNoAdmin;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnDesaprobar;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbTareas;
        private System.Windows.Forms.RadioButton rbTareas;
        private System.Windows.Forms.RadioButton rbtDiaInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblUnicio;
        private System.Windows.Forms.Label lblFechaTarea;
        private System.Windows.Forms.TextBox txtDiasPermiso;
        private System.Windows.Forms.Label lblDiasPermiso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGListaPermisos;
    }
}