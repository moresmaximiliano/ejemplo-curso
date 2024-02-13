namespace desafio1
{
    partial class frmFichaContacto
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPerfilProfesional = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEstudios = new System.Windows.Forms.Label();
            this.txtEstudios = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtHobbit = new System.Windows.Forms.TextBox();
            this.lblHobbit = new System.Windows.Forms.Label();
            this.btnEnviarFormulario = new System.Windows.Forms.Button();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.btnVerificarCelular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(72, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblPerfilProfesional
            // 
            this.lblPerfilProfesional.AutoSize = true;
            this.lblPerfilProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilProfesional.Location = new System.Drawing.Point(37, 20);
            this.lblPerfilProfesional.Name = "lblPerfilProfesional";
            this.lblPerfilProfesional.Size = new System.Drawing.Size(219, 29);
            this.lblPerfilProfesional.TabIndex = 2;
            this.lblPerfilProfesional.Text = "Ficha de contacto";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(85, 218);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(126, 218);
            this.numEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(250, 20);
            this.numEdad.TabIndex = 2;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(85, 176);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo:";
            // 
            // cboSexo
            // 
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(126, 173);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(250, 21);
            this.cboSexo.TabIndex = 1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(126, 261);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(78, 261);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblEstudios
            // 
            this.lblEstudios.AutoSize = true;
            this.lblEstudios.Location = new System.Drawing.Point(431, 61);
            this.lblEstudios.Name = "lblEstudios";
            this.lblEstudios.Size = new System.Drawing.Size(213, 13);
            this.lblEstudios.TabIndex = 9;
            this.lblEstudios.Text = "Estudios (explayar cursos, universidad, etc):";
            // 
            // txtEstudios
            // 
            this.txtEstudios.Location = new System.Drawing.Point(434, 86);
            this.txtEstudios.Multiline = true;
            this.txtEstudios.Name = "txtEstudios";
            this.txtEstudios.Size = new System.Drawing.Size(294, 139);
            this.txtEstudios.TabIndex = 5;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(77, 308);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(126, 305);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(250, 20);
            this.txtCelular.TabIndex = 4;
            // 
            // txtHobbit
            // 
            this.txtHobbit.Location = new System.Drawing.Point(434, 287);
            this.txtHobbit.Multiline = true;
            this.txtHobbit.Name = "txtHobbit";
            this.txtHobbit.Size = new System.Drawing.Size(294, 135);
            this.txtHobbit.TabIndex = 6;
            // 
            // lblHobbit
            // 
            this.lblHobbit.AutoSize = true;
            this.lblHobbit.Location = new System.Drawing.Point(431, 261);
            this.lblHobbit.Name = "lblHobbit";
            this.lblHobbit.Size = new System.Drawing.Size(242, 13);
            this.lblHobbit.TabIndex = 14;
            this.lblHobbit.Text = "Ingrese actividades que realice en su tiempo libre:";
            // 
            // btnEnviarFormulario
            // 
            this.btnEnviarFormulario.Location = new System.Drawing.Point(147, 363);
            this.btnEnviarFormulario.Name = "btnEnviarFormulario";
            this.btnEnviarFormulario.Size = new System.Drawing.Size(170, 81);
            this.btnEnviarFormulario.TabIndex = 9;
            this.btnEnviarFormulario.Text = "Enviar formulario";
            this.btnEnviarFormulario.UseVisualStyleBackColor = true;
            this.btnEnviarFormulario.Click += new System.EventHandler(this.btnEnviarFormulario_Click);
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(22, 363);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(107, 38);
            this.btnSaludar.TabIndex = 7;
            this.btnSaludar.Text = "Saludo";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // btnVerificarCelular
            // 
            this.btnVerificarCelular.Location = new System.Drawing.Point(22, 407);
            this.btnVerificarCelular.Name = "btnVerificarCelular";
            this.btnVerificarCelular.Size = new System.Drawing.Size(107, 37);
            this.btnVerificarCelular.TabIndex = 8;
            this.btnVerificarCelular.Text = "Verificar celular";
            this.btnVerificarCelular.UseVisualStyleBackColor = true;
            this.btnVerificarCelular.Click += new System.EventHandler(this.btnVerificarCelular_Click);
            // 
            // frmFichaContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 472);
            this.Controls.Add(this.btnVerificarCelular);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.btnEnviarFormulario);
            this.Controls.Add(this.lblHobbit);
            this.Controls.Add(this.txtHobbit);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.txtEstudios);
            this.Controls.Add(this.lblEstudios);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblPerfilProfesional);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(835, 511);
            this.Name = "frmFichaContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario CV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPerfilProfesional;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEstudios;
        private System.Windows.Forms.TextBox txtEstudios;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtHobbit;
        private System.Windows.Forms.Label lblHobbit;
        private System.Windows.Forms.Button btnEnviarFormulario;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button btnVerificarCelular;
    }
}

