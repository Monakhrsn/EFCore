using System.Security.Authentication.ExtendedProtection;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

// register in our service

serviceCollection.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        @"Server=localhost;Database=EFCoreDB;User Id=sa;Password=VerySecret1234;TrustServerCertificate=True;Encrypt=False"));

var serviceProvider = serviceCollection.BuildServiceProvider();
