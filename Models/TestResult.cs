using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class TestResult
    {
        public int Id { get; set; }

        public required bool Passed { get; set; }

        public required int TestId { get; set; }

        public required int AttemptId { get; set; }

        public required int StudentId { get; set; }
        public Test? Test { get; set; }
        public Attempt? Attempt { get; set; }
        public Student? Student { get; set; }
    }
}
