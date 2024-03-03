
using EventAPI.Exceptions;
using EventAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EventAPI;

public static class EventEnpoints
{
    public static void MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", GetAll);
        app.MapGet("/{id}", GetById);
        app.MapDelete("/{id}", Delete);
        app.MapPost("/", CreateNewEvent);
        app.MapPut("/", Update);

    }

    private static async Task<IResult> Delete(IEventRepository repository, Guid id)
    {
        var result = await repository.Delete(id);
        if (!result)
            return Results.BadRequest(new EventResponse(false, "delete failed", null));
        return Results.Ok(new EventResponse(true, "Delete Successfull", null));
    }

    private static async Task<IResult> Update(IEventRepository repository, EventDto eventDto, Guid id)
    {
        if (eventDto == null)
            return Results.BadRequest(new EventResponse(false, "empty request body", null));
        try
        {
            var updateEvent = await repository.Update(id, eventDto);
            return Results.Ok(updateEvent);
        }
        catch (EventNotFound e)
        {
            return Results.BadRequest(new EventResponse(false, e.Message, null));
        }
        catch (UpdatedFailed e)
        {
            return Results.BadRequest(new EventResponse(false, e.Message, null));
        }
    }

    private static async Task<IResult> GetAll(IEventRepository repository)
    {
        return Results.Ok(await repository.GetAll());
    }

    private static async Task<IResult> CreateNewEvent([FromServices] IEventRepository repository, [FromBody] EventDto eventDto)
    {
        var newEvent = await repository.Create(eventDto);
        if (newEvent == null)
            return Results.BadRequest(new EventResponse(false, "failed to create event", null));
        return Results.Created("/event", new EventResponse(true, "Success", newEvent));
    }

    private static async Task<IResult> GetById([FromServices] IEventRepository repository, [FromRoute] Guid id)
    {
        var result = await repository.GetById(id);
        if (result == null)
            return Results.NotFound("Cannot found");
        return Results.Ok(result);
    }
}
