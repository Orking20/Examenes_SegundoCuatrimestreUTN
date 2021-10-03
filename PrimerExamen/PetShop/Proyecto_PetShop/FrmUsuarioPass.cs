using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmUsuarioPass : Form
    {
        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmUsuarioPass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuarioPass_Load(object sender, EventArgs e)
        {
            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region Boton
        /// <summary>
        /// Cambia la contraseña del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            if (FrmLogin.Usuarios.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Usuarios.Count; i++)
                {
                    if (FrmLogin.Usuarios.ContainsKey(txtUsuario.Text) && txtPassAntigua.Text == FrmLogin.Usuarios[txtUsuario.Text])
                    {
                        if (txtPassNueva.Text != string.Empty && txtPassConfirmar.Text  != string.Empty)
                        {
                            if (txtPassNueva.Text == txtPassConfirmar.Text)
                            {
                                FrmLogin.Usuarios[txtUsuario.Text] = txtPassNueva.Text;
                                lblInfo.Text = "Contraseña cambiada con éxito!";
                                lblInfo.Visible = true;
                                ReproducirSonidoExito();
                                break;
                            }
                            else
                            {
                                lblInfo.Text = "Las contraseñas no coinciden entre sí";
                                lblInfo.Visible = true;
                                ReproducirSonidoFallo();
                            }
                        }
                        else
                        {
                            lblInfo.Text = "Error! Escriba su nueva contraseña y confírmela por favor";
                            lblInfo.Visible = true;
                            ReproducirSonidoFallo();
                        }
                    }
                    else
                    {
                        lblInfo.Text = "El usuario y/o contraseña es incorrecta";
                        lblInfo.Visible = true;
                        ReproducirSonidoFallo();
                    }
                }
            }
            else
            {
                lblInfo.Text = "No hay usuarios registrados";
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }
        #endregion

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que todo funcionó correctamente
        /// </summary>
        private void ReproducirSonidoExito()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Exito.wav");
            sonido.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando que hubo un error
        /// </summary>
        private void ReproducirSonidoFallo()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Fallo.wav");
            sonido.Play();
        }
        #endregion

    }
}
