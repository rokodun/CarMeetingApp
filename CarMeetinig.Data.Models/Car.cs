using CarMeetinig.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMeeting.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int ParticipantId { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public string Color { get; set; } = null!;
        public int CarCategoryId { get; set; }
        public Participant? Participant { get; set; }
        public CarCategory? CarCategory { get; set; }
        public ICollection<Judging> Judgings { get; set; } 
            = new List<Judging>();
    }
}
