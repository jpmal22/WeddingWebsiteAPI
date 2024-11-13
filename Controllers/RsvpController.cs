using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingInvitationAPI.Data;
using WeddingInvitationAPI.Models;

namespace WeddingInvitationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RsvpController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RsvpController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/Rsvp
        [HttpPost]
        public async Task<ActionResult<Rsvp>> PostRsvp(Rsvp rsvp)
        {
            _context.Rsvps.Add(rsvp);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRsvp), new { id = rsvp.Id }, rsvp);
        }

        // GET: api/Rsvp/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rsvp>> GetRsvp(int id)
        {
            var rsvp = await _context.Rsvps.FindAsync(id);

            if (rsvp == null)
            {
                return NotFound();
            }

            return rsvp;
        }
    }
}
