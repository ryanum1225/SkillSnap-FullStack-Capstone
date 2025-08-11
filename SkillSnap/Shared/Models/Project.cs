using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillSnap.Shared.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey("PortfolioUser")]
        public int PortfolioUserId { get; set; }

        // Navigation Property.
        public PortfolioUser PortfolioUser { get; set; } = null!;
    }
}
