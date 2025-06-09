using Microsoft.EntityFrameworkCore;
using UFSEstates.Models;

namespace UFSEstates.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Complaint> Complaints { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed complaint
            modelBuilder.Entity<Complaint>().HasData(
            new Complaint
            {
                Id = 1,
                Complainant = "Ben",
                Service = "Water",
                Description = "There is a leaking pipe near the parking lot of the Library Building.",
                DateOfComplaint = DateTime.Parse("2025-02-24")
            },

            new Complaint
            {
                Id = 2,
                Complainant = "Sandy",
                Service = "Water",
                Description = "The water supply to the pumps adjacent to Revier Hall is currently not functioning.",
                DateOfComplaint = DateTime.Parse("2025-02-22")
            },

            new Complaint
            {
                Id = 3,
                Complainant = "Gert",
                Service = "Electricity",
                Description = "The Computer Science Laboratory has been without electrical power since yesterday.",
                DateOfComplaint = DateTime.Parse("2025-02-21")
            },

            new Complaint
            {
                Id = 4,
                Complainant = "Dean",
                Service = "Electricity",
                Description = "The streetlights near the residential building are malfunctioning.",
                DateOfComplaint = DateTime.Parse("2025-01-25")
            },

            new Complaint
            {
                Id = 5,
                Complainant = "Merry",
                Service = "Cleaning",
                Description = "The main hall has not been cleaned after the graduation ceremony.",
                DateOfComplaint = DateTime.Parse("2025-02-03")
            },

            new Complaint
            {
                Id = 6,
                Complainant = "Meggy",
                Service = "Cleaning",
                Description = "The main university road next to the cafeteria is blocked by trees.",
                DateOfComplaint = DateTime.Parse("2025-02-20")
            },

            new Complaint
            {
                Id = 7,
                Complainant = "Mofokeng",
                Service = "Water",
                Description = "All the new sports field showers do not have running water.",
                DateOfComplaint = DateTime.Parse("2025-01-02")
            },

            new Complaint
            {
                Id = 8,
                Complainant = "Pule",
                Service = "Electricity",
                Description = "The electric sockets in the admin building are not working.",
                DateOfComplaint = DateTime.Parse("2025-02-20")
            },

            new Complaint
            {
                Id = 9,
                Complainant = "Koena",
                Service = "Roads",
                Description = "The road to the admin building needs repairs because the traffic road signs are no longer visible.",
                DateOfComplaint = DateTime.Parse("2024-06-02")
            },

            new Complaint
            {
                Id = 10,
                Complainant = "Lizzy",
                Service = "Parking",
                Description = "There are unauthorized people who are using undercover parking near the old lecture hall building.",
                DateOfComplaint = DateTime.Parse("2025-02-27")
            });
        }
    }
}
