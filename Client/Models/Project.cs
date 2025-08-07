using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillSnap.Client.Models
{
    public class RootComponents
    {
        public Project[] Projects { get; set; }
    }

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