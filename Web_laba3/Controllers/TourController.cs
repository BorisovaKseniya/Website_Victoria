using Microsoft.AspNetCore.Mvc;
using Web_laba3.DataContext;

namespace Web_laba3.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class TourController : ControllerBase
    {
        private readonly DataBaseContext _context;
        public TourController(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetTours()
        {
            var tours = _context.Tours.ToList();
            return Ok(tours);
        }
    }
}
    

/*
    [HttpGet("search")]
    public async Task<ActionResult<IEnumerable<Tour>>> SearchTours([FromQuery] string query)
    {
        if (string.IsNullOrEmpty(query))
        {
            return BadRequest("Query parameter is required.");
        }

        var tours = await _context.Tours
            .Where(t => EF.Functions.Like(t.TourName, $"%{query}%"))
            .ToListAsync();

        return Ok(tours);

    }*/

