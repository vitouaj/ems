
namespace EventAPI.Models;

public class Category : Entity
{
    public override Guid Id { get; set; }
    public List<Event> Events { get; set; } = [];
    public Category(Guid id, string name, string? description, Guid createdBy, Guid updatedBy) : base(name, description, createdBy, updatedBy)
    {
        Id = id;
    }
}
