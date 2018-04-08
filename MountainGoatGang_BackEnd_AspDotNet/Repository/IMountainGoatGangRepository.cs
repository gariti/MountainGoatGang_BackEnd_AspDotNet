using System.Data.Entity;
using System.Linq;

namespace MountainGoatGang.Repository
{
    public interface IMountainGoatGangRepository
    {
        DbSet<Group> GetAllGroups();
        DbSet<Hike> GetAllHikes();
        DbSet<User> GetAllUsers();
        DbSet<Trail> GetAllTrails();
        Group GetGroup(int id);
        Hike GetHike(int id);
        Trail GetTrail(int id);
        User GetUser(int id);
        void AddGroup(Group g);
        void UpdateGroup(Group g);
        void DeleteGroup(int id);
        void AddHike(Hike h);
        void UpdateHike(Hike g);
        void DeleteHike(int id);
        void AddUser(User u);
        void UpdateUser(User h);
        void DeleteUser(int id);
        void UpdateTrail(Trail h);
        void AddTrail(Trail t);
        void DeleteTrail(int id);
        IQueryable<Hike> GetHikesForGroupId(int groupId);
        IQueryable<Trail> GetTrailsForHikeId(int hikeId);
    }
}