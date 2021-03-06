
namespace PetShop
{
    partial class FrmBajaModificacionEmpleado
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
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnAplicarCambios = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.nupIdEmpleado = new System.Windows.Forms.NumericUpDown();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.mtxHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mtxHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblDiasLaborales = new System.Windows.Forms.Label();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(259, 57);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 365);
            this.panel11.TabIndex = 88;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(259, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(583, 2);
            this.panel8.TabIndex = 86;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 302);
            this.panel10.TabIndex = 49;
            // 
            // cmbSexo
            // 
            this.cmbSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No binario"});
            this.cmbSexo.Location = new System.Drawing.Point(447, 180);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(389, 23);
            this.cmbSexo.TabIndex = 78;
            this.cmbSexo.Visible = false;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNacionalidad.Location = new System.Drawing.Point(447, 209);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PlaceholderText = "Ingrese la nueva nacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(389, 23);
            this.txtNacionalidad.TabIndex = 76;
            this.txtNacionalidad.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Location = new System.Drawing.Point(447, 151);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese el nuevo DNI";
            this.txtDni.Size = new System.Drawing.Size(389, 23);
            this.txtDni.TabIndex = 75;
            this.txtDni.Visible = false;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(447, 122);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PlaceholderText = "Ingrese la nueva fecha de nacimiento separadas por \'/\'";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(389, 23);
            this.txtFechaNacimiento.TabIndex = 74;
            this.txtFechaNacimiento.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Location = new System.Drawing.Point(447, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese el nuevo apellido";
            this.txtApellido.Size = new System.Drawing.Size(389, 23);
            this.txtApellido.TabIndex = 73;
            this.txtApellido.Visible = false;
            // 
            // btnAplicarCambios
            // 
            this.btnAplicarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAplicarCambios.BackColor = System.Drawing.Color.DimGray;
            this.btnAplicarCambios.FlatAppearance.BorderSize = 0;
            this.btnAplicarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAplicarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarCambios.Location = new System.Drawing.Point(42, 255);
            this.btnAplicarCambios.Name = "btnAplicarCambios";
            this.btnAplicarCambios.Size = new System.Drawing.Size(130, 23);
            this.btnAplicarCambios.TabIndex = 72;
            this.btnAplicarCambios.Text = "Aplicar cambios";
            this.btnAplicarCambios.UseVisualStyleBackColor = false;
            this.btnAplicarCambios.Visible = false;
            this.btnAplicarCambios.Click += new System.EventHandler(this.btnAplicarCambios_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(447, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese el nuevo nombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 23);
            this.txtNombre.TabIndex = 71;
            this.txtNombre.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(42, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 23);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.BackColor = System.Drawing.Color.DimGray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(42, 226);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 23);
            this.btnModificar.TabIndex = 69;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(42, 101);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 20);
            this.lblId.TabIndex = 68;
            this.lblId.Text = "ID";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(259, 16);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(259, 21);
            this.lblInfo.TabIndex = 67;
            this.lblInfo.Text = "No se encontraron coincidencias";
            this.lblInfo.Visible = false;
            // 
            // nupIdEmpleado
            // 
            this.nupIdEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupIdEmpleado.Location = new System.Drawing.Point(72, 103);
            this.nupIdEmpleado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupIdEmpleado.Name = "nupIdEmpleado";
            this.nupIdEmpleado.Size = new System.Drawing.Size(100, 23);
            this.nupIdEmpleado.TabIndex = 66;
            this.nupIdEmpleado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrar.BackColor = System.Drawing.Color.DimGray;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(42, 137);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(130, 23);
            this.btnMostrar.TabIndex = 58;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 30);
            this.lblTitulo.TabIndex = 50;
            this.lblTitulo.Text = "Empleados";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSueldo.Location = new System.Drawing.Point(447, 267);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.PlaceholderText = "Ingrese el nuevo sueldo";
            this.txtSueldo.Size = new System.Drawing.Size(389, 23);
            this.txtSueldo.TabIndex = 91;
            this.txtSueldo.Visible = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DimGray;
            this.panel14.Location = new System.Drawing.Point(257, 421);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(583, 2);
            this.panel14.TabIndex = 104;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No binario"});
            this.cmbPuesto.Location = new System.Drawing.Point(447, 296);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(389, 23);
            this.cmbPuesto.TabIndex = 105;
            this.cmbPuesto.Visible = false;
            // 
            // mtxHoraEntrada
            // 
            this.mtxHoraEntrada.Location = new System.Drawing.Point(447, 355);
            this.mtxHoraEntrada.Mask = "00:00";
            this.mtxHoraEntrada.Name = "mtxHoraEntrada";
            this.mtxHoraEntrada.Size = new System.Drawing.Size(389, 23);
            this.mtxHoraEntrada.TabIndex = 106;
            this.mtxHoraEntrada.ValidatingType = typeof(System.DateTime);
            this.mtxHoraEntrada.Visible = false;
            // 
            // mtxHoraSalida
            // 
            this.mtxHoraSalida.Location = new System.Drawing.Point(447, 384);
            this.mtxHoraSalida.Mask = "00:00";
            this.mtxHoraSalida.Name = "mtxHoraSalida";
            this.mtxHoraSalida.Size = new System.Drawing.Size(389, 23);
            this.mtxHoraSalida.TabIndex = 107;
            this.mtxHoraSalida.ValidatingType = typeof(System.DateTime);
            this.mtxHoraSalida.Visible = false;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDomicilio.Location = new System.Drawing.Point(447, 237);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PlaceholderText = "Ingrese el nuevo domicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(389, 23);
            this.txtDomicilio.TabIndex = 109;
            this.txtDomicilio.Visible = false;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMostrar.Location = new System.Drawing.Point(268, 66);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(96, 32);
            this.lblMostrar.TabIndex = 110;
            this.lblMostrar.Text = "Mostrar";
            this.lblMostrar.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(268, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 111;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(268, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 112;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Visible = false;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(268, 125);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(146, 20);
            this.lblFechaNacimiento.TabIndex = 113;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            this.lblFechaNacimiento.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(268, 154);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 20);
            this.lblDni.TabIndex = 114;
            this.lblDni.Text = "DNI";
            this.lblDni.Visible = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(268, 183);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 115;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Visible = false;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidad.Location = new System.Drawing.Point(268, 212);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(98, 20);
            this.lblNacionalidad.TabIndex = 116;
            this.lblNacionalidad.Text = "Nacionalidad";
            this.lblNacionalidad.Visible = false;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDomicilio.Location = new System.Drawing.Point(268, 240);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(74, 20);
            this.lblDomicilio.TabIndex = 117;
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.Visible = false;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSueldo.Location = new System.Drawing.Point(268, 270);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(55, 20);
            this.lblSueldo.TabIndex = 118;
            this.lblSueldo.Text = "Sueldo";
            this.lblSueldo.Visible = false;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPuesto.Location = new System.Drawing.Point(268, 299);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(53, 20);
            this.lblPuesto.TabIndex = 119;
            this.lblPuesto.Text = "Puesto";
            this.lblPuesto.Visible = false;
            // 
            // lblDiasLaborales
            // 
            this.lblDiasLaborales.AutoSize = true;
            this.lblDiasLaborales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiasLaborales.Location = new System.Drawing.Point(268, 328);
            this.lblDiasLaborales.Name = "lblDiasLaborales";
            this.lblDiasLaborales.Size = new System.Drawing.Size(103, 20);
            this.lblDiasLaborales.TabIndex = 120;
            this.lblDiasLaborales.Text = "Dias laborales";
            this.lblDiasLaborales.Visible = false;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLunes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkLunes.Location = new System.Drawing.Point(447, 324);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(32, 24);
            this.chkLunes.TabIndex = 121;
            this.chkLunes.Text = "L";
            this.chkLunes.UseVisualStyleBackColor = true;
            this.chkLunes.Visible = false;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraEntrada.Location = new System.Drawing.Point(268, 358);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(118, 20);
            this.lblHoraEntrada.TabIndex = 122;
            this.lblHoraEntrada.Text = "Hora de entrada";
            this.lblHoraEntrada.Visible = false;
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraSalida.Location = new System.Drawing.Point(268, 387);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(106, 20);
            this.lblHoraSalida.TabIndex = 123;
            this.lblHoraSalida.Text = "Hora de salida";
            this.lblHoraSalida.Visible = false;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMartes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMartes.Location = new System.Drawing.Point(503, 324);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(46, 24);
            this.chkMartes.TabIndex = 124;
            this.chkMartes.Text = "Ma";
            this.chkMartes.UseVisualStyleBackColor = true;
            this.chkMartes.Visible = false;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMiercoles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMiercoles.Location = new System.Drawing.Point(570, 324);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(42, 24);
            this.chkMiercoles.TabIndex = 125;
            this.chkMiercoles.Text = "Mi";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            this.chkMiercoles.Visible = false;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkJueves.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkJueves.Location = new System.Drawing.Point(635, 324);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(30, 24);
            this.chkJueves.TabIndex = 126;
            this.chkJueves.Text = "J";
            this.chkJueves.UseVisualStyleBackColor = true;
            this.chkJueves.Visible = false;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkViernes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkViernes.Location = new System.Drawing.Point(692, 324);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(34, 24);
            this.chkViernes.TabIndex = 127;
            this.chkViernes.Text = "V";
            this.chkViernes.UseVisualStyleBackColor = true;
            this.chkViernes.Visible = false;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSabado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSabado.Location = new System.Drawing.Point(750, 324);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(33, 24);
            this.chkSabado.TabIndex = 128;
            this.chkSabado.Text = "S";
            this.chkSabado.UseVisualStyleBackColor = true;
            this.chkSabado.Visible = false;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDomingo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkDomingo.Location = new System.Drawing.Point(804, 324);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(36, 24);
            this.chkDomingo.TabIndex = 129;
            this.chkDomingo.Text = "D";
            this.chkDomingo.UseVisualStyleBackColor = true;
            this.chkDomingo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(842, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 365);
            this.panel1.TabIndex = 130;
            // 
            // FrmBajaModificacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkDomingo);
            this.Controls.Add(this.chkSabado);
            this.Controls.Add(this.chkViernes);
            this.Controls.Add(this.chkJueves);
            this.Controls.Add(this.chkMiercoles);
            this.Controls.Add(this.chkMartes);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.chkLunes);
            this.Controls.Add(this.lblDiasLaborales);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.mtxHoraSalida);
            this.Controls.Add(this.mtxHoraEntrada);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnAplicarCambios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.nupIdEmpleado);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaModificacionEmpleado";
            this.Text = "FrmBajaModificacionEmpleado";
            this.Load += new System.EventHandler(this.FrmBajaModificacionEmpleado_Load);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupIdEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAplicarCambios;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown nupIdEmpleado;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.MaskedTextBox mtxHoraEntrada;
        private System.Windows.Forms.MaskedTextBox mtxHoraSalida;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblDiasLaborales;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.Panel panel1;
    }
}