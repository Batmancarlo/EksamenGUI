using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCityWeb.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        [Required(ErrorMessage = ("This is required"))]
        public string Name { get; set; }
        public string RoadName { get; set; }
        public string RoadNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }

        
        public List<Tree> Trees { get; set; }
        public List<Sensor> Sensors { get; set; }

      

    }
}
