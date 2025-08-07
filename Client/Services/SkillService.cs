using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using SkillSnap.Client.Models;

namespace SkillSnap.Client.Services
{
    public class SkillService(HttpClient http)
    {


        // Make HTTP request to get all Skills.
        public async Task<List<Skill>> GetSkillsAsync()
        {
            try
            {
                return await http.GetFromJsonAsync<List<Skill>>("api/skills");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return new List<Skill>();
            }
        }


        // Make HTTP request to add Skill.
    }
}