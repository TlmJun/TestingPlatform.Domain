using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using TestingPlatform.Domain.Enums;

namespace TestingPlatform.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public required string PasswordHash { get; set; }
        public required string Email { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public UserRole Role { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;

        [JsonIgnore]
        public Student? Student { get; set; }
    }
}


