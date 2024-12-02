using CarMeetinig.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMeeting.Data.Models
{
    public class Participant
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Role { get; set; } = null!; // "Visitor" , "Participant"
        public ICollection<Car> Cars { get; set; } 
            = new List<Car>();
        public ICollection<Registration> Registrations { get; set; } 
            = new List<Registration>();
    }
}
