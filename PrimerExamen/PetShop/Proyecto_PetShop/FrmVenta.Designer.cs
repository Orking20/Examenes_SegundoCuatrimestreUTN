
namespace PetShop
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.nudIdClientes = new System.Windows.Forms.NumericUpDown();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.nudIdProducto = new System.Windows.Forms.NumericUpDown();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.lblStockProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblMarcaProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblInfoProducto = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblInfoCliente = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblVendido = new System.Windows.Forms.Label();
            this.grpDescripcion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrecioTotalProducto = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdProducto)).BeginInit();
            this.grpProducto.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.grpDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdCliente.Location = new System.Drawing.Point(52, 54);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(24, 20);
            this.lblIdCliente.TabIndex = 32;
            this.lblIdCliente.Text = "ID";
            // 
            // nudIdClientes
            // 
            this.nudIdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nudIdClientes.Location = new System.Drawing.Point(82, 56);
            this.nudIdClientes.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIdClientes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdClientes.Name = "nudIdClientes";
            this.nudIdClientes.Size = new System.Drawing.Size(100, 23);
            this.nudIdClientes.TabIndex = 31;
            this.nudIdClientes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdClientes.ValueChanged += new System.EventHandler(this.nudIdClientes_ValueChanged);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdProducto.Location = new System.Drawing.Point(18, 29);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(24, 20);
            this.lblIdProducto.TabIndex = 35;
            this.lblIdProducto.Text = "ID";
            // 
            // nudIdProducto
            // 
            this.nudIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nudIdProducto.Location = new System.Drawing.Point(48, 29);
            this.nudIdProducto.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudIdProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdProducto.Name = "nudIdProducto";
            this.nudIdProducto.Size = new System.Drawing.Size(100, 23);
            this.nudIdProducto.TabIndex = 34;
            this.nudIdProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIdProducto.ValueChanged += new System.EventHandler(this.nudIdProducto_ValueChanged);
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.lblStockTotal);
            this.grpProducto.Controls.Add(this.lblPrecio);
            this.grpProducto.Controls.Add(this.lblMarca);
            this.grpProducto.Controls.Add(this.lblNombreP);
            this.grpProducto.Controls.Add(this.lblStockProducto);
            this.grpProducto.Controls.Add(this.lblPrecioProducto);
            this.grpProducto.Controls.Add(this.lblMarcaProducto);
            this.grpProducto.Controls.Add(this.lblNombreProducto);
            this.grpProducto.Controls.Add(this.lblIdProducto);
            this.grpProducto.Controls.Add(this.nudIdProducto);
            this.grpProducto.Location = new System.Drawing.Point(315, 25);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(314, 330);
            this.grpProducto.TabIndex = 37;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockTotal.Location = new System.Drawing.Point(16, 267);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(50, 21);
            this.lblStockTotal.TabIndex = 43;
            this.lblStockTotal.Text = "Stock:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(16, 217);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 21);
            this.lblPrecio.TabIndex = 42;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(16, 164);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(56, 21);
            this.lblMarca.TabIndex = 41;
            this.lblMarca.Text = "Marca:";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreP.Location = new System.Drawing.Point(16, 113);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(71, 21);
            this.lblNombreP.TabIndex = 40;
            this.lblNombreP.Text = "Nombre:";
            // 
            // lblStockProducto
            // 
            this.lblStockProducto.AutoSize = true;
            this.lblStockProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockProducto.Location = new System.Drawing.Point(93, 267);
            this.lblStockProducto.Name = "lblStockProducto";
            this.lblStockProducto.Size = new System.Drawing.Size(47, 21);
            this.lblStockProducto.TabIndex = 39;
            this.lblStockProducto.Text = "Stock";
            this.lblStockProducto.Visible = false;
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioProducto.Location = new System.Drawing.Point(93, 217);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(53, 21);
            this.lblPrecioProducto.TabIndex = 38;
            this.lblPrecioProducto.Text = "Precio";
            this.lblPrecioProducto.Visible = false;
            // 
            // lblMarcaProducto
            // 
            this.lblMarcaProducto.AutoSize = true;
            this.lblMarcaProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaProducto.Location = new System.Drawing.Point(93, 164);
            this.lblMarcaProducto.Name = "lblMarcaProducto";
            this.lblMarcaProducto.Size = new System.Drawing.Size(53, 21);
            this.lblMarcaProducto.TabIndex = 37;
            this.lblMarcaProducto.Text = "Marca";
            this.lblMarcaProducto.Visible = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.Location = new System.Drawing.Point(93, 113);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(68, 21);
            this.lblNombreProducto.TabIndex = 36;
            this.lblNombreProducto.Text = "Nombre";
            this.lblNombreProducto.Visible = false;
            // 
            // lblInfoProducto
            // 
            this.lblInfoProducto.AutoSize = true;
            this.lblInfoProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoProducto.Location = new System.Drawing.Point(394, 9);
            this.lblInfoProducto.Name = "lblInfoProducto";
            this.lblInfoProducto.Size = new System.Drawing.Size(235, 20);
            this.lblInfoProducto.TabIndex = 39;
            this.lblInfoProducto.Text = "No se encontraron coincidencias";
            this.lblInfoProducto.Visible = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(92, 113);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(68, 21);
            this.lblNombreCliente.TabIndex = 31;
            this.lblNombreCliente.Text = "Nombre";
            this.lblNombreCliente.Visible = false;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoCliente.Location = new System.Drawing.Point(92, 189);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(67, 21);
            this.lblApellidoCliente.TabIndex = 32;
            this.lblApellidoCliente.Text = "Apellido";
            this.lblApellidoCliente.Visible = false;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDniCliente.Location = new System.Drawing.Point(92, 267);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(37, 21);
            this.lblDniCliente.TabIndex = 33;
            this.lblDniCliente.Text = "DNI";
            this.lblDniCliente.Visible = false;
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblDni);
            this.grpCliente.Controls.Add(this.lblApellido);
            this.grpCliente.Controls.Add(this.lblNombreC);
            this.grpCliente.Controls.Add(this.lblDniCliente);
            this.grpCliente.Controls.Add(this.lblApellidoCliente);
            this.grpCliente.Controls.Add(this.lblNombreCliente);
            this.grpCliente.Location = new System.Drawing.Point(12, 25);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(297, 330);
            this.grpCliente.TabIndex = 36;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(15, 267);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(40, 21);
            this.lblDni.TabIndex = 37;
            this.lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(15, 189);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 21);
            this.lblApellido.TabIndex = 36;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreC.Location = new System.Drawing.Point(15, 113);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(71, 21);
            this.lblNombreC.TabIndex = 35;
            this.lblNombreC.Text = "Nombre:";
            // 
            // lblInfoCliente
            // 
            this.lblInfoCliente.AutoSize = true;
            this.lblInfoCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoCliente.Location = new System.Drawing.Point(74, 9);
            this.lblInfoCliente.Name = "lblInfoCliente";
            this.lblInfoCliente.Size = new System.Drawing.Size(235, 20);
            this.lblInfoCliente.TabIndex = 34;
            this.lblInfoCliente.Text = "No se encontraron coincidencias";
            this.lblInfoCliente.Visible = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.DimGray;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(713, 361);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(171, 69);
            this.btnVender.TabIndex = 38;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblVendido
            // 
            this.lblVendido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVendido.Location = new System.Drawing.Point(315, 385);
            this.lblVendido.Name = "lblVendido";
            this.lblVendido.Size = new System.Drawing.Size(392, 20);
            this.lblVendido.TabIndex = 40;
            this.lblVendido.Text = "¡Vendido!";
            this.lblVendido.Visible = false;
            // 
            // grpDescripcion
            // 
            this.grpDescripcion.Controls.Add(this.pictureBox1);
            this.grpDescripcion.Controls.Add(this.lblPrecioTotalProducto);
            this.grpDescripcion.Controls.Add(this.nudStock);
            this.grpDescripcion.Controls.Add(this.lblStock);
            this.grpDescripcion.Controls.Add(this.lblPrecioTotal);
            this.grpDescripcion.Location = new System.Drawing.Point(635, 25);
            this.grpDescripcion.Name = "grpDescripcion";
            this.grpDescripcion.Size = new System.Drawing.Size(276, 330);
            this.grpDescripcion.TabIndex = 41;
            this.grpDescripcion.TabStop = false;
            this.grpDescripcion.Text = "Descripción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrecioTotalProducto
            // 
            this.lblPrecioTotalProducto.AutoSize = true;
            this.lblPrecioTotalProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTotalProducto.Location = new System.Drawing.Point(91, 217);
            this.lblPrecioTotalProducto.Name = "lblPrecioTotalProducto";
            this.lblPrecioTotalProducto.Size = new System.Drawing.Size(53, 21);
            this.lblPrecioTotalProducto.TabIndex = 42;
            this.lblPrecioTotalProducto.Text = "Precio";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(91, 268);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(120, 23);
            this.nudStock.TabIndex = 41;
            this.nudStock.ValueChanged += new System.EventHandler(this.nudStock_ValueChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(27, 267);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 21);
            this.lblStock.TabIndex = 40;
            this.lblStock.Text = "Stock";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioTotal.Location = new System.Drawing.Point(27, 217);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(53, 21);
            this.lblPrecioTotal.TabIndex = 39;
            this.lblPrecioTotal.Text = "Precio";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.grpDescripcion);
            this.Controls.Add(this.lblInfoCliente);
            this.Controls.Add(this.lblVendido);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblInfoProducto);
            this.Controls.Add(this.nudIdClientes);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdProducto)).EndInit();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpDescripcion.ResumeLayout(false);
            this.grpDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.NumericUpDown nudIdClientes;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.NumericUpDown nudIdProducto;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblMarcaProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblStockProducto;
        private System.Windows.Forms.Label lblInfoProducto;
        private System.Windows.Forms.Label lblInfoCliente;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblVendido;
        private System.Windows.Forms.GroupBox grpDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblPrecioTotalProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}