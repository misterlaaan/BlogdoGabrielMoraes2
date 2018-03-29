using System;
using System.ComponentModel.DataAnnotations;

namespace BlogdoGabrielMoraes.Models
{
    public class Post
    {       
        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        [Required]
        [StringLength(8000)]
        public string PostingBody { get; set; }
    }
}
}