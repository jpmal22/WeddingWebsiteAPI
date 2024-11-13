using Microsoft.EntityFrameworkCore;
using WeddingInvitationAPI.Models;

namespace WeddingInvitationAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rsvp> Rsvps { get; set; }
        public DbSet<EventDetails> EventDetails { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
