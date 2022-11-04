using Microsoft.EntityFrameworkCore;
using CSApiRestPractice.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddRouting(routing => routing.LowercaseUrls = true);

builder.Services.AddDbContext<ClientService>(mysqlBuilder => {

    mysqlBuilder.UseMySQL(builder.Configuration.GetConnectionString("MySQLConnection"));

});

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.MapRazorPages();

app.Run();
