using FireLibrary.Data;
using Microsoft.Extensions.Logging;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
//string connectionStringLibrary = builder.Configuration.GetConnectionString("connectionStringLibrary");
//string connectionStringAuth = builder.Configuration.GetConnectionString("connectionStringAuth");


//Adding CORS, allowing any origin
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*");
                      });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRepository>(spLibrary => new LibraryRepository(connectionStringLibrary, spLibrary.GetRequiredService<ILogger<LibraryRepository>>()));
builder.Services.AddSingleton<IRepository>(spAuth => new AuthRepository(connectionStringAuth, spAuth.GetRequiredService<ILogger<LibraryRepository>>()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Displaying swagger on build
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
