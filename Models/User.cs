using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Maquina.Models
{
    public class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Files = new HashSet<File>();
            this.Saludos = new HashSet<Saludo>();
            this.Despedidas = new HashSet<Despedida>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "El {0} debe ser, al menos de  {2} caracteres de largo y máximo de {1}", MinimumLength = 3)]
        [Display(Name = "Usuario")]
        public string user1 { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "El {0} debe ser, de máximo de {1} caracteres")]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "El {0} debe ser, al menos de  {2} caracteres de largo y máximo de {1}", MinimumLength = 1)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [Display(Name = "Confirma Contraseña")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Descripción Foto")]
        public string nombreFichero { get; set; }
        [Display(Name = "Modificar Foto")]
        public byte[] foto { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Saludo> Saludos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despedida> Despedidas { get; set; }
    }
}