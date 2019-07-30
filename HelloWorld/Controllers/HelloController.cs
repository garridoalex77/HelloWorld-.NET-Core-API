using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        // GET: api/Hello
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return await _helloService.GetWorldNameAsync();
        }

        // GET: api/Hello/5
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GeById(long id)
        {   
            return await _helloService.GetWorldNameByIdAsync(id);
        }
        // POST api/Hello
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Hello/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Hello/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
