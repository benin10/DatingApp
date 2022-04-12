using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }
        [Authorize]
      [HttpGet("auth")]
      public ActionResult<string> GetSecret()
      {
          return "secret text";
      }


 [HttpGet("server-error")]
      public ActionResult<string> GetServerError()
      {
           var user = _context.Users.Find(-1);
          var thingToReturn = user.ToString();
          return Ok(thingToReturn);
      }
 [HttpGet("not-found")]
      public ActionResult<AppUser> GetNotFound()
      {
          var user = _context.Users.Find(-1);
          if(user == null)
          return NotFound();
          else
          return Ok(user);

      }

 [HttpGet("bad-request")]
      public ActionResult<string> GetBadRequest()
      {
          return BadRequest("This was a bad request");
      }

    }
}