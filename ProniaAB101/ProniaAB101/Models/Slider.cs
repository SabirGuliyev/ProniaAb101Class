﻿using ProniaAB101.Models.Base;

namespace ProniaAB101.Models
{
    public class Slider:BaseEntity
    {
        public string PrimaryTitle { get; set; }
        public string SecondaryTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
    }
}
