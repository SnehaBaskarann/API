using Microsoft.AspNetCore.Mvc;
namespace DeleteApi.Controllers;
using DeleteApi.Data;
[ApiController]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;
    public UserController(AppDbContext context)
    {
        _context = context;
    }
    [Route("Deleteuser/{id}")]
    [HttpDelete]
    public async Task<IActionResult> Deleteuser(int id)
    {
        if (id < 1)
            return BadRequest();
        var user = await _context.Usermodels.FindAsync(id);
        if (user == null)
            return NotFound();
        _context.Usermodels.Remove(user);
        await _context.SaveChangesAsync();
        return Ok();
    }

}

