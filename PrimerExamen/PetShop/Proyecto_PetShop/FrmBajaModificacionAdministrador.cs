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
    public partial class FrmBajaModificacionAdministrador : Form
    {
        /// <summary>
        /// Carga los componentes gráficos del formulario
        /// </summary>
        public FrmBajaModificacionAdministrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga los datos cuando se abre el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBajaModificacionAdministrador_Load(object sender, EventArgs e)
        {
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(EPuesto));

            if (FrmLogin.EsAdmin)
            {
                this.BackColor = Color.AntiqueWhite;
            }
        }

        #region BotonMostrar
        /// <summary>
        /// Muestra los datos del administrador con el ID ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Administrador administrador;

            if (FrmLogin.Administradores.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Administradores.Count; i++)
                {
                    administrador = FrmLogin.Administradores[i];

                    if (nupIdAdministrador.Value == administrador.IdAdministrador)
                    {
                        lblInfo.Visible = false;
                        OcultarLebel();
                        OcultarTextBox();
                        lblMostrar.Visible = true;
                        lblMostrar.Text = administrador.Mostrar();
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                        lblMostrar.Visible = false;
                        OcultarLebel();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }
        #endregion

        #region BotonModificar_AplicarCambios
        /// <summary>
        /// Entra en el modo modificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (FrmLogin.Administradores.Count > 0)
            {
                OcultarLebel();
                MostrarLebel();
                MostrarTextBox();
                lblMostrar.Visible = false;
                btnAplicarCambios.Visible = true;
            }
            else
            {
                lblInfo.Visible = true;
            }
        }

        /// <summary>
        /// Sobreescribe los datos deseados del administrador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Administrador administrador;
            StringBuilder sb;

            for (int i = 0; i < FrmLogin.Administradores.Count; i++)
            {
                administrador = FrmLogin.Administradores[i];

                if (nupIdAdministrador.Value == administrador.IdAdministrador)
                {
                    lblInfo.Visible = false;

                    if (Validaciones(administrador, out sb))
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
                            lblMostrar.Text = administrador.Mostrar();
                            lblMostrar.Visible = true;
                            break;
                        }
                    }
                }
                else
                {
                    lblInfo.Visible = true;
                }
            }
        }
        #endregion

        #region BotonEliminar
        /// <summary>
        /// Elimina el administrador con el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Administrador administrador;

            if (FrmLogin.Administradores.Count > 0)
            {
                for (int i = 0; i < FrmLogin.Administradores.Count; i++)
                {
                    administrador = FrmLogin.Administradores[i];

                    if (nupIdAdministrador.Value == administrador.IdAdministrador)
                    {
                        lblInfo.Visible = false;

                        if (MessageBox.Show("¿Estás seguro que desea eliminar este administrador?\nEsta acción no se puede deshacer", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Administrador.BajaAdministrador(FrmLogin.Administradores, administrador);
                            OcultarLebel();
                            lblMostrar.Visible = false;
                        }
                        break;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
            }
        }
        #endregion

        #region Validaciones
        private bool Validaciones(Administrador administrador, out StringBuilder sb)
        {
            bool error = false;
            long dni;
            double sueldo;
            sb = new StringBuilder();

            if (txtNombre.Text != string.Empty)
            {
                if (Administrador.ValidarNombre(txtNombre.Text))
                {
                    administrador.Nombre = txtNombre.Text;
                }
                else
                {
                    sb.AppendLine("Nombre");
                    error = true;
                }
            }
            if (txtApellido.Text != string.Empty)
            {
                if (Administrador.ValidarApellido(txtApellido.Text))
                {
                    administrador.Apellido = txtApellido.Text;
                }
                else
                {
                    sb.AppendLine("Apellido");
                    error = true;
                }
            }
            if (txtFechaNacimiento.Text != string.Empty)
            {
                if (Administrador.ValidarFechaNacimiento(txtFechaNacimiento.Text))
                {
                    administrador.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                }
                else
                {
                    sb.AppendLine("Fecha de nacimiento");
                    error = true;
                }
            }
            if (txtDni.Text != string.Empty)
            {
                if (long.TryParse(txtDni.Text, out dni) && Administrador.ValidarDni(dni))
                {
                    administrador.Dni = dni;
                }
                else
                {
                    sb.AppendLine("DNI");
                    error = true;
                }
            }
            if (cmbSexo.SelectedItem != null)
            {
                administrador.Sexo = cmbSexo.SelectedItem.ToString();
            }
            if (txtNacionalidad.Text != string.Empty)
            {
                if (Administrador.ValidarNacionalidad(txtNacionalidad.Text))
                {
                    administrador.Nacionalidad = txtNacionalidad.Text;
                }
                else
                {
                    sb.AppendLine("Nacionalidad");
                    error = true;
                }
            }
            if (txtDomicilio.Text != string.Empty)
            {
                if (Administrador.ValidarDomicilio(txtDomicilio.Text))
                {
                    administrador.Domicilio = txtDomicilio.Text;
                }
                else
                {
                    sb.AppendLine("Domicilio");
                    error = true;
                }
            }
            if (txtSueldo.Text != string.Empty)
            {
                if (double.TryParse(txtSueldo.Text, out sueldo) && Administrador.ValidarSueldo(sueldo))
                {
                    administrador.Sueldo = sueldo;
                }
                else
                {
                    sb.AppendLine("Sueldo");
                    error = true;
                }
            }
            if (cmbPuesto.SelectedItem != null)
            {
                administrador.Puesto = (EPuesto)cmbPuesto.SelectedItem;
            }
            if (chkLunes.Checked)
            {
                administrador.DiasLaborales[0] = "L";
            }
            else
            {
                administrador.DiasLaborales[0] = null;
            }
            if (chkMartes.Checked)
            {
                administrador.DiasLaborales[1] = "Ma";
            }
            else
            {
                administrador.DiasLaborales[1] = null;
            }
            if (chkMiercoles.Checked)
            {
                administrador.DiasLaborales[2] = "Mi";
            }
            else
            {
                administrador.DiasLaborales[2] = null;
            }
            if (chkJueves.Checked)
            {
                administrador.DiasLaborales[3] = "J";
            }
            else
            {
                administrador.DiasLaborales[3] = null;
            }
            if (chkViernes.Checked)
            {
                administrador.DiasLaborales[4] = "V";
            }
            else
            {
                administrador.DiasLaborales[4] = null;
            }
            if (chkSabado.Checked)
            {
                administrador.DiasLaborales[5] = "S";
            }
            else
            {
                administrador.DiasLaborales[5] = null;
            }
            if (chkDomingo.Checked)
            {
                administrador.DiasLaborales[6] = "D";
            }
            else
            {
                administrador.DiasLaborales[6] = null;
            }
            if (mtxHoraEntrada.Text != "  :")
            {
                if (Administrador.ValidarHora(mtxHoraEntrada.Text))
                {
                    administrador.HorarioEntrada = Convert.ToDateTime(mtxHoraEntrada.Text);
                }
                else
                {
                    sb.AppendLine("Hora de entrada");
                    error = true;
                }
            }
            if (mtxHoraSalida.Text != "  :")
            {
                if (Administrador.ValidarHora(mtxHoraSalida.Text))
                {
                    administrador.HorarioSalida = Convert.ToDateTime(mtxHoraSalida.Text);
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
    }
}
