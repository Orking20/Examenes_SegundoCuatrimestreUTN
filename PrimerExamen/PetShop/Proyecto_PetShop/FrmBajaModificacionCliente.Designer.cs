
namespace PetShop
{
    partial class FrmBajaModificacionCliente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.nupIdClientes = new System.Windows.Forms.NumericUpDown();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAplicarCambios = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdClientes)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(86, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clientes";
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
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // nupIdClientes
            // 
            this.nupIdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupIdClientes.Location = new System.Drawing.Point(72, 103);
            this.nupIdClientes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupIdClientes.Name = "nupIdClientes";
            this.nupIdClientes.Size = new System.Drawing.Size(100, 23);
            this.nupIdClientes.TabIndex = 27;
            this.nupIdClientes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(254, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(259, 21);
            this.lblInfo.TabIndex = 28;
            this.lblInfo.Text = "No se encontraron coincidencias";
            this.lblInfo.Visible = false;
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
            this.lblId.TabIndex = 29;
            this.lblId.Text = "ID";
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
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAplicarCambios.TabIndex = 33;
            this.btnAplicarCambios.Text = "Aplicar cambios";
            this.btnAplicarCambios.UseVisualStyleBackColor = false;
            this.btnAplicarCambios.Visible = false;
            this.btnAplicarCambios.Click += new System.EventHandler(this.btnAplicarCambios_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DimGray;
            this.panel14.Location = new System.Drawing.Point(252, 416);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(583, 2);
            this.panel14.TabIndex = 140;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(837, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 365);
            this.panel1.TabIndex = 165;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDomicilio.Location = new System.Drawing.Point(273, 376);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(74, 20);
            this.lblDomicilio.TabIndex = 152;
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.Visible = false;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNacionalidad.Location = new System.Drawing.Point(273, 321);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(98, 20);
            this.lblNacionalidad.TabIndex = 151;
            this.lblNacionalidad.Text = "Nacionalidad";
            this.lblNacionalidad.Visible = false;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(273, 268);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(41, 20);
            this.lblSexo.TabIndex = 150;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Visible = false;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(273, 215);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 20);
            this.lblDni.TabIndex = 149;
            this.lblDni.Text = "DNI";
            this.lblDni.Visible = false;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(273, 166);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(146, 20);
            this.lblFechaNacimiento.TabIndex = 148;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            this.lblFechaNacimiento.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(273, 119);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 147;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(273, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 146;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDomicilio.Location = new System.Drawing.Point(442, 373);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.PlaceholderText = "Ingrese el nuevo domicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(389, 23);
            this.txtDomicilio.TabIndex = 144;
            this.txtDomicilio.Visible = false;
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
            this.cmbSexo.Location = new System.Drawing.Point(442, 265);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(389, 23);
            this.cmbSexo.TabIndex = 136;
            this.cmbSexo.Visible = false;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNacionalidad.Location = new System.Drawing.Point(442, 318);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.PlaceholderText = "Ingrese la nueva nacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(389, 23);
            this.txtNacionalidad.TabIndex = 135;
            this.txtNacionalidad.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDni.Location = new System.Drawing.Point(442, 215);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese el nuevo DNI";
            this.txtDni.Size = new System.Drawing.Size(389, 23);
            this.txtDni.TabIndex = 134;
            this.txtDni.Visible = false;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(442, 163);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PlaceholderText = "Ingrese la nueva fecha de nacimiento separadas por \'/\'";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(389, 23);
            this.txtFechaNacimiento.TabIndex = 133;
            this.txtFechaNacimiento.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Location = new System.Drawing.Point(442, 116);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese el nuevo apellido";
            this.txtApellido.Size = new System.Drawing.Size(389, 23);
            this.txtApellido.TabIndex = 132;
            this.txtApellido.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(442, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese el nuevo nombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 23);
            this.txtNombre.TabIndex = 131;
            this.txtNombre.Visible = false;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMostrar.Location = new System.Drawing.Point(262, 135);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(96, 32);
            this.lblMostrar.TabIndex = 145;
            this.lblMostrar.Text = "Mostrar";
            this.lblMostrar.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(254, 52);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 365);
            this.panel11.TabIndex = 138;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(254, 52);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(583, 2);
            this.panel8.TabIndex = 137;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 302);
            this.panel10.TabIndex = 49;
            // 
            // FrmBajaModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDomicilio);
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
            this.Controls.Add(this.nupIdClientes);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaModificacionCliente";
            this.Text = "FrmMostrarClientes";
            this.Load += new System.EventHandler(this.FrmBajaModificacionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupIdClientes)).EndInit();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.NumericUpDown nupIdClientes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAplicarCambios;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
    }
}