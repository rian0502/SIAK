﻿using System.ComponentModel.DataAnnotations;

namespace Presensi360.Models
{
    public class CompanyModel
    {
        private readonly string _TABLE = "company";
        [Key]
        public int CompanyID { get; set; }
        public string? CompanyCode { get; set; }
        public string? CompanyName { get; set; }
        public int? LocationID { get; set; }

        //Relational Model
        public LocationModel? Location { get; set; } //Belongs to Location

        //Log Attributes
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
