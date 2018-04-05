using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogdoGabrielMoraes.Models
{
    public class Post
    {

        public int Id { get; set; }
        [Required]
        [StringLength(500)]
        public string title { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        [Required]
        [StringLength(3000)]
        [AllowHtml]
        public string PostingBody { get; set; }
        public byte[] Image { get; set; }
    }
}
