using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleWebService.Models
{
    public class VehicleDetails
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string VehicleMake { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
