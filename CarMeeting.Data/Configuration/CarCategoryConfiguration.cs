using CarMeeting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarMeeting.Data.Configuration
{
    public class CarCategoryConfiguration : IEntityTypeConfiguration<CarCategory>
    {
        public void Configure(EntityTypeBuilder<CarCategory> builder)
        {
            builder.HasData(SeedCarCategories());
        }
        private List<CarCategory> SeedCarCategories()
        {
            return new List<CarCategory>()
            {
                new CarCategory()
                {
                    Name = "Stock",
                    Description = "This category is only for factory cars. No tuning is allowed."
                },
                new CarCategory()
                {
                    Name = "Tuning",
                    Description = "This category is for tuned cars. No matter engine performance tuned or weight reduction it is tuning."
                },
                new CarCategory()
                {
                    Name = "Retro",
                    Description = "This caregory is for cars over 30 years old. Classics from the early 90's and above."
                }
            };
        }
    }

}