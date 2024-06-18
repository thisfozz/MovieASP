using MovieASP.DataAccess.Repositories;

namespace MovieASP;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IMovieRepository, MovieRepository>()
            .AddSingleton<ICinemaRepository, CinemaRepository>();
        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();
        app.UseStatusCodePages();
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movie}/{action=List}/{id?}");
        });
    }
}