using Microsoft.AspNetCore.Mvc;
namespace UpdateApi.Controllers;

using UpdateApi.Data;
using Microsoft.EntityFrameworkCore;

[ApiController]
public class UserController : ControllerBase
{
    private readonly AppDbContext _context;
    public UserController(AppDbContext context)
    {
        _context = context;
    }
    [Route("Updateuser")]
    [HttpPut]
    // public async Task<IActionResult> Updateuser(Usermodel userdata)
    // {
    //     if (userdata == null || userdata.Id == 0)
    //         return BadRequest();

    //     var user = await _context.Usermodels.FindAsync(userdata.Id);
    //     if (user == null)
    //         return NotFound();
    //     user.Username = userdata.Username;
    //     user.Email = userdata.Email;
    //     user.Password = userdata.Password;
    //     await _context.SaveChangesAsync();
    //     return Ok();
    // }
[HttpPut ("{id}")]
         public async Task<ActionResult> Update(int id, Usermodel user)
         {
            if (id != user.Id)
                   return BadRequest();
            _context.Entry(user).State =EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
         }


}

 


