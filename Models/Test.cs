using System.ComponentModel.DataAnnotations;

namespace TestingPlatform.Domain.Models
{
    public class Test
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsRepeatable { get; set; } = false;
        public TestType Type { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
        public required DateTimeOffset PublishedAt { get; set; }
        public required DateTimeOffset Deadline { get; set; }
        public int DurationMinutes { get; set; }
        public bool IsPublic { get; set; } = false;
        public int PassingScore { get; set; }
        public int MaxAttempts { get; set; }

        public List<Attempt> Attempts { get; set; } = new List<Attempt>();
        public List<TestResult> TestResults { get; set; } = new List<TestResult>();
        public List<Question> Questions { get; set; } = new List<Question>();
        public List<Group>? Groups { get; set; } = new List<Group>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Direction> Directions { get; set; } = new List<Direction>();
    }
    public enum TestType
    {
        Education = 1,
        Activity = 2,
        Other = 3
    };
    public enum AnswerType
    {
        Single = 1,
        Multiple = 2,
        Text = 3
    }
}




