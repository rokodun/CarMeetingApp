using CarMeeting.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarMeetinig.Data.Models
{
    public class Registration
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid EventId { get; set; }
        public Guid ParticipantId { get; set; }
        public DateTime RegistrationDate { get; set; }

        [Required]
        public string Status { get; set; } = null!; // "Confirmed", "Pending"

        [ForeignKey(nameof(EventId))]
        public Event? Event { get; set; }

        [ForeignKey(nameof(ParticipantId))]
        public Participant? Participant { get; set; }
    }
}