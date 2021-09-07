using Microsoft.AspNetCore.Mvc;
using SocialsApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialsApp.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly SocialsDB _context;

        public UsersController(SocialsDB context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {

            var users = _context.AppUsers.ToList();
            return users;
        }

        //api/users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsersById(int id)
        {

            var user = _context.AppUsers.Find(id);
            return user;
        }




    }
}