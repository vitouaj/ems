
using System.Text.Json.Serialization;

namespace EventAPI.Models;

public class Session : Entity
{
    public Session() {}
    public Session(string name, string? description, Guid createdBy, Guid updatedBy, Guid eventId,
    DateOnly date,
    TimeOnly startedAt,
    TimeOnly endedAt ) 
    : base(name, description, createdBy, updatedBy)
    {
        Date = date;
        StartedAt = startedAt;
        EndedAt = endedAt;
        EventId = eventId;
    }
    public Guid EventId { get; set; } 
    public DateOnly Date { get; set; } 

    [JsonIgnore]
    public Event Event { get; set; } = null!;
    public TimeOnly StartedAt { get; set; } 
    public TimeOnly EndedAt { get; set; }
}
