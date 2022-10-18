using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoMVC.Models
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }

        public int Nombre { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

       
        [ForeignKey("rol")]
        public int? FkRol { get; set; }  

        public Roles rol { get; set; }

    }
}
