var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapGet("/", async (context) =>
{
    // Simulate BAD access of e.g. DB
    //Task.Delay(5000).Wait();

    // Simulate GOOD access of e.g. DB
    await Task.Delay(TimeSpan.FromSeconds(5));

    await context.Response.WriteAsync("Hello World!");
});

app.Run();