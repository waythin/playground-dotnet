using playgorund.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapEventEndPoints();

app.Run();
