using CarMeetinig.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using static CarMeeting.Common.EntityValidationConstants.Event;

namespace CarMeeting.Data.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
                builder.HasKey(e => e.Id);

                builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

                builder.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(LocationMaxLength);

            builder.Property(e => e.Description)
               .IsRequired()
               .HasMaxLength(DescriptionMaxLength);

            builder.HasData(SeedEvents());
        }

        private List<Event> SeedEvents()
        {
            List<Event> events = new List<Event>()
            {
                new Event()
                {
                    Name = "Honda Fest 2025",
                    Date = new DateTime(2025, 09, 12),
                    Location = "Kaloyanovo",
                    Description = "Honda Fest is intended to bring together Honda fans and enthusiasts with their cars to enjoy plesant moments and emotions with their favourite car brand."
                },
                new Event()
                {
                    Name = "BMW Fest 2025",
                    Date = new DateTime(2025, 07, 15),
                    Location = "Plovdiv",
                    Description = "BMW Fest is intended to bring together BMW fans and enthusiasts with their cars to enjoy plesant moments and emotions with their favourite car brand."
                }
            };

            return events;
        }
    }
}
