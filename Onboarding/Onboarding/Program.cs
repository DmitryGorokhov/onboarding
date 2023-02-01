using Microsoft.EntityFrameworkCore;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Onboarding;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
            .Build();

        host.Run();

        //// Add services to the container.

        //builder.Services.AddControllers();
        //// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        //builder.Services.AddDbContext<DBContext>(opt =>
        //    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        //builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DBContext>();

        //var app = builder.Build();

        //// Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
        //    app.UseSwagger();
        //    app.UseSwaggerUI();
        //}

        //app.UseHttpsRedirection();

        //app.UseAuthorization();

        //app.MapControllers();

        //app.Run();


        //async Task CreateUserRoles(IServiceProvider serviceProvider)
        //{
        //    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //    var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

        //    if (await roleManager.FindByNameAsync("admin") == null)
        //    {
        //        await roleManager.CreateAsync(new IdentityRole("admin"));
        //    }

        //    if (await roleManager.FindByNameAsync("user") == null)
        //    {
        //        await roleManager.CreateAsync(new IdentityRole("user"));
        //    }
        //}
    }
}