using Microsoft.EntityFrameworkCore;
using WebApp_02.Domain;

namespace WebApp_02.Infractructure;

public static class DbInitializer
{
    public static void Initialize(DbContext context)
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        context.Set<Contact>().Add(new Contact
        {
            Subject = "Ceci est un sujet",
            Email = "test@test.be",
            Message = "Ceci est un message"
        });

        context.SaveChanges();
    }
}