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
using Entidades;

namespace PetShop
{
    public partial class FrmAltaCliente : Form
    {
        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            this.cmbSexo.Text = "Masculino";

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region Botones
        /// <summary>
        /// Crea un cliente con los datos ingresados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            double sueldo;
            string nombre;
            string apellido;
            DateTime fechaNacimiento;
            long dni;
            string sexo;
            string nacionalidad;
            string domicilio;
            Cliente clienteNuevo;
            Random sueldoRandom = new Random();

            if (long.TryParse(txtDni.Text, out dni) && Persona.ValidarDni(dni) &&
                Persona.ValidarNombre(txtNombre.Text) &&
                Persona.ValidarApellido(txtApellido.Text)
                && Persona.ValidarSexo(cmbSexo.SelectedItem.ToString())
                && Persona.ValidarNacionalidad(txtNacionalidad.Text)
                && Persona.ValidarDomicilio(txtDomicilio.Text))
            {
                nombre = txtNombre.Text;
                sueldo = sueldoRandom.Next(50000);
                apellido = txtApellido.Text;
                fechaNacimiento = ca1FechaNacimiento.SelectionStart.Date;
                sexo = cmbSexo.SelectedItem.ToString();
                nacionalidad = txtNacionalidad.Text;
                domicilio = txtDomicilio.Text;
            
                clienteNuevo = Empleado.AltaCliente(sueldo, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);
                FrmMenu.Clientes.Add(clienteNuevo);
                ReproducirSonidoExito();
            }
            else
            {
                MessageBox.Show("Uno o varios de los datos ingresados no son válidos\nRevise y corrija los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Borra cualquier cosa escrita en los textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            ReproducirSonidoBoton();
        }
        #endregion

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que todo salió correctamente
        /// </summary>
        private void ReproducirSonidoExito()
        {
            SoundPlayer sonidoExito = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Exito.wav");
            sonidoExito.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando que algo falló
        /// </summary>
        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonidoExito = new SoundPlayer(@"D:\UTN\Segundo cuatrimestre\Programacion II\Examenes\PrimerExamen\Sonidos\Boton.wav");
            sonidoExito.Play();
        }
        #endregion
    }
}
