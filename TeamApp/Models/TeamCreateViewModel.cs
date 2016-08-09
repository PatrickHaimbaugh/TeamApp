using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamApp.Models
{
    public class TeamCreateViewModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [MaxLength(500)]
        public string TeamName { get; set; }

        public string Description { get; set; }
    }
}