using System.ComponentModel.DataAnnotations;
using static CarMeeting.Common.EntityValidationConstants.Event;
namespace CarMeetinig.Data.Models
{
    public class Event
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Location { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        public ICollection<Registration> Registrations { get; set; } 
            = new List<Registration>();
        
        public ICollection<Judging> Judgings { get; set; } 
            = new List<Judging>();
    }
}
