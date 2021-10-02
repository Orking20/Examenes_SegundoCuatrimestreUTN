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
    public partial class FrmAltaAdministrador : Form
    {
        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmAltaAdministrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaAdministrador_Load(object sender, EventArgs e)
        {
            this.lstPuesto.DataSource = Enum.GetValues(typeof(EPuesto));
            this.cmbSexo.Text = "Masculino";

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region Botones
        /// <summary>
        /// Crea un administrador con los datos ingresados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaAdministrador_Click(object sender, EventArgs e)
        {
            string usuario;
            string password;
            Random random = new Random();
            double sueldo;
            EPuesto puesto;
            string[] diasLaborales = new string[7];
            DateTime horarioEntrada;
            DateTime horarioSalida;
            string nombre;
            string apellido;
            long dni;
            string nacionalidad;
            string domicilio;
            DateTime fechaNacimiento;
            string sexo;
            Administrador administradorNuevo;

            if (double.TryParse(txtSueldo.Text, out sueldo) && Administrador.ValidarNombre(txtNombre.Text) &&
                Administrador.ValidarApellido(txtApellido.Text) &&
                long.TryParse(txtDni.Text, out dni) && Administrador.ValidarDni(dni) &&
                Administrador.ValidarSexo(cmbSexo.SelectedItem.ToString()) &&
                Administrador.ValidarNacionalidad(txtNacionalidad.Text) &&
                Administrador.ValidarDomicilio(txtDomicilio.Text))
            {
                usuario = txtUsuario.Text;
                password = random.Next(100000, 999999).ToString();
                puesto = (EPuesto)lstPuesto.SelectedItem;

                for (int i = 0; i < 7; i++)
                {
                    if (cklDiasLaborales.GetItemChecked(i))
                    {
                        switch (cklDiasLaborales.GetItemText(i))
                        {
                            case "0":
                                diasLaborales[i] = "L";
                                break;
                            case "1":
                                diasLaborales[i] = "Ma";
                                break;
                            case "2":
                                diasLaborales[i] = "Mi";
                                break;
                            case "3":
                                diasLaborales[i] = "J";
                                break;
                            case "4":
                                diasLaborales[i] = "V";
                                break;
                            case "5":
                                diasLaborales[i] = "S";
                                break;
                            case "6":
                                diasLaborales[i] = "D";
                                break;
                        }
                    }
                }

                horarioEntrada = Convert.ToDateTime(mtxHoraEntrada.Text);
                horarioSalida = Convert.ToDateTime(mtxHoraSalida.Text);
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                nacionalidad = txtNacionalidad.Text;
                domicilio = txtDomicilio.Text;
                fechaNacimiento = ca1FechaNacimiento.SelectionStart.Date;
                sexo = cmbSexo.SelectedItem.ToString();

                administradorNuevo = Administrador.AltaAdministrador(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);
                FrmLogin.Administradores.Add(administradorNuevo);
                FrmLogin.Usuarios.Add(usuario, password);
                ReproducirSonidoExito();

                MessageBox.Show($"Esta es la contraseña para el usuario {usuario}: {password}\nEscribala y asegúrese de cambiarla", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Uno o varios de los datos ingresados no son válidos\nRevise y corrija los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Borra cualquier cosa escrita en los textBox y desmarca las casillas de días
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDni.Text = string.Empty;
            txtNacionalidad.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtSueldo.Text = string.Empty;
            mtxHoraEntrada.Text = string.Empty;
            mtxHoraSalida.Text = string.Empty;
            for (int i = 0; i < 7; i++)
            {
                cklDiasLaborales.SetItemChecked(i, false);
            }
            ReproducirSonidoBoton();
        }
        #endregion

        #region Sonido
        /// <summary>
        /// Reproduce un sonido indicando que todo salió correctamente
        /// </summary>
        private void ReproducirSonidoExito()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Exito.wav");
            sonido.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando que algo falló
        /// </summary>
        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Boton.wav");
            sonido.Play();
        }
        #endregion
    }
}
