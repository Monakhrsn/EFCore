using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Entities;

// [Index(nameof(Email), IsUnique = true)]
public class UserEntity
{
    [Key]
    public int Id { get; set; }
    // [StringLength(50)]
    public string? FirstName { get; set; }
    public string? LastName { get; set; } 
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}