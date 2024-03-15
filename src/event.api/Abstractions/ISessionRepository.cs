namespace EventAPI.Abstactions;

public interface ISessionRepository
{
    Task<object?> GetById(Guid eventId, Guid sessionId);
    Task<object?> Create(SessionDto sessionToCreate);
    Task<object?> Update(Guid sessionId, SessionDto sessionToUpdate);
    Task<bool> Delete(Guid eventId, Guid sessionId);
    Task<List<object>?> GetAll(Guid eventID);
}
