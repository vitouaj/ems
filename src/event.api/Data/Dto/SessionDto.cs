namespace EventAPI;

public class SessionDto
{
    public Guid EventId {get; set;}
    public string? Name {get; set;}
    public string? Description {get;set;}
    public DateOnly Date {get; set;}
    public TimeOnly StartAt {get; set;}
    public TimeOnly EndAt {get; set;}
}
