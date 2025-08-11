using Blazored.LocalStorage;
using SkillSnap.Shared.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace Client.Services
{
    public class ProjectService(IHttpClientFactory httpFact, ILocalStorageService storage)
    {


        // Make HTTP request to get all Projects.
        public async Task<List<Project>> GetProjectsAsync()
        {
            var http = httpFact.CreateClient("MyApi");

            var request = new HttpRequestMessage(HttpMethod.Get, "api/projects");

            var response = await http.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var projects = JsonSerializer.Deserialize<List<Project>>(json);

            //var response = await http.GetFromJsonAsync<List<Project>>("api/projects");

            return projects;
        }


        // Make HTTP request to create a Project.
        public async Task AddProjectAsync(Project project)
        {
            var http = httpFact.CreateClient("MyApi");

            using (var response = await http.PostAsJsonAsync("api/projects", project))
            {
                response.EnsureSuccessStatusCode();

                var projectResp = await response.Content.ReadFromJsonAsync<Project>();

                Console.WriteLine($"{projectResp} \n");
            }


        }
    }
}
