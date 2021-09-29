using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private long dni;
        private string sexo;
        private string nacionalidad;
        private string domicilio;

        #region Constructor
        /// <summary>
        /// Inicializa los datos de una persona
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="apellido">Apellido de la persona</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona</param>
        /// <param name="dni">DNI de la persona</param>
        /// <param name="sexo">Sexo de la persona</param>
        /// <param name="nacionalidad">Nacionalidad de la persona</param>
        /// <param name="domicilio">Domicilio de la persona</param>
        public Persona(string nombre, string apellido, DateTime fechaNacimiento, long dni, string sexo, string nacionalidad, string domicilio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Dni = dni;
            this.Sexo = sexo;
            this.Nacionalidad = nacionalidad;
            this.Domicilio = domicilio;
        }
        #endregion

        /// <summary>
        /// Muestra todos los datos de una persona
        /// </summary>
        /// <returns>Retorna una cadena con los datos de una persona</returns>
        public virtual string Mostrar()
        {
            StringBuilder st = new StringBuilder();

            st.AppendLine($"Nombre y apellido: {this.Nombre} {this.Apellido}");
            st.AppendLine($"Fecha de nacimiento: {this.FechaNacimiento.Day}/{this.FechaNacimiento.Month}/{this.FechaNacimiento.Year}");
            st.AppendLine($"DNI: {this.Dni}");
            st.AppendLine($"Sexo: {this.Sexo}");
            st.AppendLine($"Nacionalidad: {this.Nacionalidad}");
            st.AppendLine($"Domicilio: {this.Domicilio}");

            return st.ToString();
        }

        #region Getters/Setters
        /// <summary>
        /// Devuelve o establece el valor de nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (ValidarNombre(value))
                {
                    this.nombre = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (ValidarApellido(value))
                {
                    this.apellido = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de fechaNacimiento
        /// </summary>
        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set
            {
                 this.fechaNacimiento = value;
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de dni
        /// </summary>
        public long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (ValidarDni(value))
                {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de sexo
        /// </summary>
        public string Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                if (ValidarSexo(value))
                {
                    this.sexo = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de nacionalidad
        /// </summary>
        public string Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                if (ValidarNacionalidad(value))
                {
                    this.nacionalidad = value;
                }
            }
        }

        /// <summary>
        /// Devuelve o establece el valor de domicilio
        /// </summary>
        public string Domicilio
        {
            get
            {
                return this.domicilio;
            }
            set
            {
                if (ValidarDomicilio(value))
                {
                    this.domicilio = value;
                }
            }
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Valida que la cadena ingresada sea un nombre válido
        /// </summary>
        /// <param name="nombre">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un nombre válido o false si no</returns>
        public static bool ValidarNombre(string nombre)
        {
            bool retorno;

            retorno = EsSoloLetras(nombre);

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena ingresada sea un apellido válido
        /// </summary>
        /// <param name="apellido">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un apellido válido o false si no</returns>
        public static bool ValidarApellido(string apellido)
        {
            bool retorno;

            retorno = EsSoloLetras(apellido);

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena ingresada sea una fecha de nacimiento válida
        /// </summary>
        /// <param name="fechaNacimiento">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un apellido válido o false si no</returns>
        public static bool ValidarFechaNacimiento(string fechaNacimiento)
        {
            bool retorno = false;
            DateTime fecha;

            if (DateTime.TryParse(fechaNacimiento, out fecha))
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que el número ingresado sea un DNI válido
        /// </summary>
        /// <param name="dni">Número a validar</param>
        /// <returns>Retorna true si el número es un DNI válido o false si no</returns>
        public static bool ValidarDni(long dni)
        {
            bool retorno = false;

            if (dni.ToString().Length == 8)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena ingresada sea un sexo válido
        /// </summary>
        /// <param name="sexo">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un sexo válido o false si no</returns>
        public static bool ValidarSexo(string sexo)
        {
            bool retorno = false;

            if (sexo.ToLower() == "masculino" || sexo.ToLower() == "femenino" || sexo.ToLower() == "no binario")
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena ingresada sea una nacionalidad válida
        /// </summary>
        /// <param name="nacionalidad">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es una nacionalidad válida o false si no</returns>
        public static bool ValidarNacionalidad(string nacionalidad)
        {
            bool retorno;

            retorno = EsSoloLetras(nacionalidad);

            return retorno;
        }

        /// <summary>
        /// Valida que la cadena ingresada sea un domicilio válido
        /// </summary>
        /// <param name="domicilio">Cadena a validar</param>
        /// <returns>Retorna true si la cadena es un domicilio válido o false si no</returns>
        public static bool ValidarDomicilio(string domicilio)
        {
            bool retorno = false;
            int altura;
            string[] palabras = domicilio.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (!int.TryParse(palabras[i], out altura))
                {
                    retorno = false;
                }
                if (EsSoloLetras(palabras[i]))
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Valida que una cadena contenga solo letras
        /// </summary>
        /// <param name="palabra">Palabra a validar</param>
        /// <returns>Retorna true si la cadena tiene solo letras o false si no</returns>
        public static bool EsSoloLetras(string palabra)
        {
            bool retorno = false;

            foreach (char letra in palabra)
            {
                if (!Char.IsLetter(letra) && letra != ' ')
                {
                    retorno = false;
                    break;
                }
                else
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        #endregion
    }
}
