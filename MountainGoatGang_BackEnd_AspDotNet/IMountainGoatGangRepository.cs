using System.Data.Entity;

namespace MountainGoatGang.Repository
{
    public interface IMountainGoatGangRepository
    {
        DbSet<Group> GetAllGroups();
        DbSet<Hike> GetAllHikes();
        Group GetGroup(int id);
        Hike GetHike(int id);
        Trail GetTrail(int id);
        DbSet<Trail> GetTrails();
        User GetUser(int id);
        DbSet<User> GetUsers();
        void AddGroup(object g);
        void UpdateGroup(object g);
        void DeleteGroup(int id);
    }
}