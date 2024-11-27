using CarMeeting.Data.Models;
using CarMeetinig.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarMeeting.Data
{
    public class CarMeetingDbContext : IdentityDbContext
    {
        public CarMeetingDbContext()
        {
            
        }

        public CarMeetingDbContext(DbContextOptions<CarMeetingDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Event> Events { get; set; } = null!;
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Judging> Judgings { get; set; }

    }
}
