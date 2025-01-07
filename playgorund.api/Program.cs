using playgorund.api.Data;
using playgorund.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var ConnString =  builder.Configuration.GetConnectionString("EventStore");
builder.Services.AddSqlite<EventStoreContext>(ConnString);

var app = builder.Build();

// call route endpoints
app.MapEventEndPoints();

app.Run();
