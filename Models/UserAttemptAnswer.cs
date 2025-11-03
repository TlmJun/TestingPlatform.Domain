using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class UserAttemptAnswer
    {
        public int Id { get; set; }

        public bool IsCorrect { get; set; }

        public int ScoreAwarded { get; set; }

        public required int AttemptId { get; set; }

        public required int QuestionId { get; set; }
        public Attempt? Attempts { get; set; }
        public Question? Questions { get; set; }
        public List<UserSelectedOption> UserSelectedOptions { get; set; } = new List<UserSelectedOption>();
        public UserTextAnswer? UserTextAnswers { get; set; }
    }
}
