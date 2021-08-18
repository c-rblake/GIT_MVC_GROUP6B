using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GIT_MVC_GROUP6B.Models.Entities
{
    // New class 21-08-18 15:18
    public class Thing1
    {
        [Required]
        public int Id { get; set; }
        
        [Display(Name = "Person")]
        public string Name { get; set; }

        [Range(1,145)]
        public int Age { get; set; }
    }
}
