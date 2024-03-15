namespace EventAPI.Models.Responses;

public record SessionResponse(bool Success, string? Message, object? Payload);
