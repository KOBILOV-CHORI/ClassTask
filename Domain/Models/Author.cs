namespace Domain.Models;

public class Author
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Biography { get; set; }
    public DateTime CreatedAt { get; set; }
}
