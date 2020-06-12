namespace CapaPresentacionMedico
{
    partial class fMedico
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
            this.tabMedico = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxIDEspecialidadMedico = new System.Windows.Forms.TextBox();
            this.labelIDEspecialidadMedico = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxTelefono_CelularMedico = new System.Windows.Forms.TextBox();
            this.textBoxNombreMedico = new System.Windows.Forms.TextBox();
            this.textBoxIDMedico = new System.Windows.Forms.TextBox();
            this.labelTelefono_CelularMedico = new System.Windows.Forms.Label();
            this.labelNombreMedico = new System.Windows.Forms.Label();
            this.labelIDMedico = new System.Windows.Forms.Label();
            this.labelMedico = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewMedico = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarExpediente = new System.Windows.Forms.Label();
            this.tabMedico.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedico)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMedico
            // 
            this.tabMedico.Controls.Add(this.tabPage1);
            this.tabMedico.Controls.Add(this.tabPage2);
            this.tabMedico.Location = new System.Drawing.Point(0, 0);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.SelectedIndex = 0;
            this.tabMedico.Size = new System.Drawing.Size(800, 451);
            this.tabMedico.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImage = global::capapresentacionWF.Properties.Resources.logodental1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.textBoxIDEspecialidadMedico);
            this.tabPage1.Controls.Add(this.labelIDEspecialidadMedico);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxTelefono_CelularMedico);
            this.tabPage1.Controls.Add(this.textBoxNombreMedico);
            this.tabPage1.Controls.Add(this.textBoxIDMedico);
            this.tabPage1.Controls.Add(this.labelTelefono_CelularMedico);
            this.tabPage1.Controls.Add(this.labelNombreMedico);
            this.tabPage1.Controls.Add(this.labelIDMedico);
            this.tabPage1.Controls.Add(this.labelMedico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // textBoxIDEspecialidadMedico
            // 
            this.textBoxIDEspecialidadMedico.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDEspecialidadMedico.Location = new System.Drawing.Point(315, 240);
            this.textBoxIDEspecialidadMedico.Multiline = true;
            this.textBoxIDEspecialidadMedico.Name = "textBoxIDEspecialidadMedico";
            this.textBoxIDEspecialidadMedico.Size = new System.Drawing.Size(204, 28);
            this.textBoxIDEspecialidadMedico.TabIndex = 9;
            // 
            // labelIDEspecialidadMedico
            // 
            this.labelIDEspecialidadMedico.AutoSize = true;
            this.labelIDEspecialidadMedico.BackColor = System.Drawing.Color.Transparent;
            this.labelIDEspecialidadMedico.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDEspecialidadMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDEspecialidadMedico.Location = new System.Drawing.Point(176, 240);
            this.labelIDEspecialidadMedico.Name = "labelIDEspecialidadMedico";
            this.labelIDEspecialidadMedico.Size = new System.Drawing.Size(133, 25);
            this.labelIDEspecialidadMedico.TabIndex = 8;
            this.labelIDEspecialidadMedico.Text = "N* Especia";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(632, 365);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(142, 51);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxTelefono_CelularMedico
            // 
            this.textBoxTelefono_CelularMedico.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxTelefono_CelularMedico.Location = new System.Drawing.Point(315, 168);
            this.textBoxTelefono_CelularMedico.Multiline = true;
            this.textBoxTelefono_CelularMedico.Name = "textBoxTelefono_CelularMedico";
            this.textBoxTelefono_CelularMedico.Size = new System.Drawing.Size(204, 28);
            this.textBoxTelefono_CelularMedico.TabIndex = 6;
            // 
            // textBoxNombreMedico
            // 
            this.textBoxNombreMedico.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxNombreMedico.Location = new System.Drawing.Point(315, 115);
            this.textBoxNombreMedico.Multiline = true;
            this.textBoxNombreMedico.Name = "textBoxNombreMedico";
            this.textBoxNombreMedico.Size = new System.Drawing.Size(204, 28);
            this.textBoxNombreMedico.TabIndex = 5;
            // 
            // textBoxIDMedico
            // 
            this.textBoxIDMedico.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDMedico.Location = new System.Drawing.Point(92, 40);
            this.textBoxIDMedico.Multiline = true;
            this.textBoxIDMedico.Name = "textBoxIDMedico";
            this.textBoxIDMedico.Size = new System.Drawing.Size(37, 32);
            this.textBoxIDMedico.TabIndex = 4;
            // 
            // labelTelefono_CelularMedico
            // 
            this.labelTelefono_CelularMedico.AutoSize = true;
            this.labelTelefono_CelularMedico.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono_CelularMedico.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono_CelularMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTelefono_CelularMedico.Location = new System.Drawing.Point(203, 168);
            this.labelTelefono_CelularMedico.Name = "labelTelefono_CelularMedico";
            this.labelTelefono_CelularMedico.Size = new System.Drawing.Size(106, 25);
            this.labelTelefono_CelularMedico.TabIndex = 3;
            this.labelTelefono_CelularMedico.Text = "Telefono";
            // 
            // labelNombreMedico
            // 
            this.labelNombreMedico.AutoSize = true;
            this.labelNombreMedico.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreMedico.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreMedico.Location = new System.Drawing.Point(215, 115);
            this.labelNombreMedico.Name = "labelNombreMedico";
            this.labelNombreMedico.Size = new System.Drawing.Size(94, 25);
            this.labelNombreMedico.TabIndex = 2;
            this.labelNombreMedico.Text = "Nombre";
            // 
            // labelIDMedico
            // 
            this.labelIDMedico.AutoSize = true;
            this.labelIDMedico.BackColor = System.Drawing.Color.Transparent;
            this.labelIDMedico.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMedico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDMedico.Location = new System.Drawing.Point(45, 47);
            this.labelIDMedico.Name = "labelIDMedico";
            this.labelIDMedico.Size = new System.Drawing.Size(41, 25);
            this.labelIDMedico.TabIndex = 1;
            this.labelIDMedico.Text = "ID";
            // 
            // labelMedico
            // 
            this.labelMedico.AutoSize = true;
            this.labelMedico.BackColor = System.Drawing.Color.Transparent;
            this.labelMedico.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedico.ForeColor = System.Drawing.Color.DimGray;
            this.labelMedico.Location = new System.Drawing.Point(340, 0);
            this.labelMedico.Name = "labelMedico";
            this.labelMedico.Size = new System.Drawing.Size(132, 38);
            this.labelMedico.TabIndex = 0;
            this.labelMedico.Text = "Medicos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.dataGridViewMedico);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscarExpediente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // dataGridViewMedico
            // 
            this.dataGridViewMedico.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedico.Location = new System.Drawing.Point(23, 122);
            this.dataGridViewMedico.Name = "dataGridViewMedico";
            this.dataGridViewMedico.Size = new System.Drawing.Size(750, 221);
            this.dataGridViewMedico.TabIndex = 11;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(666, 370);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(112, 34);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEditar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(683, 6);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 34);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonBuscar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(578, 6);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 34);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxBuscar.Location = new System.Drawing.Point(185, 67);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(369, 27);
            this.textBoxBuscar.TabIndex = 7;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscarExpediente
            // 
            this.labelBuscarExpediente.AutoSize = true;
            this.labelBuscarExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarExpediente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBuscarExpediente.Location = new System.Drawing.Point(93, 69);
            this.labelBuscarExpediente.Name = "labelBuscarExpediente";
            this.labelBuscarExpediente.Size = new System.Drawing.Size(86, 25);
            this.labelBuscarExpediente.TabIndex = 6;
            this.labelBuscarExpediente.Text = "Buscar";
            // 
            // fMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMedico);
            this.Name = "fMedico";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.fMedico_Load);
            this.tabMedico.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMedico;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxIDEspecialidadMedico;
        private System.Windows.Forms.Label labelIDEspecialidadMedico;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxTelefono_CelularMedico;
        private System.Windows.Forms.TextBox textBoxNombreMedico;
        private System.Windows.Forms.TextBox textBoxIDMedico;
        private System.Windows.Forms.Label labelTelefono_CelularMedico;
        private System.Windows.Forms.Label labelNombreMedico;
        private System.Windows.Forms.Label labelIDMedico;
        private System.Windows.Forms.Label labelMedico;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewMedico;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscarExpediente;
    }
}

