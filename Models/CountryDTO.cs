﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace hotel_listing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country name is too long.")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short country name is too long.")]
        public string ShortName { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
    }
}
