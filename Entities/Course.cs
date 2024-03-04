namespace Entities;

public class Course
{
    public Guid Id { get; set; }
    public Guid CategoryId {  get; set; }
    public Guid InstructorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

}


