using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        //add the page numbers 
        public string PageNumber { get; set; }


        [Required(ErrorMessage = "Please enter the valid ISBN in this format: xxx-xxxxxxxxxxx (13 digits with one symbol)")]
        [MaxLength(14,ErrorMessage = "Please enter the valid ISBN in this format: xxx-xxxxxxxxxxx (13 digits with one symbol)")]
        [MinLength(14, ErrorMessage = "Please enter the valid ISBN in this format: xxx-xxxxxxxxxxx (13 digits with one symbol)")]
        public string ISBN { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        
        
        
    }
}
