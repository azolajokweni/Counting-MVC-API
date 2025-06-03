using Microsoft.AspNetCore.Mvc;
using CountingApi.Models;
using CountingApi.Services;

namespace CountingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountController : ControllerBase
    {
        private readonly CountService _service;

        public CountController()
        {
            _service = new CountService();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CountRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Input))
                return BadRequest("Input is required.");

            var items = request.Input.Split(' ').ToList();
            var result = _service.CountItems(items);

            return Ok(result);
        }
    }
}