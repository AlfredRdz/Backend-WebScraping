using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Brive.Bootcamp.Project.API.Models
{
    [Table("Company")]
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberJobs { get; set; }
        public DateTime Date { get; set; }
    }
}
