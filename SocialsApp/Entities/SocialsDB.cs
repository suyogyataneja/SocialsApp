using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialsApp.Entities
{
    public class SocialsDB: DbContext
    {

        public SocialsDB():base("conn")
        { 
           
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}