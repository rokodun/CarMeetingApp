using System.ComponentModel.DataAnnotations;
using static CarMeeting.Common.EntityValidationConstants.Car;

namespace CarMeeting.Web.ViewModels.Car
{
    public class CreateCarViewModel
    {
        [Required]
        [MinLength(MakeMinLength)]
        [MaxLength(MakeMaxLength)]
        public string Make { get; set; } = null!;

        [Required]
        [MinLength(ModelMinLength)]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;

        [Required]
        public int Year { get; set; }

        [Required]
        [MinLength(ColorMinLength)]
        [MaxLength(ColorMaxLength)]
        public string Color { get; set; } = null!;

        [Required]
        public string CarCategoryId { get; set; } = null!;


    }
}
