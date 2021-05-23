using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VotingWebApplication.EN
{
    public class Usuario
    {
        public int id { get; set; }
        [Display(Name = "Nombre de usuario:")]
        public string usuario { get; set; }
        [Display(Name = "Contraseña:")]
        public string password { get; set; }
        [Display(Name = "Comprobar contraseña:")]
        public string password2 { get; set; }
        [Display(Name = "Correo electronico:")]
        public string correo { get; set; }
        public DateTime fecha_creacion { get; set; }
        [Display(Name = "Identificador Registro Nacional")]
        public int id_registroNacional{ get; set; }
        public int id_role { get; set; }
        [Display(Name = "Número de DUI:")]
        public String numero_dui { get; set; }
    }
}