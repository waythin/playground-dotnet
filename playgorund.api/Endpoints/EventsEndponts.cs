using System;
using System.Reflection.Metadata.Ecma335;
using playgorund.api.Dtos;

namespace playgorund.api.Endpoints;

public static class EventsEndponts
{
    const string GetEventEndPointName = "GetEvent";


    private static readonly List<EventDto> events = [
        new EventDto(1, "Event 1", "Event 1 Description", "https://via.placeholder.com/150", 100, new DateOnly(2022, 1, 1)),
        new EventDto(2, "Event 2", "Event 2 Description", "https://via.placeholder.com/150", 200, new DateOnly(2022, 2, 2)),
        new EventDto(3, "Event 3", "Event 3 Description", "https://via.placeholder.com/150", 300, new DateOnly(2022, 3, 3)),
    ];

    public static RouteGroupBuilder MapEventEndPoints(this WebApplication app)
    {

        var group = app.MapGroup("/events")
                        .WithParameterValidation();

        // get
        group.MapGet("/", () => events);

        // get by id
        group.MapGet("/{id}", (int id) =>
        {
            EventDto? e = events.Find(e => e.Id == id);
            return e is not null ? Results.Ok(e) : Results.NotFound();

        }).WithName(GetEventEndPointName);

        // post 
        group.MapPost("/", (CreateEventDto newEvent) =>
        {
            EventDto e = new(
                events.Count + 1,
                newEvent.Title,
                newEvent.Description,
                newEvent.ImageUrl,
                newEvent.Price,
                newEvent.Date
            );

            events.Add(e);

            return Results.CreatedAtRoute(GetEventEndPointName, new { id = e.Id }, e);
        });

        // put 
        group.MapPut("/{id}", (int id, UpdateEventDto UpdateGame) => {
            
            var Index = events.FindIndex(e => e.Id == id);

            events[Index]= new EventDto(  
                id,
                UpdateGame.Title,
                UpdateGame.Description,
                UpdateGame.ImageUrl,
                UpdateGame.Price,
                UpdateGame.Date);

                return Results.NoContent();
        });



        // delete
        group.MapDelete("/{id}", (int id) => {
            events.RemoveAll(e => e.Id == id);

            return Results.NoContent();
        });

        return group;
    }   
    
       

}
