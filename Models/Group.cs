using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public required string? Name { get; set; }

        public required int DirectionId { get; set; }
        public required int CourseId { get; set; }
        public required int ProjectId { get; set; }

        public Direction? Direction { get; set; }
        public Course? Course { get; set; }
        public Project? Project { get; set; }
        public List<Student>? Students { get; set; }
        public List<Test> Tests { get; set; } = new List<Test>();
    }
}