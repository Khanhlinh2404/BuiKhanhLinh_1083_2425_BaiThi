using System.ComponentModel.DataAnnotations;

namespace BuiKhanhLinh_1083_2425_BaiThi.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}