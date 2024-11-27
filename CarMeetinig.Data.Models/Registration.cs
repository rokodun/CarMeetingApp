using CarMeeting.Data.Models;

namespace CarMeetinig.Data.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int EventID { get; set; }
        public int ParticipantID { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; } = null!; // "Confirmed", "Pending"
        public Event? Event { get; set; }
        public Participant? Participant { get; set; }
    }
}