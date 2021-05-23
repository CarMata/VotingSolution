using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingWebApplication.EN
{
    public class RegistroNacional
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public DateTime fecha_nacimiento { get; set; }

        public string numero_dui { get; set; }
        public char genero { get; set; }

        public string ocupacion { get; set; }

        public string nacionalidad { get; set; }

        public byte[] foto { get; set; }

        public string direccion { get; set; }

        public int id_municipio { get; set; }
    }
}