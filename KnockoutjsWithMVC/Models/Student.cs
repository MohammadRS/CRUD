using System.ComponentModel.DataAnnotations;

namespace KnockoutjsWithMVC.Models
{
    public class Student
    {
        [Key]
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Batch { get; set; }
        public string Address { get; set; }
        public string Class { get; set; }
        public string School { get; set; }
        public decimal Decimal { get; set; }
    }
}
