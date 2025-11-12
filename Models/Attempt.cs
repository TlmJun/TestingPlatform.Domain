using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class Attempt
    {
        public int Id { get; set; }

        public DateTime StartedAt { get; set; } = DateTime.Now;

        public DateTime? SubmittedAt { get; set; }

        public int? Score { get; set; }

        public required int TestId { get; set; }

        public required int StudentId { get; set; }

        public Test? Test { get; set; }
        public Student? Student { get; set; }
        public List<TestResult> TestResults { get; set; } = new List<TestResult>();
        public List<UserAttemptAnswer>? UserAttemptAnswers { get; set; }
    }
}
