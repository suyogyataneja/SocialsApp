using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialsApp.Entities
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }

    }
}