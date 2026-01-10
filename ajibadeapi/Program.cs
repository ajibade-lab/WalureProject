using Prometheus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMetricServer();    // /metrics
app.UseHttpMetrics();

app.MapGet("/", () => "🚀 Simple .NET API with Prometheus metrics!");
app.MapGet("/health", () => Results.Ok(new { status = "Healthy", time = DateTime.UtcNow }));

app.Run();
