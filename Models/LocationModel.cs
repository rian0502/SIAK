﻿using System.ComponentModel.DataAnnotations;

namespace Presensi360.Models
{
    public class LocationModel
    {
        private readonly string _TABLE = "location";
        [Key]
        public int LocationID { get; set; }
        public string? LocationCode { get; set; }
        public string? LocationName { get; set; }
        //Relational Model
        public CompanyModel? Company { get; set; } //Has many to Company

        //Log Attributes
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
