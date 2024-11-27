using CarMeetinig.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMeeting.Data
{
    public class CarMeetingDbContext : DbContext
    {
        public CarMeetingDbContext()
        {
            
        }

        public CarMeetingDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public virtual DbSet<Event> Events { get; set; } = null!;

    }
}
