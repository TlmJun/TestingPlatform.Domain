using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class UserSelectedOption
    {
        public int Id { get; set; }

        public required int UserAttemptAnswerId { get; set; }

        public required int AnswerId { get; set; }

        public UserAttemptAnswer? UserAttemptAnswer { get; set; }
        public UserTextAnswer? UserTextAnswer { get; set; }
        public Answer? Answer { get; set; }
    }
}
