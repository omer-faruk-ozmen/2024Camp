namespace CodingIO.Entities;

public class Instructor : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Course> Courses { get; set; } = new List<Course>();
}