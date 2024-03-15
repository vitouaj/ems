using AutoMapper;
using EventAPI.Abstactions;
using EventAPI.Data;
using EventAPI.Exceptions;
using EventAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EventAPI.Services;

public class SessionRepository(AppDbContext db, ILogger<SessionDto> logger, IMapper mapper) : ISessionRepository
{
    private readonly AppDbContext _db = db;
    private IMapper _mapper = mapper;
    private readonly ILogger<SessionDto> _logger = logger;
    private IMapper GetConfiguredMapper()
    {
        var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Session, SessionDto>();
                cfg.CreateMap<SessionDto, Session>();
            }
            );
        return new Mapper(config);
    }
    public async Task<object?> Create(SessionDto sessionToCreate)
    {
       if (sessionToCreate == null)
            return null;
        try
        {
            _mapper = GetConfiguredMapper();
            var newSession = _mapper.Map<Session>(sessionToCreate);

            await _db.Sessions.AddAsync(newSession);
            await _db.SaveChangesAsync();
            return newSession;
        }
        catch (Exception e)
        {
            _logger.LogInformation(e.Message);
            return null;
        }
    }

    public async Task<bool> Delete(Guid eventId, Guid sessionId)
    {
        var session = await _db.Sessions.Where(s => s.EventId == eventId && s.Id == sessionId).FirstOrDefaultAsync();
        if (session is null) 
            throw new SessionNotFound("Session not found!");
        else {
            _db.Sessions.Remove(session);
            await _db.SaveChangesAsync();
        }
        return session == null ? false : true;
    }

    public async Task<List<object>?> GetAll(Guid eventID)
    {
        var sessions = await _db.Sessions
        .Where(s => s.EventId == eventID)
        .Select(s => new {
            s.EventId,
            s.Id,
            s.Name,
            s.Description,
            s.Date,
            s.StartedAt,
            s.EndedAt,
            s.UpdatedAt
        })
        .ToListAsync();

        return sessions.Select(s => (object)s).ToList();
    }

    public async Task<object?> GetById(Guid eventId, Guid sessionId)
    {
        var session = await _db.Sessions.Where(s => s.EventId == eventId && s.Id == sessionId).FirstOrDefaultAsync();
         if (session is null) 
            throw new SessionNotFound("Session not found!");
        return session;
    }

    public async Task<object?> Update(Guid sessionId, SessionDto sessionToUpdate)
    {
        var dbSession = await _db.Sessions.FirstOrDefaultAsync(s => s.Id == sessionId && s.EventId == sessionToUpdate.EventId);

        if (dbSession == null)
            throw new SessionNotFound("Invalid Session Id");
        try
        {
            _mapper = GetConfiguredMapper();
            dbSession = _mapper.Map<SessionDto, Session>(sessionToUpdate, dbSession);
            await _db.SaveChangesAsync();
            return dbSession;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw new UpdatedFailed("Update failed");
        }
    }
}
