using System.ComponentModel.DataAnnotations;
using static CarMeeting.Common.EntityValidationConstants.Event;
namespace CarMeetinig.Data.Models
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Location { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ICollection<Registration> Registrations { get; set; } 
            = new List<Registration>();
        public ICollection<Judging> Judgings { get; set; } 
            = new List<Judging>();
    }
}
