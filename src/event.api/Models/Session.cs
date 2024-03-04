
using System.Text.Json.Serialization;

namespace EventAPI.Models;

public class Session(
    string name,
    string? description,
    Guid createdBy,
    Guid updatedBy,
    Guid eventId,
    DateOnly date,
    TimeOnly startedAt,
    TimeOnly endedAt
        ) : Entity(name, description, createdBy, updatedBy)
{
    public Guid EventId { get; set; } = eventId;
    public DateOnly Date { get; set; } = date;

    [JsonIgnore]
    public Event Event { get; set; } = null!;
    public TimeOnly StartedAt { get; set; } = startedAt;
    public TimeOnly EndedAt { get; set; } = endedAt;
}
