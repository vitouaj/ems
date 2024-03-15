using AutoMapper;
using EventAPI.Data;
using EventAPI.Exceptions;
using EventAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventAPI.Services;

public class EventRepository(IMapper mapper, ILogger<Event> logger, AppDbContext db) : IEventRepository
{
    private readonly ILogger<Event> _logger = logger;
    private IMapper GetConfiguredMapper()
    {
        var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventDto>();
                cfg.CreateMap<EventDto, Event>();
            }
            );
        return new Mapper(config);
    }
    private readonly AppDbContext _db = db;
    private IMapper _mapper = mapper;
    public async Task<object?> Create(EventDto eventDto)
    {
        if (eventDto == null)
            return null;
        try
        {
            _mapper = GetConfiguredMapper();
            var newEvent = _mapper.Map<Event>(eventDto);

            await _db.Events.AddAsync(newEvent);
            await _db.SaveChangesAsync();
            return newEvent;
        }
        catch (Exception e)
        {
            _logger.LogInformation(e.Message);
            return null;
        }
    }

    public async Task<bool> Delete(Guid id)
    {
        var dbEvent = await _db.Events.FirstOrDefaultAsync(e => e.Id == id);
        if (dbEvent == null)
            return false;
        _db.Events.Remove(dbEvent);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<List<object>?> GetAll(PaginationRequest request)
    {
        var events = await _db.Events
            .Include(e => e.Sessions)
            .Select(e => new
            {
                e.Id,
                e.Name,
                e.Description,
                e.NumberOfParticipant,
                Category = new
                {
                    e.CategoryId,
                    e.Category.Name,
                    e.Category.Description
                },
                Venue = new
                {
                    e.Venue.Id,
                    e.Venue.Name,
                    e.Venue.Description,
                    e.Venue.GoogleMapUrl
                },
                e.CreatedBy,
                e.CreatedAt,
                e.UpdatedBy,
                e.UpdatedAt,
                Sessions = e.Sessions.Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Description,
                    s.StartedAt,
                    s.EndedAt,
                    s.UpdatedBy,
                    s.UpdatedAt
                }).ToList()
            })
            .Skip(request.NumberOfItems * request.PageNumber)
            .Take(request.NumberOfItems)
            .ToListAsync();

        var eventsAsObjects = events.Select(e => (object)e).ToList();
        return eventsAsObjects;
    }

    public async Task<object?> GetById(Guid id)
    {
        var dbEvent = await _db.Events
            .Select(e => new
            {
                e.Id,
                e.Name,
                e.Description,
                e.NumberOfParticipant,
                Category = new
                {
                    e.CategoryId,
                    e.Category.Name,
                    e.Category.Description
                },
                Venue = new
                {
                    e.Venue.Id,
                    e.Venue.Name,
                    e.Venue.Description,
                    e.Venue.GoogleMapUrl
                },
                e.CreatedBy,
                e.CreatedAt,
                e.UpdatedBy,
                e.UpdatedAt,
                Sessions = e.Sessions.Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Description,
                    s.StartedAt,
                    s.EndedAt,
                    s.UpdatedBy,
                    s.UpdatedAt
                }).ToList()
            })
            .FirstOrDefaultAsync(e => e.Id == id);

        if (dbEvent == null)
        {
            throw new EventNotFound("Can't find event with id");
        }
        return dbEvent;
    }

    public async Task<object?> Update(Guid id, EventDto eventDto)
    {
        var dbEvent = await _db.Events.FirstOrDefaultAsync(e => e.Id == id);

        if (dbEvent == null)
            throw new EventNotFound("Invalid Id");

        try
        {
            _mapper = GetConfiguredMapper();
            dbEvent = _mapper.Map<EventDto, Event>(eventDto, dbEvent);
            await _db.SaveChangesAsync();
            return dbEvent;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw new UpdatedFailed("Update failed");
        }
    }

    public Task<object?> Update(EventDto eventDto)
    {
        throw new NotImplementedException();
    }
}
