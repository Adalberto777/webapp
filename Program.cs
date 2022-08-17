// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
// app.MapGet("/", () => "Hello World!");
// app.Run();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();


app.UseRouting();

app.UseEndpoints(e =>
{
  // http://localhost:8812/home/index
  e.MapControllerRoute("default", "{controller}/{action}");
});
app.Run();


// MVC

// MODEL

// VIEW

// CONTROLLER