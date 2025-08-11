using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SkillSnap.Shared.Models
{
    public class PortfolioUser
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ProfileImageUrl { get; set; }

        // Navigation Property.
        public List<Project> Projects { get; set; } = [];
        public List<Skill> Skills { get; set; } = [];
    }
}
