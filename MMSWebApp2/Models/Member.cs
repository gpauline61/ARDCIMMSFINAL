using MMSWebApp2.Enum;
using MMSWebApp2.Validation;
using System.ComponentModel.DataAnnotations;

namespace MMSWebApp2.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
        
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Address { get; set; }
        public BranchCategory Branch { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
}
