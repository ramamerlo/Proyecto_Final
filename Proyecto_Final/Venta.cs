using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Venta
    {
        //atributos
        int id;
        string comentarios;
        int idUsuario;

        //constructor
        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }

        //propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        public int IdUsuario
        {
            get { return idUsuario; }
            set
            { idUsuario = value; }
        }
    }
}
