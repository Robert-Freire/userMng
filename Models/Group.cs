using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;  
  
namespace UserMng.Models  
{  
    public class Group  
    {  
        public int GroupId { get; set; }  
        [Required]  
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

    }  
}
