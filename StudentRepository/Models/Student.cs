using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRepository.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int SId { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string SName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Gender {  get; set; }
        public int Age { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Course {  get; set; }
    }
}
