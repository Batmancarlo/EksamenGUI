using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCityWeb.Models
{
    public class Tree
    {
        [Key]
        public string TreeID { get; set; }
        [Required(ErrorMessage = ("This is required"))]
        public string TreeSort { get; set; }
        [Required(ErrorMessage = ("This is required"))]
        public string NumberOfTrees { get; set; }

        public int LocationID { get; set; }
        public Location Location { get; set; }


    }
}
