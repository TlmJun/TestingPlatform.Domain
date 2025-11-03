using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class Answer
    {
        public int Id { get; set; }

        public required string Text { get; set; }

        public required bool IsCorrect { get; set; }

        public required int QuestionId { get; set; }    

        public List<UserSelectedOption> UserSelectedOptions { get; set; } = new List<UserSelectedOption>();
        public Question? Question { get; set; }
    }
}
