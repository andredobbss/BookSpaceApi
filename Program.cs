using BookSpaceApi.Data;
using BookSpaceApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSqlite<AppDbContext>(builder.Configuration.GetConnectionString("DefaultConnection"));

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();
    //.AddInMemorySubscriptions();

var app = builder.Build();

ApplicationExtensions.CreateDataBase(app);

app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.MapGraphQL("/graphql");

app.Run();
