using BookSpaceApi.Data;

namespace BookSpaceApi.Extensions;

public static class ApplicationExtensions
{
    public static WebApplication CreateDataBase(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            dbContext.Database.EnsureCreated();
        }
        return app;
    }
}
