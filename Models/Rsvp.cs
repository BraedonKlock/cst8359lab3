namespace Lab03.Models
{
    public class Rsvp
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public bool NeedsAccommodation { get; set; }

        public string WorkshopTitle { get; set; } = string.Empty;
    }
}
