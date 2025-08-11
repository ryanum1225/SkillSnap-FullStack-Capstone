using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SkillSnap.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstInitial { get; set; }
        public string LastName { get; set; }
    }
}
