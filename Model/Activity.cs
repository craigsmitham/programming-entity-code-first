using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Activity
    {
        [Column(TypeName = "varchar")]
        public int ActivityId { get; set; }
        public string Name { get; set; }

        public List<Trip> Trips { get; set; }
    }
}
