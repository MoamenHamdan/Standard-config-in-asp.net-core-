using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Student
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        [MinLength(2)]
        public string Name { get; set; }

        public bool isActive { get; set; } 

        public Student(int id, string name, bool isActive)
        {
            Id = id;
            Name = name;
            this.isActive = isActive;
        }


    }
}
