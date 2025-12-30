var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "🚀 Simple .NET API running on AKS!");

app.MapGet("/health", () => Results.Ok(new
{
    status = "Healthy",
    time = DateTime.UtcNow
}));

app.Run();
