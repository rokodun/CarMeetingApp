using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMeeting.Data.Models
{
    public class CarCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;
        public ICollection<Car> Cars { get; set; } 
            = new List<Car>();
    }
}
