using API_Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProjects()
        {
            return Ok("Get all projects");
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAProject(int id)
        {
            return Ok($"Get project {id}");
        }
        [HttpPost]
        public IActionResult CreateAProject([FromBody] Project project)
        {
            return Ok(project);
        }
    }
}
