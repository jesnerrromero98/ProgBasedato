namespace capapresentacionWF
{
    partial class Form1
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
            this.tabCita = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxIDMedicoCita = new System.Windows.Forms.TextBox();
            this.textBoxPrecioCita = new System.Windows.Forms.TextBox();
            this.labelIDMedicoCita = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxIDExpedienteCita = new System.Windows.Forms.TextBox();
            this.labelIDExpediente = new System.Windows.Forms.Label();
            this.textBoxHoraDisponibleCita = new System.Windows.Forms.TextBox();
            this.labellabelHoraDisponibleCita = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxTipoCita = new System.Windows.Forms.TextBox();
            this.textBoxFechaCita = new System.Windows.Forms.TextBox();
            this.textBoxIDCita = new System.Windows.Forms.TextBox();
            this.labelTipoCita = new System.Windows.Forms.Label();
            this.labelFechaCita = new System.Windows.Forms.Label();
            this.labelIDCita = new System.Windows.Forms.Label();
            this.labelCita = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscarExpediente = new System.Windows.Forms.Label();
            this.dataGridViewCita = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.tabCita.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCita)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCita
            // 
            this.tabCita.Controls.Add(this.tabPage1);
            this.tabCita.Controls.Add(this.tabPage2);
            this.tabCita.Location = new System.Drawing.Point(0, 0);
            this.tabCita.Name = "tabCita";
            this.tabCita.SelectedIndex = 0;
            this.tabCita.Size = new System.Drawing.Size(800, 451);
            this.tabCita.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.BackgroundImage = global::capapresentacionWF.Properties.Resources.logodental1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.textBoxIDMedicoCita);
            this.tabPage1.Controls.Add(this.textBoxPrecioCita);
            this.tabPage1.Controls.Add(this.labelIDMedicoCita);
            this.tabPage1.Controls.Add(this.labelPrecio);
            this.tabPage1.Controls.Add(this.textBoxIDExpedienteCita);
            this.tabPage1.Controls.Add(this.labelIDExpediente);
            this.tabPage1.Controls.Add(this.textBoxHoraDisponibleCita);
            this.tabPage1.Controls.Add(this.labellabelHoraDisponibleCita);
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxTipoCita);
            this.tabPage1.Controls.Add(this.textBoxFechaCita);
            this.tabPage1.Controls.Add(this.textBoxIDCita);
            this.tabPage1.Controls.Add(this.labelTipoCita);
            this.tabPage1.Controls.Add(this.labelFechaCita);
            this.tabPage1.Controls.Add(this.labelIDCita);
            this.tabPage1.Controls.Add(this.labelCita);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // textBoxIDMedicoCita
            // 
            this.textBoxIDMedicoCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDMedicoCita.Location = new System.Drawing.Point(145, 254);
            this.textBoxIDMedicoCita.Multiline = true;
            this.textBoxIDMedicoCita.Name = "textBoxIDMedicoCita";
            this.textBoxIDMedicoCita.Size = new System.Drawing.Size(154, 20);
            this.textBoxIDMedicoCita.TabIndex = 18;
            // 
            // textBoxPrecioCita
            // 
            this.textBoxPrecioCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxPrecioCita.ForeColor = System.Drawing.Color.Red;
            this.textBoxPrecioCita.Location = new System.Drawing.Point(651, 287);
            this.textBoxPrecioCita.Multiline = true;
            this.textBoxPrecioCita.Name = "textBoxPrecioCita";
            this.textBoxPrecioCita.Size = new System.Drawing.Size(118, 31);
            this.textBoxPrecioCita.TabIndex = 17;
            // 
            // labelIDMedicoCita
            // 
            this.labelIDMedicoCita.AutoSize = true;
            this.labelIDMedicoCita.BackColor = System.Drawing.Color.Transparent;
            this.labelIDMedicoCita.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDMedicoCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDMedicoCita.Location = new System.Drawing.Point(153, 287);
            this.labelIDMedicoCita.Name = "labelIDMedicoCita";
            this.labelIDMedicoCita.Size = new System.Drawing.Size(127, 25);
            this.labelIDMedicoCita.TabIndex = 16;
            this.labelIDMedicoCita.Text = "ID Medico";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.Color.Green;
            this.labelPrecio.Location = new System.Drawing.Point(563, 293);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(82, 25);
            this.labelPrecio.TabIndex = 15;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxIDExpedienteCita
            // 
            this.textBoxIDExpedienteCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDExpedienteCita.Location = new System.Drawing.Point(492, 184);
            this.textBoxIDExpedienteCita.Multiline = true;
            this.textBoxIDExpedienteCita.Name = "textBoxIDExpedienteCita";
            this.textBoxIDExpedienteCita.Size = new System.Drawing.Size(154, 20);
            this.textBoxIDExpedienteCita.TabIndex = 14;
            // 
            // labelIDExpediente
            // 
            this.labelIDExpediente.AutoSize = true;
            this.labelIDExpediente.BackColor = System.Drawing.Color.Transparent;
            this.labelIDExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDExpediente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDExpediente.Location = new System.Drawing.Point(487, 226);
            this.labelIDExpediente.Name = "labelIDExpediente";
            this.labelIDExpediente.Size = new System.Drawing.Size(169, 25);
            this.labelIDExpediente.TabIndex = 13;
            this.labelIDExpediente.Text = "ID Expediente";
            // 
            // textBoxHoraDisponibleCita
            // 
            this.textBoxHoraDisponibleCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxHoraDisponibleCita.Location = new System.Drawing.Point(481, 83);
            this.textBoxHoraDisponibleCita.Multiline = true;
            this.textBoxHoraDisponibleCita.Name = "textBoxHoraDisponibleCita";
            this.textBoxHoraDisponibleCita.Size = new System.Drawing.Size(152, 23);
            this.textBoxHoraDisponibleCita.TabIndex = 12;
            // 
            // labellabelHoraDisponibleCita
            // 
            this.labellabelHoraDisponibleCita.AutoSize = true;
            this.labellabelHoraDisponibleCita.BackColor = System.Drawing.Color.Transparent;
            this.labellabelHoraDisponibleCita.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellabelHoraDisponibleCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labellabelHoraDisponibleCita.Location = new System.Drawing.Point(476, 121);
            this.labellabelHoraDisponibleCita.Name = "labellabelHoraDisponibleCita";
            this.labellabelHoraDisponibleCita.Size = new System.Drawing.Size(191, 25);
            this.labellabelHoraDisponibleCita.TabIndex = 10;
            this.labellabelHoraDisponibleCita.Text = "Hora Disponible";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonGuardar.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(625, 368);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(142, 51);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxTipoCita
            // 
            this.textBoxTipoCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxTipoCita.Location = new System.Drawing.Point(145, 168);
            this.textBoxTipoCita.Multiline = true;
            this.textBoxTipoCita.Name = "textBoxTipoCita";
            this.textBoxTipoCita.Size = new System.Drawing.Size(154, 23);
            this.textBoxTipoCita.TabIndex = 6;
            // 
            // textBoxFechaCita
            // 
            this.textBoxFechaCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxFechaCita.Location = new System.Drawing.Point(138, 83);
            this.textBoxFechaCita.Multiline = true;
            this.textBoxFechaCita.Name = "textBoxFechaCita";
            this.textBoxFechaCita.Size = new System.Drawing.Size(161, 24);
            this.textBoxFechaCita.TabIndex = 5;
            // 
            // textBoxIDCita
            // 
            this.textBoxIDCita.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxIDCita.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxIDCita.Location = new System.Drawing.Point(66, 17);
            this.textBoxIDCita.Name = "textBoxIDCita";
            this.textBoxIDCita.Size = new System.Drawing.Size(43, 28);
            this.textBoxIDCita.TabIndex = 4;
            // 
            // labelTipoCita
            // 
            this.labelTipoCita.AutoSize = true;
            this.labelTipoCita.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoCita.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTipoCita.Location = new System.Drawing.Point(184, 209);
            this.labelTipoCita.Name = "labelTipoCita";
            this.labelTipoCita.Size = new System.Drawing.Size(62, 25);
            this.labelTipoCita.TabIndex = 3;
            this.labelTipoCita.Text = "Tipo";
            // 
            // labelFechaCita
            // 
            this.labelFechaCita.AutoSize = true;
            this.labelFechaCita.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaCita.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFechaCita.Location = new System.Drawing.Point(153, 121);
            this.labelFechaCita.Name = "labelFechaCita";
            this.labelFechaCita.Size = new System.Drawing.Size(127, 25);
            this.labelFechaCita.TabIndex = 2;
            this.labelFechaCita.Text = "Fecha Cita";
            // 
            // labelIDCita
            // 
            this.labelIDCita.AutoSize = true;
            this.labelIDCita.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDCita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIDCita.Location = new System.Drawing.Point(19, 20);
            this.labelIDCita.Name = "labelIDCita";
            this.labelIDCita.Size = new System.Drawing.Size(41, 25);
            this.labelIDCita.TabIndex = 1;
            this.labelIDCita.Text = "ID";
            // 
            // labelCita
            // 
            this.labelCita.AutoSize = true;
            this.labelCita.BackColor = System.Drawing.Color.Transparent;
            this.labelCita.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCita.ForeColor = System.Drawing.Color.DarkGray;
            this.labelCita.Location = new System.Drawing.Point(358, 3);
            this.labelCita.Name = "labelCita";
            this.labelCita.Size = new System.Drawing.Size(85, 42);
            this.labelCita.TabIndex = 0;
            this.labelCita.Text = "Cita";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscarExpediente);
            this.tabPage2.Controls.Add(this.dataGridViewCita);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEditar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(683, 6);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(90, 34);
            this.buttonEditar.TabIndex = 15;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonBuscar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Location = new System.Drawing.Point(587, 6);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(90, 34);
            this.buttonBuscar.TabIndex = 14;
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
            this.textBoxBuscar.TabIndex = 13;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscarExpediente
            // 
            this.labelBuscarExpediente.AutoSize = true;
            this.labelBuscarExpediente.BackColor = System.Drawing.Color.Transparent;
            this.labelBuscarExpediente.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscarExpediente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBuscarExpediente.Location = new System.Drawing.Point(93, 69);
            this.labelBuscarExpediente.Name = "labelBuscarExpediente";
            this.labelBuscarExpediente.Size = new System.Drawing.Size(86, 25);
            this.labelBuscarExpediente.TabIndex = 12;
            this.labelBuscarExpediente.Text = "Buscar";
            // 
            // dataGridViewCita
            // 
            this.dataGridViewCita.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridViewCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCita.GridColor = System.Drawing.Color.White;
            this.dataGridViewCita.Location = new System.Drawing.Point(23, 122);
            this.dataGridViewCita.Name = "dataGridViewCita";
            this.dataGridViewCita.Size = new System.Drawing.Size(750, 221);
            this.dataGridViewCita.TabIndex = 11;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonEliminar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Location = new System.Drawing.Point(653, 382);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(112, 34);
            this.buttonEliminar.TabIndex = 10;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCita.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCita;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxIDMedicoCita;
        private System.Windows.Forms.TextBox textBoxPrecioCita;
        private System.Windows.Forms.Label labelIDMedicoCita;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxIDExpedienteCita;
        private System.Windows.Forms.Label labelIDExpediente;
        private System.Windows.Forms.TextBox textBoxHoraDisponibleCita;
        private System.Windows.Forms.Label labellabelHoraDisponibleCita;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxTipoCita;
        private System.Windows.Forms.TextBox textBoxFechaCita;
        private System.Windows.Forms.TextBox textBoxIDCita;
        private System.Windows.Forms.Label labelTipoCita;
        private System.Windows.Forms.Label labelFechaCita;
        private System.Windows.Forms.Label labelIDCita;
        private System.Windows.Forms.Label labelCita;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscarExpediente;
        private System.Windows.Forms.DataGridView dataGridViewCita;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

