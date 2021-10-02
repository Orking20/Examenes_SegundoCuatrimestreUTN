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
    public partial class FrmAltaEmpleado : Form
    {
        #region Carga de datos
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmAltaEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga algunos datos antes de mostrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaEmpleado_Load(object sender, EventArgs e)
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
        /// Crea un cliente con los datos ingresados por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaEmpleado_Click(object sender, EventArgs e)
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
            Empleado empleadoNuevo;

            if (double.TryParse(txtSueldo.Text, out sueldo) && Empleado.ValidarSueldo(sueldo) &&
                Empleado.ValidarNombre(txtNombre.Text) &&
                Empleado.ValidarApellido(txtApellido.Text) &&
                long.TryParse(txtDni.Text, out dni) && Empleado.ValidarDni(dni) &&
                Empleado.ValidarSexo(cmbSexo.SelectedItem.ToString()) &&
                Empleado.ValidarNacionalidad(txtNacionalidad.Text) &&
                Empleado.ValidarDomicilio(txtDomicilio.Text))
            {
                usuario = txtUsuario.Text;
                password = random.Next(100000, 999999).ToString();
                puesto = (EPuesto)lstPuesto.SelectedItem;
                horarioEntrada = Convert.ToDateTime(mtxHoraEntrada.Text);
                horarioSalida = Convert.ToDateTime(mtxHoraSalida.Text);
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                nacionalidad = txtNacionalidad.Text;
                domicilio = txtDomicilio.Text;
                fechaNacimiento = ca1FechaNacimiento.SelectionStart.Date;
                sexo = cmbSexo.SelectedItem.ToString();

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

                if (puesto == EPuesto.administrador)
                {
                    empleadoNuevo = Administrador.AltaAdministrador(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);
                    FrmLogin.Administradores.Add((Administrador)empleadoNuevo);
                }
                else
                {
                    empleadoNuevo = Administrador.AltaEmpleado(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);
                    FrmLogin.Empleados.Add(empleadoNuevo);
                }
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
        /// Borra cualquier cosa escrita en los textBox y desmarca las casillas de los días
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
