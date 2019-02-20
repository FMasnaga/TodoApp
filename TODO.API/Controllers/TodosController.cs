using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TODO.API.Data;
using TODO.API.Model;

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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem  (int id){
            var item = await context.TODOS.FindAsync(id);
            if (item == null){
                return NotFound();
            }

            context.TODOS.Remove(item);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Item>> createItem (Item item){
            context.TODOS.Add(item);
            await context.SaveChangesAsync();
            
            return CreatedAtAction("createItem", item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateItem (int id, Item updatedItem){

            if (id != updatedItem.Id){
                return BadRequest();
            }
            
            context.Entry(updatedItem).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}