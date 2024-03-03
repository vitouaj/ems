using System.ComponentModel.DataAnnotations;
using EventAPI.Models;

namespace EventAPI;

public class EventDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    [Required]
    public int NumberOfParticipant { get; set; }
    [Required]
    public Guid CategoryId { get; set; }
    [Required]
    public Guid VenueId { get; set; }
    [Required]
    public DateOnly StartedDate { get; set; }
    [Required]
    public DateOnly EndedDate { get; set; }
    [Required]
    public Guid CreatedBy { get; set; }
    [Required]
    public Guid UpdatedBy { get; set; }
}
