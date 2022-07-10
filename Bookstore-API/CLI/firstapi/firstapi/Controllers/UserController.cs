using Microsoft.AspNetCore.Mvc;
using Book.repositery;

namespace firstapi.Controllers
{
    [ApiController]
    [Route("GetUser")]
    public class UserController : Controller
    {
        UserRepository _repository = new UserRepository();
        [HttpGet]

        public IActionResult GetUser()
        {
            return Ok(_repository.GetUsers());
        }
    }
}
