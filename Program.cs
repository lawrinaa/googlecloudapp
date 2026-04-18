var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "GoogleCloudApp darbojas Render vidē!");

app.Run();
