using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Data.Entities;

// [Index(nameof(Email), IsUnique = true)]
public class UserEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    // [StringLength(50)]
    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;
    
    [Required]
    [Column(TypeName = "varchar(150)")]
    public string Email { get; set; } = null!;
    
    [Required]
    [Column(TypeName = "varchar(max)")]
    public string Password { get; set; } = null!;
}