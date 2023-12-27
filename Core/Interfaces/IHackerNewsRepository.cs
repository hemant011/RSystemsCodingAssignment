
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace r_systems_assignment.Core.Interfaces
{
    public interface IHackerNewsRepository
    {
        Task<HttpResponseMessage> BestStoriesAsync();
        Task<HttpResponseMessage> GetStoryByIdAsync(int id);

    }
}