var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/me", () => "`< b > welcome in your page </ b >`");

app.Run();
