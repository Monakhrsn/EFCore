using Business.Services;
using Data.Entities;

namespace Presentation.Dialogs;

public class MenuDialogs (IUserService userService) : IMenuDialogs
{
    private readonly IUserService _userService = userService;

    public void NewUserDialog()
    {
        var userEntity = new UserEntity();

        Console.Clear();
        Console.WriteLine("--- Creating new User ---");
        Console.Write("First Name: ");
        userEntity.FirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        userEntity.LastName = Console.ReadLine();
        Console.Write("Email: ");
        userEntity.Email = Console.ReadLine();
        Console.Write("Password: ");
        userEntity.Password = Console.ReadLine();
        Console.WriteLine();

        var result = _userService.CreateUser(userEntity);

        if (result != null)
        {
            Console.WriteLine($"Following user was created with id {result.Id}. ");
            Console.WriteLine($"{result.FirstName} {result.LastName} {result.Email}");
        }
        else
        {
            Console.WriteLine("Something went wrong when trying to create user.");
        }
        
        Console.ReadKey();
    }

    public void ViewAllUsersDialog()
    {
        Console.Clear();
        Console.WriteLine("--- View All Users ---");

        // Fetch all users using IUserService
        var users = _userService.GetUsers();

        var userEntities = users.ToList();
        if (userEntities.Any())
        {
            // Display each user's details
            foreach (var user in userEntities)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.FirstName} {user.LastName}, Email: {user.Email}");
            }
        }
        else
        {
            Console.WriteLine("No users found.");
        }

        Console.ReadKey();
    }
}
