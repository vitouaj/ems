using System.Text.Json.Serialization;

namespace EventAPI.Models;

public class Event : Entity
{
    public override Guid Id { get; set; }
    public int NumberOfParticipant { get; set; }
    public DateOnly StartedDate { get; set; }
    public DateOnly EndedDate { get; set; }
    public Guid CategoryId { get; set; }
    [JsonIgnore]
    public Category Category { get; set; } = null!;
    public Guid VenueId { get; set; }
    [JsonIgnore]
    public Venue Venue { get; set; } = null!;
    public List<Session> Sessions { get; set; } = [];
    public Event(Guid id, string name, string? description, Guid createdBy, Guid updatedBy,
                 int numberOfParticipant, DateOnly startedDate, DateOnly endedDate,
                 Guid categoryId, Guid venueId)
        : base(name, description, createdBy, updatedBy)
    {
        NumberOfParticipant = numberOfParticipant;
        StartedDate = startedDate;
        EndedDate = endedDate;
        CategoryId = categoryId;
        VenueId = venueId;
        Id = id;
    }
    public Event() { }
}

