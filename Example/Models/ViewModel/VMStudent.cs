using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Example.Models.ViewModel
{
    public partial class VMStudent
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public DateOnly Birth { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public string? ImgUrl { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [Required]
        public string Mssv { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}