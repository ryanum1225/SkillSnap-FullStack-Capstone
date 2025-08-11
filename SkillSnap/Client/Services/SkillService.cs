using SkillSnap.Shared.Models;
using System.Net.Http.Json;

namespace Client.Services
{
    public class SkillService(HttpClient http)
    {


        // Make HTTP request to get all Skills.
        public async Task<List<Skill>> GetSkillsAsync()
        {
            return await http.GetFromJsonAsync<List<Skill>>("api/skills");
        }


        // Make HTTP request to add Skill.
        public async Task AddSkillAsync(Skill skill)
        {
            using (var response = await http.PostAsJsonAsync("api/skills", skill))
            {
                response.EnsureSuccessStatusCode();

                var skillResp = await response.Content.ReadFromJsonAsync<Skill>();

                Console.WriteLine($"{skillResp} \n");
            }
        }
    }
}
