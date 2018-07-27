using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "ISBN-13")]
        public string SerialNumber { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}