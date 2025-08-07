using Microsoft.AspNetCore.Mvc;
using SkillSnap.Api.Models;
using SkillSnap.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace SkillSnap.Api.Controllers
{
    [ApiController]
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        private readonly SkillSnapContext _context;
        public SkillsController(SkillSnapContext Context)
        {
            _context = Context;
        }


        // Get all Skills.
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var skills = await _context.Skills.ToListAsync();
            return Ok(skills);
        }


        // Get Skill by ID
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var skill = await _context.Skills.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }

            return Ok(skill);
        }


        // Create Skill.
        [HttpPost]
        public async Task<IActionResult> CreateSkill(Skill createSkill)
        {
            await _context.AddAsync(createSkill);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = createSkill.Id }, createSkill);
        }
    }
}