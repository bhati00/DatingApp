using API.Controllers;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace sdfd;
public class BuggyController : BaseApiController
{
    private readonly DataContext _context;
    public BuggyController(DataContext context)
    {
        context = _context;
    }
    [Authorize]
    [HttpGet("auth")]
    public ActionResult<String> GetSecret()
    {
        return "secret text";
    }
   
    [HttpGet("not-found")]
    public ActionResult<AppUser> GetNotFound()
    {
        var thing = _context.Users.Find(-1);
        if(thing == null) return NotFound();
        return thing;
    }
   
    [HttpGet("server-error")]
    public ActionResult<String> GetServerError()
    {
        var thing = _context.Users.Find(-1);
        var thingToReturn = thing.ToString();
        return thingToReturn;
    }
    
    [HttpGet("bad-request")]
    public ActionResult<String> GetBadRequest()
    {
        return BadRequest("this is a bad request");
    }
}