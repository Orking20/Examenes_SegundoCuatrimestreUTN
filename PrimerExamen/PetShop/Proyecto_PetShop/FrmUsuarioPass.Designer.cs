
namespace PetShop
{
    partial class FrmUsuarioPass
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassAntigua = new System.Windows.Forms.Label();
            this.txtPassAntigua = new System.Windows.Forms.TextBox();
            this.lblPassNueva = new System.Windows.Forms.Label();
            this.txtPassNueva = new System.Windows.Forms.TextBox();
            this.lblPassConfirmar = new System.Windows.Forms.Label();
            this.txtPassConfirmar = new System.Windows.Forms.TextBox();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(103, 153);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(103, 132);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassAntigua
            // 
            this.lblPassAntigua.AutoSize = true;
            this.lblPassAntigua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassAntigua.Location = new System.Drawing.Point(103, 224);
            this.lblPassAntigua.Name = "lblPassAntigua";
            this.lblPassAntigua.Size = new System.Drawing.Size(124, 20);
            this.lblPassAntigua.TabIndex = 3;
            this.lblPassAntigua.Text = "Password antigua";
            // 
            // txtPassAntigua
            // 
            this.txtPassAntigua.Location = new System.Drawing.Point(103, 245);
            this.txtPassAntigua.Name = "txtPassAntigua";
            this.txtPassAntigua.Size = new System.Drawing.Size(189, 23);
            this.txtPassAntigua.TabIndex = 2;
            // 
            // lblPassNueva
            // 
            this.lblPassNueva.AutoSize = true;
            this.lblPassNueva.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassNueva.Location = new System.Drawing.Point(560, 132);
            this.lblPassNueva.Name = "lblPassNueva";
            this.lblPassNueva.Size = new System.Drawing.Size(113, 20);
            this.lblPassNueva.TabIndex = 5;
            this.lblPassNueva.Text = "Password nueva";
            // 
            // txtPassNueva
            // 
            this.txtPassNueva.Location = new System.Drawing.Point(560, 153);
            this.txtPassNueva.Name = "txtPassNueva";
            this.txtPassNueva.Size = new System.Drawing.Size(189, 23);
            this.txtPassNueva.TabIndex = 4;
            // 
            // lblPassConfirmar
            // 
            this.lblPassConfirmar.AutoSize = true;
            this.lblPassConfirmar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassConfirmar.Location = new System.Drawing.Point(560, 224);
            this.lblPassConfirmar.Name = "lblPassConfirmar";
            this.lblPassConfirmar.Size = new System.Drawing.Size(142, 20);
            this.lblPassConfirmar.TabIndex = 7;
            this.lblPassConfirmar.Text = "Confirmar password";
            // 
            // txtPassConfirmar
            // 
            this.txtPassConfirmar.Location = new System.Drawing.Point(560, 245);
            this.txtPassConfirmar.Name = "txtPassConfirmar";
            this.txtPassConfirmar.Size = new System.Drawing.Size(189, 23);
            this.txtPassConfirmar.TabIndex = 6;
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Location = new System.Drawing.Point(362, 333);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(145, 43);
            this.btnCambiarPass.TabIndex = 8;
            this.btnCambiarPass.Text = "Cambiar password";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(103, 45);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(58, 25);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Error";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // FrmUsuarioPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(923, 442);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCambiarPass);
            this.Controls.Add(this.lblPassConfirmar);
            this.Controls.Add(this.txtPassConfirmar);
            this.Controls.Add(this.lblPassNueva);
            this.Controls.Add(this.txtPassNueva);
            this.Controls.Add(this.lblPassAntigua);
            this.Controls.Add(this.txtPassAntigua);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarioPass";
            this.Text = "FrmUsuarioPass";
            this.Load += new System.EventHandler(this.FrmUsuarioPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassAntigua;
        private System.Windows.Forms.TextBox txtPassAntigua;
        private System.Windows.Forms.Label lblPassNueva;
        private System.Windows.Forms.TextBox txtPassNueva;
        private System.Windows.Forms.Label lblPassConfirmar;
        private System.Windows.Forms.TextBox txtPassConfirmar;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.Label lblInfo;
    }
}