using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using RestApi.API.Models;

namespace RestApi.API.Models
{
    public class Ad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }

        [StringLength(1000, MinimumLength = 30)]
        [Required]
        public string Desc { get; set; }

        public float Price{ get; set; }

        public bool phone_contact{ get; set; }

        public bool email_contact { get; set; }

        [StringLength(10)]
        public string Phone{ get; set; }

        // Foreign Key
        [Required]
        public int CategoryId { get; set; }
        // Navigation property
        public Category Category { get; set; }

        // Foreign Key
        [Required]
        public int SubcategoryId { get; set; }
        // Navigation property

        // Foreign Key
        [Required]
        public String UserId { get; set; }
        // Navigation property
    }
}