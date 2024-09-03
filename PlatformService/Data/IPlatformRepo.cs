using PlatformService.Models;

namespace PlatformService.Data;

public interface IPlatformRepo
{
    bool SaveChanges();

    IEnumerable<Platform> GetAllPlatformServices();

    Platform GetPlatformById(int id);

    void CreatePlatform(Platform platform);
}