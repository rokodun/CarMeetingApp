using CarMeeting.Data.Models;

namespace CarMeetinig.Data.Models
{
    public class Judging
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int EventId { get; set; }
        public int CarId { get; set; }
        public int Score { get; set; }
        public Event? Event { get; set; }
        public Car? Car { get; set; }
    }
}