using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tell us your name please!")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubcribedToNewLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        [Required( ErrorMessage = "You must select a membership.")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Min18IfAMember]
        public DateTime? Birthdate { get; set; }
    }
}