using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Administrador : Empleado
    {
        private static int idEmpleado = 0;
        private static int idAdministrador = 0;
        private int idAdmin = 0;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de un administrador
        /// </summary>
        /// <param name="usuario">Usuario del administrador</param>
        /// <param name="password">Password del administrador</param>
        /// <param name="sueldo">Sueldo del administrador</param>
        /// <param name="puesto">Puesto del administrador</param>
        /// <param name="diasLaborales">Días laborales del administrador</param>
        /// <param name="horarioEntrada">Horario de entrada del administrador</param>
        /// <param name="horarioSalida">Horario de entrada del administrador</param>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="dni">DNI del administrador</param>
        /// <param name="sexo">Sexo del administrador</param>
        /// <param name="nacionalidad">Nacionalidad del administrador</param>
        /// <param name="domicilio">Domicilio del administrador</param>
        public Administrador(int idAdministrador, string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
            : base(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, idEmpleado, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio)
        {
            this.idAdmin = idAdministrador;
        }
        #endregion

        #region Administrar admin
        public static Administrador AltaAdministrador(string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
        {
            idAdministrador++;

            Administrador administradorNuevo = new Administrador(idAdministrador, usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);

            return administradorNuevo;
        }

        public static string MostrarAdministrador(Administrador administrador)
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Sueldo: {administrador.Sueldo}");
            st.AppendLine($"Puesto: {administrador.Puesto}");
            st.AppendLine($"Días laborales: {administrador.DiasLaborales}");
            st.AppendLine($"Horario de entrada: {administrador.HorarioEntrada}");
            st.AppendLine($"Horario de salida: {administrador.HorarioSalida}");
            st.AppendLine($"Nombre y apellido: {administrador.Nombre} {administrador.Apellido}");
            st.AppendLine($"Fecha de nacimiento: {administrador.FechaNacimiento}");
            st.AppendLine($"DNI: {administrador.Dni}");
            st.AppendLine($"Sexo: {administrador.Sexo}");
            st.AppendLine($"Nacionalidad: {administrador}");
            st.AppendLine($"Domicilio: {administrador.Domicilio}");

            return st.ToString();
        }
        #endregion

        #region Administrar empleado
        /// <summary>
        /// Crea un nuevo empleado
        /// </summary>
        /// <param name="usuario">Usuario del empleado</param>
        /// <param name="password">Password del empleado</param>
        /// <param name="sueldo">Sueldo del empleado</param>
        /// <param name="puesto">Puesto del empleado</param>
        /// <param name="diasLaborales">Días laborales del administrador</param>
        /// <param name="horarioEntrada">Hora de entrada del empleado</param>
        /// <param name="horarioSalida">Hora de salida del empleado</param>
        /// <param name="nombre">Nombre del empleado</param>
        /// <param name="apellido">Apellido del empleado</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del empleado</param>
        /// <param name="dni">DNI del empleado</param>
        /// <param name="sexo">Sexo del empleado</param>
        /// <param name="nacionalidad">Nacionalidad del empleado</param>
        /// <param name="domicilio">Domicilio del empleado</param>
        /// <returns>Retorna el nuevo empleado</returns>
        public static Empleado AltaEmpleado(string usuario, string password, double sueldo, EPuesto puesto, string[] diasLaborales, DateTime horarioEntrada, DateTime horarioSalida, string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
        {
            idEmpleado++;

            Empleado empleadoNuevo = new Empleado(usuario, password, sueldo, puesto, diasLaborales, horarioEntrada, horarioSalida, idEmpleado, nombre, apellido, fechaNacimiento, dni, sexo, nacionalidad, domicilio);

            return empleadoNuevo;
        }

        public static string MostrarEmpleado(Empleado empleado)
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Sueldo: {empleado.Sueldo}");
            st.AppendLine($"Puesto: {empleado.Puesto}");
            st.AppendLine($"Días laborales: {empleado.DiasLaborales}");
            st.AppendLine($"Horario de entrada: {empleado.HorarioEntrada}");
            st.AppendLine($"Horario de salida: {empleado.HorarioSalida}");
            st.AppendLine($"Nombre y apellido: {empleado.Nombre} {empleado.Apellido}");
            st.AppendLine($"Fecha de nacimiento: {empleado.FechaNacimiento}");
            st.AppendLine($"DNI: {empleado.Dni}");
            st.AppendLine($"Sexo: {empleado.Sexo}");
            st.AppendLine($"Nacionalidad: {empleado}");
            st.AppendLine($"Domicilio: {empleado.Domicilio}");

            return st.ToString();
        }
        #endregion

        public int IdAdministrador
        {
            get
            {
                return idAdmin;
            }
        }
    }
}
