using System;
using Beerhall.Model;
namespace Beerhall.Data
{
    public static class BeerhallDataInitializer
    {

        public static void InitializeData(ApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            if (dbContext.Database.EnsureCreated())
            {
                Location bavikhove = new Location { Name = "Bavikhove", PostalCode = "8531" };
                Location roeselare = new Location { Name = "Roeselare", PostalCode = "8800" };
                Location puurs = new Location { Name = "Puurs", PostalCode = "2870" };
                Location leuven = new Location { Name = "Leuven", PostalCode = "3000" };
                Location oudenaarde = new Location { Name = "Oudenaarde", PostalCode = "9700" };
                Location affligem = new Location { Name = "Affligem", PostalCode = "1790" };
                Location[] locations =
                    new Location[] { bavikhove, roeselare, puurs, leuven, oudenaarde, affligem };
                dbContext.Locations.AddRange(locations);
                dbContext.SaveChanges();

            }
        }
    }
}
