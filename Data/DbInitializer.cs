using Lab03.Models;

namespace Lab03.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Rsvps.Any())
            {
                return;
            }

            var registrations = new Rsvp[]
            {
                new Rsvp
                {
                    FullName = "John Smith",
                    NeedsAccommodation = false,
                    WorkshopTitle = "ASP.NET Core MVC"
                },
                new Rsvp
                {
                    FullName = "Jane Doe",
                    NeedsAccommodation = true,
                    WorkshopTitle = "Entity Framework Core"
                },
                new Rsvp
                {
                    FullName = "Michael Brown",
                    NeedsAccommodation = false,
                    WorkshopTitle = "Introduction to C#"
                }
            };

            context.Rsvps.AddRange(registrations);
            context.SaveChanges();
        }
    }
}
