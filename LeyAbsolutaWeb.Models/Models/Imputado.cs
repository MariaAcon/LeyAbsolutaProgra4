using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeyAbsolutaWeb.Models
{
    public class Imputado
    {
        [Key]
        public int id_Imputado { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Tipo Imputado")]
        public string Tipo_Imputado { get; set; }
        [Required]

        public int cedula { get; set; }
        [Required]
        [MaxLength(50)]

        [Display(Name = "Nombre Completo")]
        public string nombre { get; set; }
        [Required]

        [Display(Name = "Apellido 1")]
        public string Ape1 { get; set; }
        [Required]

        [Display(Name = "Apellido 2")]
        public string Ape2 { get; set; } 

        [Required]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

    }
}
