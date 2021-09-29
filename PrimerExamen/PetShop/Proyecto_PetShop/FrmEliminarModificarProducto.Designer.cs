
namespace PetShop
{
    partial class FrmEliminarModificarProducto
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnAplicarCambios = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.nupIdProductos = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.nudStockSumar = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSumar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupIdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockSumar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Location = new System.Drawing.Point(428, 128);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderText = "Ingrese la nueva marca";
            this.txtMarca.Size = new System.Drawing.Size(389, 23);
            this.txtMarca.TabIndex = 73;
            this.txtMarca.Visible = false;
            // 
            // btnAplicarCambios
            // 
            this.btnAplicarCambios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAplicarCambios.BackColor = System.Drawing.Color.DimGray;
            this.btnAplicarCambios.FlatAppearance.BorderSize = 0;
            this.btnAplicarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAplicarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarCambios.Location = new System.Drawing.Point(42, 256);
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
            this.txtNombre.Location = new System.Drawing.Point(428, 76);
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
            this.lblInfo.Location = new System.Drawing.Point(254, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(259, 21);
            this.lblInfo.TabIndex = 67;
            this.lblInfo.Text = "No se encontraron coincidencias";
            this.lblInfo.Visible = false;
            // 
            // nupIdProductos
            // 
            this.nupIdProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nupIdProductos.Location = new System.Drawing.Point(72, 103);
            this.nupIdProductos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupIdProductos.Name = "nupIdProductos";
            this.nupIdProductos.Size = new System.Drawing.Size(100, 23);
            this.nupIdProductos.TabIndex = 66;
            this.nupIdProductos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(273, 246);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 53;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.Visible = false;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(273, 364);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 20);
            this.lblStock.TabIndex = 56;
            this.lblStock.Text = "Stock";
            this.lblStock.Visible = false;
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(273, 306);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 20);
            this.lblPeso.TabIndex = 54;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Visible = false;
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(273, 131);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 52;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(273, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 51;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
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
            this.lblTitulo.Size = new System.Drawing.Size(106, 30);
            this.lblTitulo.TabIndex = 50;
            this.lblTitulo.Text = "Productos";
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(428, 243);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(389, 23);
            this.nudPrecio.TabIndex = 89;
            this.nudPrecio.Visible = false;
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(428, 303);
            this.nudPeso.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(389, 23);
            this.nudPeso.TabIndex = 90;
            this.nudPeso.Visible = false;
            // 
            // nudStock
            // 
            this.nudStock.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStock.Location = new System.Drawing.Point(428, 361);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(188, 23);
            this.nudStock.TabIndex = 91;
            this.nudStock.Visible = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DimGray;
            this.panel14.Location = new System.Drawing.Point(252, 420);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(583, 2);
            this.panel14.TabIndex = 168;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(837, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 365);
            this.panel1.TabIndex = 170;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMostrar.Location = new System.Drawing.Point(273, 131);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(96, 32);
            this.lblMostrar.TabIndex = 169;
            this.lblMostrar.Text = "Mostrar";
            this.lblMostrar.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(254, 56);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 365);
            this.panel11.TabIndex = 167;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(254, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(583, 2);
            this.panel8.TabIndex = 166;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(2, 302);
            this.panel10.TabIndex = 49;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "No binario"});
            this.cmbTipo.Location = new System.Drawing.Point(428, 186);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(389, 23);
            this.cmbTipo.TabIndex = 171;
            this.cmbTipo.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(273, 189);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 172;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Visible = false;
            // 
            // nudStockSumar
            // 
            this.nudStockSumar.Location = new System.Drawing.Point(622, 361);
            this.nudStockSumar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStockSumar.Name = "nudStockSumar";
            this.nudStockSumar.Size = new System.Drawing.Size(195, 23);
            this.nudStockSumar.TabIndex = 173;
            this.nudStockSumar.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(502, 387);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 174;
            this.lblTotal.Text = "Total";
            this.lblTotal.Visible = false;
            // 
            // lblSumar
            // 
            this.lblSumar.AutoSize = true;
            this.lblSumar.Location = new System.Drawing.Point(694, 387);
            this.lblSumar.Name = "lblSumar";
            this.lblSumar.Size = new System.Drawing.Size(41, 15);
            this.lblSumar.TabIndex = 175;
            this.lblSumar.Text = "Sumar";
            this.lblSumar.Visible = false;
            // 
            // FrmEliminarModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.lblSumar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.nudStockSumar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnAplicarCambios);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.nupIdProductos);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminarModificarProducto";
            this.Text = "FrmEliminarModificarProducto";
            this.Load += new System.EventHandler(this.FrmEliminarModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupIdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStockSumar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnAplicarCambios;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.NumericUpDown nupIdProductos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.NumericUpDown nudStockSumar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSumar;
    }
}