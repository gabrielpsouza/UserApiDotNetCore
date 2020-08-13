using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserApi.Context;
using UserApi.Models;

namespace UserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly DbConn _conn;
        
        public UserController(DbConn dbConn)
        {
            _conn = dbConn;
        }

        [HttpGet]
        public IEnumerable<UserModel> Get()
        {
            var data = _conn.User.ToList();
            return data;
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserModel user)
        {
            var data = _conn.User.Add(user);
            _conn.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel user)
        {
            var data = _conn.User.Update(user);
            _conn.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var data = _conn.User.Where(a => a.UserId == id).FirstOrDefault();
            _conn.User.Remove(data);
            _conn.SaveChanges();
            return Ok();

        }
    }
}