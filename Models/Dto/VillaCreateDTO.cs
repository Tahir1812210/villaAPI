﻿using System.ComponentModel.DataAnnotations;

namespace magicvilla_villaAPI.Models.Dto
{
    
    public class VillaCreateDTO
    {




        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Details { get; set; }

        public int Sqft { get; set; }

        public int Occupancy { get; set; }

        public int Rate { get; set; }

        public string ImageUrl { get; set; }

        public string Amenity { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
