using jsr_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jsr_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommController : ControllerBase
    {
        [HttpGet("GetData")]
        public IActionResult GetData()
        {
           
            return Ok();
        }
        [HttpPost("Save")]
        public IActionResult Save([FromBody] ObjClass req)
        {
            return Ok();
        }
        [HttpPut("Chng")]
        public IActionResult Chng([FromBody] ObjClass req)
        {
            return Ok();
        }
        [HttpDelete("Rmv/{Id}")]
        public IActionResult Rmv(int Id)
        {
            return Ok();
        }

       
    }
}
