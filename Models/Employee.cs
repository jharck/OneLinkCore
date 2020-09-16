using System.ComponentModel.DataAnnotations;

namespace oneLinkCore.Models
{
    public class Employee
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        public string TypeOfDocument { get; set; }

        public string Document { get; set; }
    }
}