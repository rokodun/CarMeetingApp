using CarMeeting.Data.Models;

namespace CarMeetinig.Data.Models
{
    public class Judging
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid EventId { get; set; }
        public Guid CarId { get; set; }
        public int Score { get; set; }
        public Event? Event { get; set; }
        public Car? Car { get; set; }
    }
}