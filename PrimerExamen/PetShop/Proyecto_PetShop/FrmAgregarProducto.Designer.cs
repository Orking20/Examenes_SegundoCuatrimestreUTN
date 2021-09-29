
namespace PetShop
{
    partial class FrmAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProducto));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lstTipo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(91, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(202, 32);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Agregar producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(91, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStock.Location = new System.Drawing.Point(362, 267);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 20);
            this.lblStock.TabIndex = 29;
            this.lblStock.Text = "Stock";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeso.Location = new System.Drawing.Point(362, 193);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 20);
            this.lblPeso.TabIndex = 28;
            this.lblPeso.Text = "Peso";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrecio.Location = new System.Drawing.Point(362, 119);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(50, 20);
            this.lblPrecio.TabIndex = 25;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMarca.Location = new System.Drawing.Point(91, 193);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(91, 119);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.DimGray;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Location = new System.Drawing.Point(704, 357);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(128, 33);
            this.btnAgregarProducto.TabIndex = 26;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // nudStock
            // 
            this.nudStock.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStock.Location = new System.Drawing.Point(362, 290);
            this.nudStock.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(159, 23);
            this.nudStock.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightSlateGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(362, 142);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(159, 23);
            this.nudPrecio.TabIndex = 33;
            // 
            // nudPeso
            // 
            this.nudPeso.DecimalPlaces = 2;
            this.nudPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPeso.Location = new System.Drawing.Point(362, 216);
            this.nudPeso.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(159, 23);
            this.nudPeso.TabIndex = 34;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(91, 216);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 23);
            this.txtMarca.TabIndex = 19;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(629, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 20);
            this.lblTipo.TabIndex = 35;
            this.lblTipo.Text = "Tipo";
            // 
            // lstTipo
            // 
            this.lstTipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.ItemHeight = 17;
            this.lstTipo.Location = new System.Drawing.Point(629, 141);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(154, 72);
            this.lstTipo.TabIndex = 56;
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.lstTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.nudPeso);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarProducto";
            this.Text = "FrmAgregarProducto";
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ListBox lstTipo;
    }
}