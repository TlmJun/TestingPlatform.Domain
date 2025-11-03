using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class UserTextAnswer
    {
        public int Id { get; set; }

        public required string TextAnswer { get; set; }

        public required int UserAttemptAnswerId { get; set; }
        public UserAttemptAnswer? UserAttemptAnswer { get; set; }
    }
}
