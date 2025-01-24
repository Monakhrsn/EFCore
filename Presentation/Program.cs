using System.Security.Authentication.ExtendedProtection;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Business.Services;
using Presentation.Dialogs;


var serviceCollection = new ServiceCollection();

// register in our service

serviceCollection.AddDbContext<DataContext>(options =>
    options.UseSqlServer(
        @"Server=localhost;Database=EFCoreDB;User Id=sa;Password=VerySecret1234;TrustServerCertificate=True;Encrypt=False"));
serviceCollection.AddScoped<IUserService, UserService>();
serviceCollection.AddScoped<IMenuDialogs, MenuDialogs>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var menuDialogs = serviceProvider.GetRequiredService<IMenuDialogs>();

while (true)
{
    menuDialogs.NewUserDialog();
    menuDialogs.ViewAllUsersDialog();
}