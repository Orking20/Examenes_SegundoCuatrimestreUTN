
namespace PetShop
{
    partial class FrmAltaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaAdministrador));
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lstPuesto = new System.Windows.Forms.ListBox();
            this.cklDiasLaborales = new System.Windows.Forms.CheckedListBox();
            this.mtxHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.mtxHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lblDiasLaborales = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.ca1FechaNacimiento = new System.Windows.Forms.MonthCalendar();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAltaEmpleado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEmpleado.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmpleado
            // 
            this.grpEmpleado.Controls.Add(this.lblInfo);
            this.grpEmpleado.Controls.Add(this.lblUsuario);
            this.grpEmpleado.Controls.Add(this.txtUsuario);
            this.grpEmpleado.Controls.Add(this.lstPuesto);
            this.grpEmpleado.Controls.Add(this.cklDiasLaborales);
            this.grpEmpleado.Controls.Add(this.mtxHoraSalida);
            this.grpEmpleado.Controls.Add(this.mtxHoraEntrada);
            this.grpEmpleado.Controls.Add(this.lblDiasLaborales);
            this.grpEmpleado.Controls.Add(this.lblHoraSalida);
            this.grpEmpleado.Controls.Add(this.lblHoraEntrada);
            this.grpEmpleado.Controls.Add(this.lblPuesto);
            this.grpEmpleado.Controls.Add(this.lblSueldo);
            this.grpEmpleado.Controls.Add(this.txtSueldo);
            this.grpEmpleado.Location = new System.Drawing.Point(485, 90);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(416, 275);
            this.grpEmpleado.TabIndex = 40;
            this.grpEmpleado.TabStop = false;
            this.grpEmpleado.Text = "Datos profesionales";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(14, 254);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(181, 12);
            this.lblInfo.TabIndex = 58;
            this.lblInfo.Text = "(Usted tiene acceso a todos los puestos)";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsuario.Location = new System.Drawing.Point(14, 19);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 57;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(14, 42);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese el usuario";
            this.txtUsuario.Size = new System.Drawing.Size(154, 23);
            this.txtUsuario.TabIndex = 56;
            // 
            // lstPuesto
            // 
            this.lstPuesto.Enabled = false;
            this.lstPuesto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPuesto.FormattingEnabled = true;
            this.lstPuesto.ItemHeight = 17;
            this.lstPuesto.Location = new System.Drawing.Point(14, 179);
            this.lstPuesto.Name = "lstPuesto";
            this.lstPuesto.Size = new System.Drawing.Size(154, 72);
            this.lstPuesto.TabIndex = 55;
            // 
            // cklDiasLaborales
            // 
            this.cklDiasLaborales.CheckOnClick = true;
            this.cklDiasLaborales.FormattingEnabled = true;
            this.cklDiasLaborales.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.cklDiasLaborales.Location = new System.Drawing.Point(219, 55);
            this.cklDiasLaborales.Name = "cklDiasLaborales";
            this.cklDiasLaborales.Size = new System.Drawing.Size(154, 94);
            this.cklDiasLaborales.TabIndex = 54;
            // 
            // mtxHoraSalida
            // 
            this.mtxHoraSalida.Location = new System.Drawing.Point(219, 228);
            this.mtxHoraSalida.Mask = "00:00";
            this.mtxHoraSalida.Name = "mtxHoraSalida";
            this.mtxHoraSalida.Size = new System.Drawing.Size(154, 23);
            this.mtxHoraSalida.TabIndex = 53;
            this.mtxHoraSalida.ValidatingType = typeof(System.DateTime);
            // 
            // mtxHoraEntrada
            // 
            this.mtxHoraEntrada.Location = new System.Drawing.Point(219, 179);
            this.mtxHoraEntrada.Mask = "00:00";
            this.mtxHoraEntrada.Name = "mtxHoraEntrada";
            this.mtxHoraEntrada.Size = new System.Drawing.Size(154, 23);
            this.mtxHoraEntrada.TabIndex = 52;
            this.mtxHoraEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lblDiasLaborales
            // 
            this.lblDiasLaborales.AutoSize = true;
            this.lblDiasLaborales.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiasLaborales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiasLaborales.Location = new System.Drawing.Point(219, 32);
            this.lblDiasLaborales.Name = "lblDiasLaborales";
            this.lblDiasLaborales.Size = new System.Drawing.Size(103, 20);
            this.lblDiasLaborales.TabIndex = 51;
            this.lblDiasLaborales.Text = "Días laborales";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraSalida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoraSalida.Location = new System.Drawing.Point(219, 205);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(85, 20);
            this.lblHoraSalida.TabIndex = 46;
            this.lblHoraSalida.Text = "Hora salida";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraEntrada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHoraEntrada.Location = new System.Drawing.Point(219, 156);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(97, 20);
            this.lblHoraEntrada.TabIndex = 44;
            this.lblHoraEntrada.Text = "Hora entrada";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPuesto.Location = new System.Drawing.Point(14, 156);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(53, 20);
            this.lblPuesto.TabIndex = 39;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSueldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSueldo.Location = new System.Drawing.Point(14, 90);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(55, 20);
            this.lblSueldo.TabIndex = 37;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(14, 113);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PlaceholderText = "Ingrese el sueldo";
            this.txtSueldo.Size = new System.Drawing.Size(154, 23);
            this.txtSueldo.TabIndex = 36;
            // 
            // grpPersonal
            // 
            this.grpPersonal.Controls.Add(this.lblNombre);
            this.grpPersonal.Controls.Add(this.txtNombre);
            this.grpPersonal.Controls.Add(this.txtApellido);
            this.grpPersonal.Controls.Add(this.cmbSexo);
            this.grpPersonal.Controls.Add(this.lblSexo);
            this.grpPersonal.Controls.Add(this.lblApellido);
            this.grpPersonal.Controls.Add(this.txtDomicilio);
            this.grpPersonal.Controls.Add(this.lblDomicilio);
            this.grpPersonal.Controls.Add(this.lblDni);
            this.grpPersonal.Controls.Add(this.txtNacionalidad);
            this.grpPersonal.Controls.Add(this.txtDni);
            this.grpPersonal.Controls.Add(this.lblFechaNacimiento);
            this.grpPersonal.Controls.Add(this.lblNacionalidad);
            this.grpPersonal.Controls.Add(this.ca1FechaNacimiento);
            this.grpPersonal.Location = new System.Drawing.Point(12, 90);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(456, 275);
            this.grpPersonal.TabIndex = 39;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(6, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese el nombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(6, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese el apellido";
            this.txtApellido.Size = new System.Drawing.Size(154, 23);
            this.txtApellido.TabIndex = 19;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No binario"});
            this.cmbSexo.Location = new System.Drawing.Point(196, 238);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(160, 23);
            this.cmbSexo.TabIndex = 23;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSexo.Location = new System.Drawing.Point(196, 215);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 29;
            this.lblSexo.Text = "Sexo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApellido.Location = new System.Drawing.Point(6, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 24;
            this.lblApellido.Text = "Apellido";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(6, 238);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PlaceholderText = "Ingrese el domicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(154, 23);
            this.txtDomicilio.TabIndex = 22;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDomicilio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDomicilio.Location = new System.Drawing.Point(6, 215);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(74, 20);
            this.lblDomicilio.TabIndex = 31;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDni.Location = new System.Drawing.Point(6, 117);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 20);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "DNI";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(6, 189);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PlaceholderText = "Ingrese la nacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(154, 23);
            this.txtNacionalidad.TabIndex = 21;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(6, 140);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese el DNI";
            this.txtDni.Size = new System.Drawing.Size(154, 23);
            this.txtDni.TabIndex = 20;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(196, 19);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(146, 20);
            this.lblFechaNacimiento.TabIndex = 28;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNacionalidad.Location = new System.Drawing.Point(6, 166);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(98, 20);
            this.lblNacionalidad.TabIndex = 30;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // ca1FechaNacimiento
            // 
            this.ca1FechaNacimiento.Location = new System.Drawing.Point(196, 48);
            this.ca1FechaNacimiento.Name = "ca1FechaNacimiento";
            this.ca1FechaNacimiento.TabIndex = 25;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(91, 381);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 23);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(91, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(209, 32);
            this.lblTitulo.TabIndex = 37;
            this.lblTitulo.Text = "Alta administrador";
            // 
            // btnAltaEmpleado
            // 
            this.btnAltaEmpleado.BackColor = System.Drawing.Color.DimGray;
            this.btnAltaEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAltaEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAltaEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaEmpleado.Location = new System.Drawing.Point(704, 371);
            this.btnAltaEmpleado.Name = "btnAltaEmpleado";
            this.btnAltaEmpleado.Size = new System.Drawing.Size(128, 33);
            this.btnAltaEmpleado.TabIndex = 36;
            this.btnAltaEmpleado.Text = "Agregar empleado";
            this.btnAltaEmpleado.UseVisualStyleBackColor = false;
            this.btnAltaEmpleado.Click += new System.EventHandler(this.btnAltaEmpleado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(788, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAltaAdministrador
            // 
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpEmpleado);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAltaEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaAdministrador";
            this.Load += new System.EventHandler(this.FrmAltaAdministrador_Load);
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ListBox lstPuesto;
        private System.Windows.Forms.CheckedListBox cklDiasLaborales;
        private System.Windows.Forms.MaskedTextBox mtxHoraSalida;
        private System.Windows.Forms.MaskedTextBox mtxHoraEntrada;
        private System.Windows.Forms.Label lblDiasLaborales;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.MonthCalendar ca1FechaNacimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAltaEmpleado;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}