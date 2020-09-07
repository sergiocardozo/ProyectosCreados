namespace PersonalTracking
{
    partial class FrmPrincipal
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.btnDepartamento = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnSalarios = new System.Windows.Forms.Button();
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGray;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Image = global::PersonalTracking.Properties.Resources.salida__1_;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(276, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 138);
            this.btnExit.TabIndex = 7;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Image = global::PersonalTracking.Properties.Resources.salida;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogOut.Location = new System.Drawing.Point(103, 300);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(167, 138);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPuesto
            // 
            this.btnPuesto.BackColor = System.Drawing.Color.IndianRed;
            this.btnPuesto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPuesto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPuesto.Image = global::PersonalTracking.Properties.Resources.puesto_de_trabajo;
            this.btnPuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPuesto.Location = new System.Drawing.Point(360, 156);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Size = new System.Drawing.Size(167, 138);
            this.btnPuesto.TabIndex = 5;
            this.btnPuesto.Text = "Puesto";
            this.btnPuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPuesto.UseVisualStyleBackColor = false;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // btnDepartamento
            // 
            this.btnDepartamento.BackColor = System.Drawing.Color.Red;
            this.btnDepartamento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDepartamento.Image = global::PersonalTracking.Properties.Resources.equipo;
            this.btnDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamento.Location = new System.Drawing.Point(187, 156);
            this.btnDepartamento.Name = "btnDepartamento";
            this.btnDepartamento.Size = new System.Drawing.Size(167, 138);
            this.btnDepartamento.TabIndex = 4;
            this.btnDepartamento.Text = "Departamento";
            this.btnDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDepartamento.UseVisualStyleBackColor = false;
            this.btnDepartamento.Click += new System.EventHandler(this.btnDepartamento_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.BackColor = System.Drawing.Color.Brown;
            this.btnPermisos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPermisos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPermisos.Image = global::PersonalTracking.Properties.Resources.empleado__1_;
            this.btnPermisos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPermisos.Location = new System.Drawing.Point(14, 156);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(167, 138);
            this.btnPermisos.TabIndex = 3;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnSalarios
            // 
            this.btnSalarios.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalarios.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalarios.Image = global::PersonalTracking.Properties.Resources.comprar;
            this.btnSalarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalarios.Location = new System.Drawing.Point(360, 12);
            this.btnSalarios.Name = "btnSalarios";
            this.btnSalarios.Size = new System.Drawing.Size(167, 138);
            this.btnSalarios.TabIndex = 2;
            this.btnSalarios.Text = "Salarios";
            this.btnSalarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalarios.UseVisualStyleBackColor = false;
            this.btnSalarios.Click += new System.EventHandler(this.btnSalarios_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.Red;
            this.btnTareas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTareas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTareas.Image = global::PersonalTracking.Properties.Resources.tareas__1_;
            this.btnTareas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTareas.Location = new System.Drawing.Point(187, 12);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(167, 138);
            this.btnTareas.TabIndex = 1;
            this.btnTareas.Text = "Tareas";
            this.btnTareas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Brown;
            this.btnEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmpleado.Image = global::PersonalTracking.Properties.Resources.empleado__1_;
            this.btnEmpleado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleado.Location = new System.Drawing.Point(14, 12);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(167, 138);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPuesto);
            this.Controls.Add(this.btnDepartamento);
            this.Controls.Add(this.btnPermisos);
            this.Controls.Add(this.btnSalarios);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.btnEmpleado);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking Empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnSalarios;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
    }
}