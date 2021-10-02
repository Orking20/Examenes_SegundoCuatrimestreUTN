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
    public partial class FrmBajaModificacionEmpleado : Form
    {
        #region Carga de datos
        /// <summary>
        /// Inicializa los componentes gráficos de este formulario
        /// </summary>
        public FrmBajaModificacionEmpleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos cuando se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBajaModificacionEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(EPuesto));

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }
        #endregion

        #region BotonMostrar
        /// <summary>
        /// Muestra los datos del empleado con el ID ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Empleado empleado;

            if (FrmLogin.Empleados.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Empleados.Count; i++)
                {
                    empleado = FrmLogin.Empleados[i];

                    if (nupIdEmpleado.Value == empleado.IdEmpleado)
                    {
                        lblInfo.Visible = false;
                        OcultarLebel();
                        OcultarTextBox();
                        lblMostrar.Visible = true;
                        lblMostrar.Text = empleado.Mostrar();
                        ReproducirSonidoBoton();
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        lblMostrar.Visible = false;
                        OcultarLebel();
                        ReproducirSonidoFallo();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }
        #endregion

        #region BotonModificar_AplicarCambios
        /// <summary>
        /// Entra en el modo modificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (FrmLogin.Empleados.Count > 0)
            {
                OcultarLebel();
                MostrarLebel();
                MostrarTextBox();
                lblMostrar.Visible = false;
                btnAplicarCambios.Visible = true;
                ReproducirSonidoBoton();
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }

        /// <summary>
        /// Sobreescribe los datos deseados del empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            StringBuilder sb;

            for (int i = 0; i < FrmLogin.Empleados.Count; i++)
            {
                empleado = FrmLogin.Empleados[i];

                if (nupIdEmpleado.Value == empleado.IdEmpleado)
                {
                    lblInfo.Visible = false;

                    if (Validaciones(empleado, out sb))
                    {
                        MessageBox.Show($"Estos campos no son válidos.\nAsegurese de cambiarlos\n{sb}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("¿Seguro que desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            OcultarLebel();
                            OcultarTextBox();
                            LimpiarTextBox();
                            lblMostrar.Text = empleado.Mostrar();
                            lblMostrar.Visible = true;
                            ReproducirSonidoExito();
                            break;
                        }
                    }
                }
                else
                {
                    lblInfo.Visible = true;
                    ReproducirSonidoFallo();
                }
            }
        }
        #endregion

        #region BotonEliminar
        /// <summary>
        /// Elimina el empleado con el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado empleado;

            if (FrmLogin.Empleados.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Empleados.Count; i++)
                {
                    empleado = FrmLogin.Empleados[i];

                    if (nupIdEmpleado.Value == empleado.IdEmpleado)
                    {
                        lblInfo.Visible = false;

                        if (MessageBox.Show("¿Estás seguro que desea eliminar este empleado?\nEsta acción no se puede deshacer", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Administrador.BajaEmpleado(FrmLogin.Empleados, empleado);
                            OcultarLebel();
                            lblMostrar.Visible = false;
                            ReproducirSonidoExito();
                        }
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        ReproducirSonidoFallo();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoFallo();
            }
        }
        #endregion

        #region Validaciones
        private bool Validaciones(Empleado empleado, out StringBuilder sb)
        {
            bool error = false;
            long dni;
            double sueldo;
            sb = new StringBuilder();

            if (txtNombre.Text != string.Empty)
            {
                if (Empleado.ValidarNombre(txtNombre.Text))
                {
                    empleado.Nombre = txtNombre.Text;
                }
                else
                {
                    sb.AppendLine("Nombre");
                    error = true;
                }
            }
            if (txtApellido.Text != string.Empty)
            {
                if (Empleado.ValidarApellido(txtApellido.Text))
                {
                    empleado.Apellido = txtApellido.Text;
                }
                else
                {
                    sb.AppendLine("Apellido");
                    error = true;
                }
            }
            if (txtFechaNacimiento.Text != string.Empty)
            {
                if (Empleado.ValidarFechaNacimiento(txtFechaNacimiento.Text))
                {
                    empleado.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                }
                else
                {
                    sb.AppendLine("Fecha de nacimiento");
                    error = true;
                }
            }
            if (txtDni.Text != string.Empty)
            {
                if (long.TryParse(txtDni.Text, out dni) && Empleado.ValidarDni(dni))
                {
                    empleado.Dni = dni;
                }
                else
                {
                    sb.AppendLine("DNI");
                    error = true;
                }
            }
            if (cmbSexo.SelectedItem != null)
            {
                empleado.Sexo = cmbSexo.SelectedItem.ToString();
            }
            if (txtNacionalidad.Text != string.Empty)
            {
                if (Empleado.ValidarNacionalidad(txtNacionalidad.Text))
                {
                    empleado.Nacionalidad = txtNacionalidad.Text;
                }
                else
                {
                    sb.AppendLine("Nacionalidad");
                    error = true;
                }
            }
            if (txtDomicilio.Text != string.Empty)
            {
                if (Empleado.ValidarDomicilio(txtDomicilio.Text))
                {
                    empleado.Domicilio = txtDomicilio.Text;
                }
                else
                {
                    sb.AppendLine("Domicilio");
                    error = true;
                }
            }
            if (txtSueldo.Text != string.Empty)
            {
                if (double.TryParse(txtSueldo.Text, out sueldo) && Empleado.ValidarSueldo(sueldo))
                {
                    empleado.Sueldo = sueldo;
                }
                else
                {
                    sb.AppendLine("Sueldo");
                    error = true;
                }
            }
            if (cmbPuesto.SelectedItem != null)
            {
                empleado.Puesto = (EPuesto)cmbPuesto.SelectedItem;
            }
            if (chkLunes.Checked)
            {
                empleado.DiasLaborales[0] = "L";
            }
            else
            {
                empleado.DiasLaborales[0] = null;
            }
            if (chkMartes.Checked)
            {
                empleado.DiasLaborales[1] = "Ma";
            }
            else
            {
                empleado.DiasLaborales[1] = null;
            }
            if (chkMiercoles.Checked)
            {
                empleado.DiasLaborales[2] = "Mi";
            }
            else
            {
                empleado.DiasLaborales[2] = null;
            }
            if (chkJueves.Checked)
            {
                empleado.DiasLaborales[3] = "J";
            }
            else
            {
                empleado.DiasLaborales[3] = null;
            }
            if (chkViernes.Checked)
            {
                empleado.DiasLaborales[4] = "V";
            }
            else
            {
                empleado.DiasLaborales[4] = null;
            }
            if (chkSabado.Checked)
            {
                empleado.DiasLaborales[5] = "S";
            }
            else
            {
                empleado.DiasLaborales[5] = null;
            }
            if (chkDomingo.Checked)
            {
                empleado.DiasLaborales[6] = "D";
            }
            else
            {
                empleado.DiasLaborales[6] = null;
            }
            if (mtxHoraEntrada.Text != "  :")
            {
                if (Empleado.ValidarHora(mtxHoraEntrada.Text))
                {
                    empleado.HorarioEntrada = Convert.ToDateTime(mtxHoraEntrada.Text);
                }
                else
                {
                    sb.AppendLine("Hora de entrada");
                    error = true;
                }
            }
            if (mtxHoraSalida.Text != "  :")
            {
                if (Empleado.ValidarHora(mtxHoraSalida.Text))
                {
                    empleado.HorarioSalida = Convert.ToDateTime(mtxHoraSalida.Text);
                }
                else
                {
                    sb.AppendLine("Hora de salida");
                    error = true;
                }
            }

            return error;
        }
        #endregion

        #region Visibilidad Label/TextBox
        /// <summary>
        /// Establece la visibilidad de los text box en false
        /// </summary>
        private void OcultarTextBox()
        {
            btnAplicarCambios.Visible = false;
            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtFechaNacimiento.Visible = false;
            txtDni.Visible = false;
            cmbSexo.Visible = false;
            txtNacionalidad.Visible = false;
            txtDomicilio.Visible = false;
            txtSueldo.Visible = false;
            cmbPuesto.Visible = false;
            chkLunes.Visible = false;
            chkMartes.Visible = false;
            chkMiercoles.Visible = false;
            chkJueves.Visible = false;
            chkViernes.Visible = false;
            chkSabado.Visible = false;
            chkDomingo.Visible = false;
            mtxHoraEntrada.Visible = false;
            mtxHoraSalida.Visible = false;
        }


        /// <summary>
        /// Establece la visibilidad de los lebel en false
        /// </summary>
        private void OcultarLebel()
        {
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblFechaNacimiento.Visible = false;
            lblDni.Visible = false;
            lblSexo.Visible = false;
            lblNacionalidad.Visible = false;
            lblDomicilio.Visible = false;
            lblSueldo.Visible = false;
            lblPuesto.Visible = false;
            lblDiasLaborales.Visible = false;
            lblHoraEntrada.Visible = false;
            lblHoraSalida.Visible = false;
        }

        /// <summary>
        /// Establece la visibilidad de los text box en true
        /// </summary>
        private void MostrarTextBox()
        {
            btnAplicarCambios.Visible = true;
            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtFechaNacimiento.Visible = true;
            txtDni.Visible = true;
            cmbSexo.Visible = true;
            txtNacionalidad.Visible = true;
            txtDomicilio.Visible = true;
            txtSueldo.Visible = true;
            cmbPuesto.Visible = true;
            chkLunes.Visible = true;
            chkMartes.Visible = true;
            chkMiercoles.Visible = true;
            chkJueves.Visible = true;
            chkViernes.Visible = true;
            chkSabado.Visible = true;
            chkDomingo.Visible = true;
            mtxHoraEntrada.Visible = true;
            mtxHoraSalida.Visible = true;
        }

        /// <summary>
        /// Establece la visibilidad de los lebel en true
        /// </summary>
        private void MostrarLebel()
        {
            lblNombre.Visible = true;
            lblApellido.Visible = true;
            lblFechaNacimiento.Visible = true;
            lblDni.Visible = true;
            lblSexo.Visible = true;
            lblNacionalidad.Visible = true;
            lblDomicilio.Visible = true;
            lblSueldo.Visible = true;
            lblPuesto.Visible = true;
            lblDiasLaborales.Visible = true;
            lblHoraEntrada.Visible = true;
            lblHoraSalida.Visible = true;
        }

        /// <summary>
        /// Borra cualquier texto que haya en los text box
        /// </summary>
        private void LimpiarTextBox()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            txtDni.Text = string.Empty;
            cmbSexo.SelectedItem = null;
            txtNacionalidad.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtSueldo.Text = string.Empty;
            cmbPuesto.SelectedItem = null;
            chkLunes.Checked = false;
            chkMartes.Checked = false;
            chkMiercoles.Checked = false;
            chkJueves.Checked = false;
            chkViernes.Checked = false;
            chkSabado.Checked = false;
            chkDomingo.Checked = false;
            mtxHoraEntrada.Text = string.Empty;
            mtxHoraSalida.Text = string.Empty;
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
        private void ReproducirSonidoFallo()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Fallo.wav");
            sonido.Play();
        }

        /// <summary>
        /// Reproduce un sonido indicando que se presionó un botón
        /// </summary>
        private void ReproducirSonidoBoton()
        {
            SoundPlayer sonido = new SoundPlayer($"{FrmLogin.Path}\\Sonidos\\Boton.wav");
            sonido.Play();
        }
        #endregion
    }
}
