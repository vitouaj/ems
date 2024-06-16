
using EventAPI.Exceptions;
using EventAPI.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace EventAPI;

public static class EventEnpoints
{
    public static void MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/{pageSize}/{pageIndex}", GetAll);
        app.MapGet("/{id}", GetById);
        app.MapDelete("/{id}", Delete);
        app.MapPost("/", CreateNewEvent);
        app.MapPut("/", Update);
        app.MapGet("/category", GetCategoryOptions);
        app.MapGet("/venue", GetVenueOptions);

    }
    private static async Task<IResult> GetVenueOptions(IEventRepository repository)
    {
        var result = await repository.GetVenueOptions();
        return result != null ? Results.Ok(result) : Results.BadRequest();
    }


    private static async Task<IResult> GetCategoryOptions(IEventRepository repository)
    {
        var result = await repository.GetCategoryOptions();

        return result != null ? Results.Ok(result) : Results.BadRequest();
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

    private static async Task<IResult> GetAll([FromServices] IEventRepository repository, int pageSize = 10, int pageIndex = 1)
    {
        return Results.Ok(await repository.GetAll(pageSize, pageIndex));
    }

    private static async Task<IResult> CreateNewEvent([FromServices] IEventRepository repository, [FromBody] EventDto eventDto)
    {
        try
        {
            var newEvent = await repository.Create(eventDto);
            return Results.Created("/event", new EventResponse(true, "Success", newEvent));

        }
        catch (Exception e)
        {
            return Results.BadRequest(new EventResponse(false, e.Message, null));
        }
    }

    private static async Task<IResult> GetById([FromServices] IEventRepository repository, [FromRoute] Guid id)
    {
        try
        {
            var result = await repository.GetById(id);
            return Results.Ok(result);
        }
        catch (EventNotFound e)
        {
            return Results.BadRequest(e.Message);
        }
    }
}
