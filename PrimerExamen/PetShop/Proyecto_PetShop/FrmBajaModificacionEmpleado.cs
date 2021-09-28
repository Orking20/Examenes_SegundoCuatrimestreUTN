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
    public partial class FrmBajaModificacionEmpleado : Form
    {
        public FrmBajaModificacionEmpleado()
        {
            InitializeComponent();
        }

        private void FrmBajaModificacionEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbPuesto.DataSource = Enum.GetValues(typeof(EPuesto));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            StringBuilder fechaNacimiento = new StringBuilder();
            StringBuilder horarioEntrada = new StringBuilder();
            StringBuilder horarioSalida = new StringBuilder();

            for (int i = 0; i < FrmLogin.Empleados.Count; i++)
            {
                empleado = FrmLogin.Empleados[i];

                if (nupIdEmpleado.Value == empleado.IdEmpleado)
                {
                    fechaNacimiento.Append($"{empleado.FechaNacimiento.Day}/{empleado.FechaNacimiento.Month}/{empleado.FechaNacimiento.Year}");
                    horarioEntrada.Append($"{empleado.HorarioEntrada.Hour}:{empleado.HorarioSalida.Minute}hs.");
                    horarioSalida.Append($"{empleado.HorarioSalida.Hour}:{empleado.HorarioSalida.Minute}hs.");

                    lblInfo.Visible = false;
                    OcultarTextBox();
                    MostrarLebel();

                    lblNombreEmpleado.Text = empleado.Nombre;
                    lblApellidoEmpleado.Text = empleado.Apellido;
                    lblFechaNacimientoEmpleado.Text = fechaNacimiento.ToString();
                    lblDniEmpleado.Text = empleado.Dni.ToString();
                    lblSexoEmpleado.Text = empleado.Sexo;
                    lblNacionalidadEmpleado.Text = empleado.Nacionalidad;
                    lblDomicilioEmpleado.Text = empleado.Domicilio;
                    lblSueldoEmpleado.Text = empleado.Sueldo.ToString();
                    lblPuestoEmpleado.Text = empleado.Puesto.ToString();
                    lblHorarioEntradaEmpleado.Text = horarioEntrada.ToString();
                    lblHorarioSalidaEmpleado.Text = horarioSalida.ToString();
                    break;
                }
                else
                {
                    lblInfo.Visible = true;
                    OcultarLebel();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            OcultarLebel();
            MostrarTextBox();
            btnAplicarCambios.Visible = true;
        }

        private void btnAplicarCambios_Click(object sender, EventArgs e)
        {
            Empleado empleado;
            long dni;
            double sueldo;

            for (int i = 0; i < FrmLogin.Empleados.Count; i++)
            {
                empleado = FrmLogin.Empleados[i];

                if (nupIdEmpleado.Value == empleado.IdEmpleado)
                {
                    lblInfo.Visible = false;

                    if (MessageBox.Show("¿Seguro que desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (txtNombre.Text != string.Empty)
                        {
                            empleado.Nombre = txtNombre.Text;
                        }
                        if (txtApellido.Text != string.Empty)
                        {
                            empleado.Apellido = txtApellido.Text;
                        }
                        if (txtFechaNacimiento.Text != string.Empty)
                        {
                            empleado.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                        }
                        if (txtDni.Text != string.Empty)
                        {
                            if (!long.TryParse(txtDni.Text, out dni))
                            {
                                MessageBox.Show("El DNI es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            empleado.Dni = dni;
                        }
                        if (cmbSexo.SelectedItem != null)
                        {
                            empleado.Sexo = cmbSexo.SelectedItem.ToString();
                        }
                        if (txtNacionalidad.Text != string.Empty)
                        {
                            empleado.Nacionalidad = txtNacionalidad.Text;
                        }
                        if (txtDomicilio.Text != string.Empty)
                        {
                            empleado.Domicilio = txtDomicilio.Text;
                        }
                        if (txtSueldo.Text != string.Empty)
                        {
                            if (!double.TryParse(txtSueldo.Text, out sueldo))
                            {
                                MessageBox.Show("El sueldo es inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            empleado.Sueldo = sueldo;
                        }
                        if (cmbPuesto.SelectedItem != null)
                        {
                            empleado.Puesto = (EPuesto)cmbPuesto.SelectedItem;
                        }
                        if (mtxHoraEntrada.Text != "  :")
                        {
                            empleado.HorarioEntrada = Convert.ToDateTime(mtxHoraEntrada.Text);
                        }
                        if (mtxHoraSalida.Text != "  :")
                        {
                            empleado.HorarioSalida = Convert.ToDateTime(mtxHoraSalida.Text);
                        }
                        LimpiarTextBox();
                    }
                    break;
                }
                else
                {
                    lblInfo.Visible = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado empleado;

            for (int i = 0; i < FrmLogin.Empleados.Count; i++)
            {
                empleado = FrmLogin.Empleados[i];

                if (nupIdEmpleado.Value == empleado.IdEmpleado)
                {
                    if (MessageBox.Show("¿Estás seguro que desea eliminar este empleado?\nEsta acción no se puede deshacer", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        FrmLogin.Empleados.Remove(empleado);
                        OcultarLebel();
                    }
                    break;
                }
                else
                {
                    lblInfo.Visible = true;
                }
            }
        }


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
            mtxHoraEntrada.Visible = false;
            mtxHoraSalida.Visible = false;
        }


        /// <summary>
        /// Establece la visibilidad de los lebel en false
        /// </summary>
        private void OcultarLebel()
        {
            lblNombreEmpleado.Visible = false;
            lblApellidoEmpleado.Visible = false;
            lblFechaNacimientoEmpleado.Visible = false;
            lblDniEmpleado.Visible = false;
            lblSexoEmpleado.Visible = false;
            lblNacionalidadEmpleado.Visible = false;
            lblDomicilioEmpleado.Visible = false;
            lblSueldoEmpleado.Visible = false;
            lblPuestoEmpleado.Visible = false;
            lblHorarioEntradaEmpleado.Visible = false;
            lblHorarioSalidaEmpleado.Visible = false;
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
            mtxHoraEntrada.Visible = true;
            mtxHoraSalida.Visible = true;
        }

        /// <summary>
        /// Establece la visibilidad de los lebel en true
        /// </summary>
        private void MostrarLebel()
        {
            lblNombreEmpleado.Visible = true;
            lblApellidoEmpleado.Visible = true;
            lblFechaNacimientoEmpleado.Visible = true;
            lblDniEmpleado.Visible = true;
            lblSexoEmpleado.Visible = true;
            lblNacionalidadEmpleado.Visible = true;
            lblDomicilioEmpleado.Visible = true;
            lblSueldoEmpleado.Visible = true;
            lblPuestoEmpleado.Visible = true;
            lblHorarioEntradaEmpleado.Visible = true;
            lblHorarioSalidaEmpleado.Visible = true;
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
            mtxHoraEntrada.Text = string.Empty;
            mtxHoraSalida.Text = string.Empty;
        }
        #endregion

    }
}
