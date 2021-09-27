﻿using API_Test.Data;
using API_Test.Models;
using API_Test.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        Password password;
        private readonly TruckContext _context;
        public UsersController(TruckContext context)
        {
            _context = context;
            password = new Password();
        }


        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<ApplicationUser> Get()
        {
            return _context.ApplicationUsers.ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{email}/{pass}")]
        public bool Get(string email,string pass)
        {
            var user = _context.ApplicationUsers.FirstOrDefault(e => e.Email == email);

            if (user == null)
            {
                return false;
            }

            var result  = password.ValidatePassword(user, user.PasswordHash,pass);

            return result;
        }
       
        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
