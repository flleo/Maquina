using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maquina.Models
{
    public class Saludo
    {
        public int Id { get; set; }
        [Required]
        public string Saludo1 { get; set; }
        [Required]
        public Nullable<int> UserId { get; set; }
        [Required]
        public Nullable<int> IdiomaId { get; set; }

        public virtual Idioma Idioma { get; set; }
        public virtual User User { get; set; }
    }
}