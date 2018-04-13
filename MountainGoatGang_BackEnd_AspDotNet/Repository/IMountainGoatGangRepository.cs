using System.Collections.Generic;

namespace MountainGoatGang.Repository
{
    public interface IMountainGoatGangRepository
    {
        ICollection<Group> GetAllGroups();

        ICollection<Hike> GetAllHikes();

        ICollection<GpsTrack> GetAllGpsTracks();

        ICollection<Trail> GetAllTrails();

        ICollection<User> GetAllUsers();

        ICollection<Hike> GetHikesForGroupId(int groupId);

        ICollection<Trail> GetTrailsForHikeId(int hikeId);

        Group GetGroup(int id);

        Hike GetHike(int id);

        Trail GetTrail(int id);

        GpsTrack GetGpsTrack(int id);

        User GetUser(int id);

        void AddGpsTrack(GpsTrack g);

        void AddGroup(Group g);

        void AddHike(Hike h);

        void AddTrail(Trail t);

        void AddUser(User u);

        void DeleteGpsTrack(int id);

        void DeleteGroup(int id);

        void DeleteHike(int id);

        void DeleteTrail(int id);

        void DeleteUser(int id);

        void UpdateGpsTrack(GpsTrack g);

        void UpdateGroup(Group g);

        void UpdateHike(Hike g);

        void UpdateTrail(Trail h);

        void UpdateUser(User h);
    }
}