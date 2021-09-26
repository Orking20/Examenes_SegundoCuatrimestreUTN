using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PetShop
{
    public partial class FrmLogin : Form
    {
        Dictionary<string, string> usuarios;

        public FrmLogin()
        {
            InitializeComponent();

            usuarios = new Dictionary<string, string>();

            usuarios.Add("Tatiana", "jinjer123");
            usuarios.Add("Eduardo", "pizza");
            usuarios.Add("Mauro", "HackerMan27");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuarios.ContainsKey(txtUsuario.Text) && txtPass.Text == usuarios[txtUsuario.Text])
            {
                new FrmMenu().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre y/o contraseña incorrecta", "Error al ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cierra la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimiza la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Borra lo que estuviera escrito en donde va el usuario y la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = String.Empty;
            txtPass.Text = String.Empty;
        }
    }
}
