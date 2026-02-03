using System.ComponentModel.DataAnnotations;

namespace TestingPlatform.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public required string Phone { get; set; }
        public required string? VkProfileLink { get; set; }
        public required int UserId { get; set; }

        public string? AvatarPath { get; set; }

        public User? User { get; set; }
        public Group? Group { get; set; }
        public List<Test> Tests { get; set; } = new List<Test>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Attempt> Attempts { get; set; } = new List<Attempt>();
        public List<TestResult> TestResults { get; set; } = new List<TestResult>();
    }
}