using Api.Data;
using Microsoft.AspNetCore.Mvc;
using SkillSnap.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly SkillSnapContext _context;
        public ProjectsController(SkillSnapContext Context)
        {
            _context = Context;
        }


        // Return all projects.
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var projects = await _context.Projects.ToListAsync();
            return Ok(projects);
        }


        // Return a project by ID.
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        // Add a project.
        [HttpPost]
        public async Task<IActionResult> CreateProject(Project createProject)
        {
            await _context.AddAsync(createProject);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }
    }
}
