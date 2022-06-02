using System.ComponentModel.DataAnnotations;

namespace Employee.Model
{
    public class employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Hometown { get; set; }
        
    }
}
