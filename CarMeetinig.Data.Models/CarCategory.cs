using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMeeting.Data.Models
{
    public class CarCategory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public ICollection<Car> Cars { get; set; } 
            = new List<Car>();
    }
}
