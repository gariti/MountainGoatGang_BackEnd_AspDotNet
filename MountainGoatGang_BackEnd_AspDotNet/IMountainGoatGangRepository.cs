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
        void AddGroup(Group g);
        void UpdateGroup(Group g);
        void DeleteGroup(int id);
        void AddHike(Hike h);
        void UpdateHike(Hike g);
        void DeleteHike(int id);
        DbSet<User> GetAllUsers();
        void AddUser(User u);
        void UpdateUser(User h);
        DbSet<Trail> GetAllTrails();
        void DeleteUser(int id);
        void UpdateTrail(Trail h);
        void AddTrail(Trail t);
        void DeleteTrail(int id);
    }
}