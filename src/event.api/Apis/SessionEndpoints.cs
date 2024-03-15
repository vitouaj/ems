using EventAPI.Abstactions;
using EventAPI.Exceptions;
using EventAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EventAPI;

public static class SessionEndpoints
{
    public static void MapSessionEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", GetAll);
        app.MapGet("/{eventId}/{sessionId}", GetById);
        app.MapDelete("/{eventId}/{sessionId}", Delete);
        app.MapPost("/", CreateNewSession);
        app.MapPut("/{sessionId}", Update);
    }

    private static async Task<IResult> Delete(ISessionRepository repository, Guid eventId, Guid sessionId)
    {
        var result = await repository.Delete(eventId, sessionId);
        if (!result)
            return Results.BadRequest(new SessionResponse(false, "delete failed", null));
        return Results.Ok(new SessionResponse(true, "Delete Successfull", null));
    }

    private static async Task<IResult> Update(ISessionRepository repository, [FromBody] SessionDto sessionToUpdate, Guid sessionId)
    {
        if (sessionToUpdate == null)
            return Results.BadRequest(new SessionResponse(false, "empty request body", null));
        try
        {
            var updateEvent = await repository.Update(sessionId, sessionToUpdate);
            return Results.Ok(updateEvent);
        }
        catch (EventNotFound e)
        {
            return Results.BadRequest(new SessionResponse(false, e.Message, null));
        }
        catch (UpdatedFailed e)
        {
            return Results.BadRequest(new SessionResponse(false, e.Message, null));
        }
    }

    private static async Task<IResult> GetAll(ISessionRepository repository, Guid eventId)
    {
        return Results.Ok(await repository.GetAll(eventId));
    }

    private static async Task<IResult> CreateNewSession([FromServices] ISessionRepository repository, [FromBody] SessionDto sessionToCreate)
    {
        var newSession = await repository.Create(sessionToCreate);
        if (newSession == null)
            return Results.BadRequest(new SessionResponse(false, "failed to create session", null));
        return Results.Created("/session/", new SessionResponse(true, "Success", newSession));
    }

    private static async Task<IResult> GetById([FromServices] ISessionRepository repository, [FromRoute] Guid eventId, Guid sessionId)
    {
        try
        {
            var result = await repository.GetById(eventId, sessionId);
            return Results.Ok(result);
        }
        catch (EventNotFound e)
        {
            return Results.BadRequest(e.Message);
        }
    }
}
