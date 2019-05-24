using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BirthdayCardGenerator.Models
{
    public class CardAttributes
    {
        [Required(ErrorMessage = "Please Enter From Name")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please Enter To Name")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please Enter Message")]
        public string Message { get; set; }

    }
}