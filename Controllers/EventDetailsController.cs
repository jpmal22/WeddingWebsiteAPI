using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingInvitationAPI.Data;
using WeddingInvitationAPI.Models;

namespace WeddingInvitationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventDetailsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/EventDetails
        [HttpGet]
        public async Task<ActionResult<EventDetails>> GetEventDetails()
        {
            var eventDetails = await _context.EventDetails.FirstOrDefaultAsync();

            if (eventDetails == null)
            {
                return NotFound();
            }

            return eventDetails;
        }

        // POST: api/EventDetails
        [HttpPost]
        public async Task<ActionResult<EventDetails>> PostEventDetails(EventDetails eventDetails)
        {
            _context.EventDetails.Add(eventDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEventDetails), new { id = eventDetails.Id }, eventDetails);
        }
    }
}
