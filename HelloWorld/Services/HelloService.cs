using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class HelloService
    {
        private readonly HWContext _context;

        public HelloService() { }
        public HelloService(HWContext context)
        {
            //temp until db connection established
            context.Worlds.Add(new World { Name = "World" });

            _context = context;
            _context.SaveChanges();
        }

        public string GetWorldName(string world = "World")
        {
            return $"Hello {world}";
        }

        public async Task<ActionResult<string>> GetWorldNameAsync()
        {
            var world = await _context.Worlds.FirstAsync();
            return $"Hello {world.Name}";
        }


        public async Task<ActionResult<string>> GetWorldNameByIdAsync(long id)
        {
            var world = await _context.Worlds.FindAsync(id);

            if (world == null)
            {
                return $"Hello {new Galaxy { Name = "Galaxy" }.Name}";
            }

            return $"Hello {world?.Name}";
        }
    }
}
