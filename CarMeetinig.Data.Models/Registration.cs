using CarMeeting.Data.Models;

namespace CarMeetinig.Data.Models
{
    public class Registration
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int EventId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; } = null!; // "Confirmed", "Pending"
        public Event? Event { get; set; }
        public Participant? Participant { get; set; }
    }
}