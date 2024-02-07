using HelloWorld.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//
//var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
//
//builder.Services.AddDbContext<DataContext>(options =>
//    options.UseMySql("server=127.0.0.1;uid=root;pwd=my-secret-pw;database=Test", serverVersion)
//        .LogTo(Console.WriteLine, LogLevel.Information));
//
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/helloWorld", () => "Hola Mundo 2").WithName("Test").WithOpenApi();

//app.MapGet("/helloWorld", async (DataContext ctx) => await ctx.Users.ToListAsync())
//    .WithName("HelloWorld")
//    .WithOpenA pi();
//
app.Run();


//docker run --name mysql -e MYSQL_ROOT_PASSWORD=my-secret-pw -p 3306:3306 -d mysql
//docker run --name mysql -e MYSQL_ROOT_PASSWORD=my-secret-pw -v database:/var/lib/mysql -p 3306:3306 -d mysql