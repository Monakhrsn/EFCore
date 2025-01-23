using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    // This is support for the time that we use add migration
    // however another connectionString which is located in program.cs/presentation,
    // supports when the program runs
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer(
            @"Server=localhost;Database=EFCoreDB;User Id=sa;Password=VerySecret1234;TrustServerCertificate=True;Encrypt=False");
        return new DataContext(optionsBuilder.Options);
    }
}