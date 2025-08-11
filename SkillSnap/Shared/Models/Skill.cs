using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SkillSnap.Shared.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

        [ForeignKey("PortfolioUser")]
        public int PortfolioUserId { get; set; }

        // Navigation Property.
        public PortfolioUser PortfolioUser { get; set; } = null!;
    }
}
