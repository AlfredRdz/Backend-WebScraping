using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Brive.Bootcamp.Project.API.Models
{
    [Table("RegisteredUsers")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Email")]
        [EmailAddress(ErrorMessage ="Ingrese un correo valido")]
        [Required]
        public string Email { get; set; } 
        [Column("Password")]
        [Required]
        public string Password { get; set; }
    }
}
