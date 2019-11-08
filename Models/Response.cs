using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Forms.Models
{
    public class Response
    {
        [Required]
        public string FirstName {get; set;}
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public DateTime Date { get; set; }
        [Range(1,10)]
        public int FavoriteNumber { get; set; }

    }
}