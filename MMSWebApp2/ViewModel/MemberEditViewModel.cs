using MMSWebApp2.Enum;
using MMSWebApp2.Validation;
using System.ComponentModel.DataAnnotations;

namespace MMSWebApp2.ViewModel
{
    public class MemberEditViewModel
    {
        public int MemberID { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [MaxDateToday(ErrorMessage = "Future dates are not allowed.")]
        public DateOnly Birthdate { get; set; }
        public string Address { get; set; }
        public BranchCategory Branch { get; set; }
        [Display(Name = "Contact No.")]
        public string ContactNo { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }
}
