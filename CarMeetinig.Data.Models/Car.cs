using CarMeetinig.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarMeeting.Data.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public Guid ParticipantId { get; set; }

        [Required]
        public string Make { get; set; } = null!;

        [Required]
        public string Model { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Color { get; set; } = null!;
        public Guid CarCategoryId { get; set; }

        [ForeignKey(nameof(ParticipantId))]
        public Participant? Participant { get; set; }

        [ForeignKey(nameof(CarCategoryId))]
        public CarCategory? CarCategory { get; set; }
        public ICollection<Judging> Judgings { get; set; } 
            = new List<Judging>();
    }
}
