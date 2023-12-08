using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app) 
        { 
            using(var ServiceScope = app.ApplicationServices.CreateScope())
            {

                SeedData(ServiceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext db)
        {
            if (!db.Platforms.Any())
            {
                Console.WriteLine("Отправляем информацию...");
                db.Platforms.AddRange(
                    new Platform() { Name = "VisualStudio", Publisher = "Microsoft", Cost = "Free"},
                    new Platform() { Name = "Github", Publisher = "Tom Werner", Cost = "Free"},
                    new Platform() { Name = "Pycharm", Publisher = "IntelliJ", Cost = "Free"}
                    );
                db.SaveChanges();
            }
            else Console.WriteLine("Упс, информация уже есть");
        }
    }
}
