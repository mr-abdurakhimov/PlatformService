using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _dbContext;

        public PlatformRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }
        
        public void CreatePlatform(Platform platform)
        {
            if (platform == null) throw new ArgumentNullException(nameof(platform));
            else
            {
                _dbContext.Platforms.Add(platform);
            }

        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _dbContext.Platforms.ToList();
        }

        public Platform GetPlatform(int id)
        {
            return _dbContext.Platforms.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return _dbContext.SaveChanges() >= 0;
        }
    }
}
