namespace WeddingInvitationAPI.Models
{
    public class Rsvp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int NumberOfGuests { get; set; }
        public string MealPreference { get; set; }
        public string Message { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.UtcNow;
    }
}
