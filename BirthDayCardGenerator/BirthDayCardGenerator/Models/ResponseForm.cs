using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthDayCardGenerator.Models
{
    public class ResponseForm
    {
     
        [Required]
        public string Sender { get; set; }
        
        [Required]
        public string Recipient { get; set; }
        
        [Required]
        public string Message { get; set; }

    }
}
