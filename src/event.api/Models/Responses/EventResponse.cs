namespace EventAPI.Models.Responses;

public record EventResponse(bool Success, string? Message, object? Payload);

