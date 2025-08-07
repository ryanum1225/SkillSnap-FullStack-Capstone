using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SkillSnap.Client.Models;

namespace SkillSnap.Client.Services
{
    public class ProjectService(HttpClient http)
    {


        // Make HTTP request to get all Projects.
        public async Task<List<Project>> GetProjectsAsync()
        {
            return await http.GetFromJsonAsync<List<Project>>("api/projects");
        }


        // Make HTTP request to create a Project.
        public async Task AddProjectAsync(Project project)
        {
            using (var response = await http.PostAsJsonAsync("api/projects", project))
            {
                response.EnsureSuccessStatusCode();

                var projectResp = await response.Content.ReadFromJsonAsync<Project>();

                Console.WriteLine($"{projectResp} \n");
            }
            

        }
    }
}