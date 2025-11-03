using System.ComponentModel.DataAnnotations;

namespace TestingPlatform.Domain.Models
{
    public class Question
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required int Number { get; set; }

        [MaxLength(2000)]
        public string? Description { get; set; }
        public required string AnswerType { get; set; }
        public bool IsScoring { get; set; } = true;
        public int? MaxScore { get; set; }
        public required int TestId { get; set; }

        public Test? Test { get; set; }
        public List<UserAttemptAnswer>? UserAttemptAnswers { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
