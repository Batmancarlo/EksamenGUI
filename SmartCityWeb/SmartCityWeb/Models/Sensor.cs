using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCityWeb.Models
{
    public class Sensor
    {
        [Key]
        public string SensorID { get; set; }
        [Required (ErrorMessage = ("This is required"))]
        [MaxLength(16)]
        [MinLength(16)]
        [RegularExpression("[0-9a-fA-F]+",
            ErrorMessage = "Has to be hexadecimal")]
        public string HexaDecimalID { get; set; }
        [Required(ErrorMessage = ("This is required"))]
        public string TreeSort { get; set; }
        [Required(ErrorMessage = ("This is required"))]
        public double GPSLon { get; set; }
        [Required(ErrorMessage = ("This is required"))]
        public double GPSLan { get; set; }
        
        public int LocationID { get; set; }
        public Location Location { get; set; }
    }
}
