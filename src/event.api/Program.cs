using EventAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDefaultServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGroup("/api/v1/event")
    .WithTags("Event Resource")
    .MapEventEndpoints();

app.Run();