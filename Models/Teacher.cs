using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Teacher
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(22,70)]
        public bool Age { get; set; }
        public Teacher(int id, string name, bool Age)
        {
            Id = id;
            Name = name;
            this.Age = Age;
        }
    }
}
