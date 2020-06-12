namespace CapaPresentacionConsulta
{
    partial class fConsulta
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
            this.tabConsulta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxIDMedicoConsulta = new System.Windows.Forms.TextBox();
            this.labelIDMedicoConsulta = new System.Windows.Forms.Label();
            this.textBoxIDExpedienteConsulta = new System.Windows.Forms.TextBox();
            this.textBoxDiagnosticoConsulta = new System.Windows.Forms.TextBox();
            this.labelIDExpedienteConsulta = new System.Windows.Forms.Label();
            this.labelDiagnosticoConsulta = new System.Windows.Forms.Label();
            this.textBoxSintomaConsulta = new System.Windows.Forms.TextBox();
            this.labelSintoma = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxHoraConsulta = new System.Windows.Forms.TextBox();
            this.textBoxFechaConsulta = new System.Windows.Forms.TextBox();
            this.textBoxIDConsulta = new System.Windows.Forms.TextBox();
            this.labelHoraConsulta = new System.Windows.Forms.Label();
            this.labelFechaConsulta = new System.Windows.Forms.Label();
            this.labelIDConsulta = new System.Windows.Forms.Label();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.tabConsulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tabPage1);
            this.tabConsulta.Controls.Add(this.tabPage2);
            this.tabConsulta.Location = new System.Drawing.Point(0, 0);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.SelectedIndex = 0;
            this.tabConsulta.Size = new System.Drawing.Size(800, 451);
            this.tabConsulta.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImage = global::capapresentacionWF.Properties.Resources.logodental1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.textBoxIDMedicoConsulta);
            this.tabPage1.Controls.Add(this.labelIDMedicoConsulta);
            this.tabPage1.Controls.Add(this.textBoxIDExpedienteConsulta);
            this.tabPage1.Controls.Add(this.textBoxDiagnosticoConsulta);
            this.tabPage1.Controls.Add(this.labelIDExpedienteConsulta);
            this.tabPage1.Controls.Add(this.labelDiagnosticoConsulta);
            this.tabPage1.Controls.Add(this.textBoxSintomaConsulta);
            this.tabPage1.Controls.Add(this.labelSintoma);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxHoraConsulta);
            this.tabPage1.Controls.Add(this.textBoxFechaConsulta);
            this.tabPage1.Controls.Add(this.textBoxIDConsulta);
            this.tabPage1.Controls.Add(this.labelHoraConsulta);
            this.tabPage1.Controls.Add(this.labelFechaConsulta);
            this.tabPage1.Controls.Add(this.labelIDConsulta);
            this.tabPage1.Controls.Add(this.labelConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // textBoxIDMedicoConsulta
            // 
            this.textBoxIDMedicoConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDMedicoConsulta.Location = new System.Drawing.Point(689, 170);
            this.textBoxIDMedicoConsulta.Multiline = true;
            this.textBoxIDMedicoConsulta.Name = "textBoxIDMedicoConsulta";
            this.textBoxIDMedicoConsulta.Size = new System.Drawing.Size(87, 23);
            this.textBoxIDMedicoConsulta.TabIndex = 15;
            // 
            // labelIDMedicoConsulta
            // 
            this.labelIDMedicoConsulta.AutoSize = true;
            this.labelIDMedicoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelIDMedicoConsulta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMedicoConsulta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelIDMedicoConsulta.Location = new System.Drawing.Point(658, 141);
            this.labelIDMedicoConsulta.Name = "labelIDMedicoConsulta";
            this.labelIDMedicoConsulta.Size = new System.Drawing.Size(128, 25);
            this.labelIDMedicoConsulta.TabIndex = 14;
            this.labelIDMedicoConsulta.Text = "N* Medico";
            // 
            // textBoxIDExpedienteConsulta
            // 
            this.textBoxIDExpedienteConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDExpedienteConsulta.Location = new System.Drawing.Point(673, 104);
            this.textBoxIDExpedienteConsulta.Multiline = true;
            this.textBoxIDExpedienteConsulta.Name = "textBoxIDExpedienteConsulta";
            this.textBoxIDExpedienteConsulta.Size = new System.Drawing.Size(103, 22);
            this.textBoxIDExpedienteConsulta.TabIndex = 13;
            // 
            // textBoxDiagnosticoConsulta
            // 
            this.textBoxDiagnosticoConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxDiagnosticoConsulta.Location = new System.Drawing.Point(126, 286);
            this.textBoxDiagnosticoConsulta.Multiline = true;
            this.textBoxDiagnosticoConsulta.Name = "textBoxDiagnosticoConsulta";
            this.textBoxDiagnosticoConsulta.Size = new System.Drawing.Size(487, 126);
            this.textBoxDiagnosticoConsulta.TabIndex = 12;
            // 
            // labelIDExpedienteConsulta
            // 
            this.labelIDExpedienteConsulta.AutoSize = true;
            this.labelIDExpedienteConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelIDExpedienteConsulta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDExpedienteConsulta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelIDExpedienteConsulta.Location = new System.Drawing.Point(622, 72);
            this.labelIDExpedienteConsulta.Name = "labelIDExpedienteConsulta";
            this.labelIDExpedienteConsulta.Size = new System.Drawing.Size(170, 25);
            this.labelIDExpedienteConsulta.TabIndex = 11;
            this.labelIDExpedienteConsulta.Text = "N* Expediente";
            // 
            // labelDiagnosticoConsulta
            // 
            this.labelDiagnosticoConsulta.AutoSize = true;
            this.labelDiagnosticoConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelDiagnosticoConsulta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosticoConsulta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelDiagnosticoConsulta.Location = new System.Drawing.Point(6, 258);
            this.labelDiagnosticoConsulta.Name = "labelDiagnosticoConsulta";
            this.labelDiagnosticoConsulta.Size = new System.Drawing.Size(137, 25);
            this.labelDiagnosticoConsulta.TabIndex = 10;
            this.labelDiagnosticoConsulta.Text = "Diagnostico";
            // 
            // textBoxSintomaConsulta
            // 
            this.textBoxSintomaConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxSintomaConsulta.Location = new System.Drawing.Point(126, 170);
            this.textBoxSintomaConsulta.Multiline = true;
            this.textBoxSintomaConsulta.Name = "textBoxSintomaConsulta";
            this.textBoxSintomaConsulta.Size = new System.Drawing.Size(487, 85);
            this.textBoxSintomaConsulta.TabIndex = 9;
            // 
            // labelSintoma
            // 
            this.labelSintoma.AutoSize = true;
            this.labelSintoma.BackColor = System.Drawing.Color.Transparent;
            this.labelSintoma.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSintoma.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelSintoma.Location = new System.Drawing.Point(23, 141);
            this.labelSintoma.Name = "labelSintoma";
            this.labelSintoma.Size = new System.Drawing.Size(100, 25);
            this.labelSintoma.TabIndex = 8;
            this.labelSintoma.Text = "Sintoma";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(634, 367);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(142, 51);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxHoraConsulta
            // 
            this.textBoxHoraConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxHoraConsulta.Location = new System.Drawing.Point(663, 44);
            this.textBoxHoraConsulta.Multiline = true;
            this.textBoxHoraConsulta.Name = "textBoxHoraConsulta";
            this.textBoxHoraConsulta.Size = new System.Drawing.Size(113, 25);
            this.textBoxHoraConsulta.TabIndex = 6;
            // 
            // textBoxFechaConsulta
            // 
            this.textBoxFechaConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxFechaConsulta.Location = new System.Drawing.Point(126, 86);
            this.textBoxFechaConsulta.Multiline = true;
            this.textBoxFechaConsulta.Name = "textBoxFechaConsulta";
            this.textBoxFechaConsulta.Size = new System.Drawing.Size(143, 23);
            this.textBoxFechaConsulta.TabIndex = 5;
            // 
            // textBoxIDConsulta
            // 
            this.textBoxIDConsulta.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDConsulta.Location = new System.Drawing.Point(60, 20);
            this.textBoxIDConsulta.Multiline = true;
            this.textBoxIDConsulta.Name = "textBoxIDConsulta";
            this.textBoxIDConsulta.Size = new System.Drawing.Size(39, 31);
            this.textBoxIDConsulta.TabIndex = 4;
            // 
            // labelHoraConsulta
            // 
            this.labelHoraConsulta.AutoSize = true;
            this.labelHoraConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelHoraConsulta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraConsulta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelHoraConsulta.Location = new System.Drawing.Point(684, 14);
            this.labelHoraConsulta.Name = "labelHoraConsulta";
            this.labelHoraConsulta.Size = new System.Drawing.Size(67, 25);
            this.labelHoraConsulta.TabIndex = 3;
            this.labelHoraConsulta.Text = "Hora";
            // 
            // labelFechaConsulta
            // 
            this.labelFechaConsulta.AutoSize = true;
            this.labelFechaConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaConsulta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaConsulta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelFechaConsulta.Location = new System.Drawing.Point(44, 84);
            this.labelFechaConsulta.Name = "labelFechaConsulta";
            this.labelFechaConsulta.Size = new System.Drawing.Size(76, 25);
            this.labelFechaConsulta.TabIndex = 2;
            this.labelFechaConsulta.Text = "Fecha";
            this.labelFechaConsulta.Click += new System.EventHandler(this.labelFechaConsulta_Click);
            // 
            // labelIDConsulta
            // 
            this.labelIDConsulta.AutoSize = true;
            this.labelIDConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelIDConsulta.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDConsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDConsulta.Location = new System.Drawing.Point(13, 26);
            this.labelIDConsulta.Name = "labelIDConsulta";
            this.labelIDConsulta.Size = new System.Drawing.Size(41, 25);
            this.labelIDConsulta.TabIndex = 1;
            this.labelIDConsulta.Text = "ID";
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.BackColor = System.Drawing.Color.Transparent;
            this.labelConsulta.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsulta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelConsulta.Location = new System.Drawing.Point(313, 3);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(142, 38);
            this.labelConsulta.TabIndex = 0;
            this.labelConsulta.Text = "Consulta";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.dataGridViewConsulta);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.GridColor = System.Drawing.Color.White;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(23, 122);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.Size = new System.Drawing.Size(750, 221);
            this.dataGridViewConsulta.TabIndex = 11;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(661, 369);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(112, 34);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // fConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabConsulta);
            this.Name = "fConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.fConsulta_Load);
            this.tabConsulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConsulta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxSintomaConsulta;
        private System.Windows.Forms.Label labelSintoma;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxHoraConsulta;
        private System.Windows.Forms.TextBox textBoxFechaConsulta;
        private System.Windows.Forms.TextBox textBoxIDConsulta;
        private System.Windows.Forms.Label labelHoraConsulta;
        private System.Windows.Forms.Label labelFechaConsulta;
        private System.Windows.Forms.Label labelIDConsulta;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewConsulta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox textBoxIDMedicoConsulta;
        private System.Windows.Forms.Label labelIDMedicoConsulta;
        private System.Windows.Forms.TextBox textBoxIDExpedienteConsulta;
        private System.Windows.Forms.TextBox textBoxDiagnosticoConsulta;
        private System.Windows.Forms.Label labelIDExpedienteConsulta;
        private System.Windows.Forms.Label labelDiagnosticoConsulta;
    }
}

