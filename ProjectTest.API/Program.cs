var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "GET - Net 6 Running ... 21092022-v1.0.0 CI/CD in JENKINS JOB  v1.0.0 AFORO255";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "POST -  Net 6 Running ... 21092022-v1.0.0 CI/CD in JENKINS JOB  v1.0.0 AFORO255";
});

app.Run();

