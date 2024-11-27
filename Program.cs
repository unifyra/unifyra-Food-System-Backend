
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // Registers controllers for handling HTTP requests
builder.Services.AddEndpointsApiExplorer(); // Enables API exploration endpoints
builder.Services.AddSwaggerGen(); // Registers Swagger for API documentation

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enables Swagger in the development environment
    app.UseSwaggerUI(); // Enables the Swagger UI
}

app.UseHttpsRedirection(); // Redirects HTTP requests to HTTPS
app.UseAuthorization(); // Enables authorization middleware

app.MapControllers(); // Maps attribute-routed controllers

app.Run();
