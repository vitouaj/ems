using EventAPI;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddDefaultServices();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://example.com").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
                      });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.MapGroup("/api/v1/event")
    .WithTags("Event Resource")
    .MapEventEndpoints();

app.MapGroup("/api/v1/session")
    .WithTags("Session Resource")
    .MapSessionEndpoint();

app.Run();