using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Brive.Bootcamp.Project.API.Models
{
    [Table("Company")]
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "No se pueden utilizar caracteres especiales.")]
        public string Name { get; set; }
        [Column("NumberJobs")]
        public int NumberJobs { get; set; }
        [Column("Date")]
        public DateTime Date { get; set; }
    }
}
