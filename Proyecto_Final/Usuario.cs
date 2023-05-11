using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Usuario
    {
        //atributos
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private int password;
        private string mail;

        //constructor
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, int password, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.mail = mail;
        }

        //propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public int Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }


    }
}
