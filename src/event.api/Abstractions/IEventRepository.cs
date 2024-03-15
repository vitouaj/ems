using EventAPI.Models;

namespace EventAPI;

public interface IEventRepository
{
    Task<object?> GetById(Guid id);
    Task<object?> Create(EventDto eventDto);
    Task<object?> Update(Guid id, EventDto eventDto);
    Task<bool> Delete(Guid id);
    Task<List<object>?> GetAll(int pageSize, int pageIndex);
}
