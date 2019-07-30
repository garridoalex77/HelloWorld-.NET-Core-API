using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HelloWorld
{
    public interface IHelloService
    {
        string GetWorldName(string world);

        Task<ActionResult<string>> GetWorldNameAsync();

        Task<ActionResult<string>> GetWorldNameByIdAsync(long id);
    }
}