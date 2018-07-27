using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        [Display(Name = "ISBN-13")]
        public string SerialNumber { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public bool IsAvailable { get; set; }
    }
}