namespace CodingIO.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Guid InstructorId { get; set; }
    
    public Instructor Instructor { get; set; }
    
}