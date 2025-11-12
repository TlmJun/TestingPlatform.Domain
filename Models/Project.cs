using System.ComponentModel.DataAnnotations;
namespace TestingPlatform.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Group>? Groups { get; set; }
        public List<Test> Tests { get; set; } = new List<Test>();
    }
}
