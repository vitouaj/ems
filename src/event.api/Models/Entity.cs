namespace EventAPI.Models;

public abstract class Entity
{
    public virtual Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid UpdatedBy { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    protected Entity(string name, string? description, Guid createdBy, Guid updatedBy)
    {
        Name = name;
        Description = description;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
    }
    protected Entity() { }
}