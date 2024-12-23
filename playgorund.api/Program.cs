using playgorund.api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



List<EventDto> Events = [
    new EventDto(1, "Event 1", "Event 1 Description", "https://via.placeholder.com/150", 100, new DateOnly(2022, 1, 1)),
    new EventDto(2, "Event 2", "Event 2 Description", "https://via.placeholder.com/150", 200, new DateOnly(2022, 2, 2)),
    new EventDto(3, "Event 3", "Event 3 Description", "https://via.placeholder.com/150", 300, new DateOnly(2022, 3, 3)),
];


app.MapGet("/", () => "Hello World!");

app.Run();
