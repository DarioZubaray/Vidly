using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tell us your name please!")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubcribedToNewLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Min18IfAMember]
        public DateTime? Birthdate { get; set; }
    }
}