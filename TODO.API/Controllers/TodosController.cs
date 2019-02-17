using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TODO.API.Data;

namespace TODO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        public DataContext context;
        public TodosController(DataContext dc)
        {
            context = dc;
        } 

        [HttpGet]
        public async Task<IActionResult> getItems (){
            var todos = await context.TODOS.ToListAsync();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getItem(int id){
            var todo = await context.TODOS.FirstOrDefaultAsync(x=>x.Id==id);
            return Ok(todo);
        }
    }
}