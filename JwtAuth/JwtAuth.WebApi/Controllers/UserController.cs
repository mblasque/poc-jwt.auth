using System.Threading.Tasks;
using JwtAuth.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using JwtAuth.Services.Implementations;

namespace JwtAuth.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _userServices.GetAll();

            return Ok(result);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create([FromBody]User user)
        {
            await _userServices.Create(user);
            return Ok(user);
        }
    }
}
