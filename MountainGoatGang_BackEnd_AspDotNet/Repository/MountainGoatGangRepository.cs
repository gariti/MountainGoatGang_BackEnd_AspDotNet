using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MountainGoatGang.Repository
{
    public class MountainGoatGangRepository : IMountainGoatGangRepository
    {
        private MountainGoatGangContext _dbContext;

        public MountainGoatGangRepository(MountainGoatGangContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<Group> GetAllGroups()
        {
            return _dbContext.Groups;
        }

        public DbSet<Hike> GetAllHikes()
        {
            return _dbContext.Hikes;
        }

        public DbSet<User> GetAllUsers()
        {
            return _dbContext.Users;
        }

        public DbSet<Trail> GetAllTrails()
        {
            return _dbContext.Trails;
        }

        public Group GetGroup(int id)
        {
            return _dbContext.Groups.FirstOrDefault(g => g.Id.Equals(id));
        }

        public Hike GetHike(int id)
        {
            return _dbContext.Hikes.FirstOrDefault(h => h.Id.Equals(id));
        }

        public User GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(id));
        }

        public Trail GetTrail(int id)
        {
            return _dbContext.Trails.FirstOrDefault(t => t.Id.Equals(id));
        }

        public void AddGroup(Group g)
        {
            try
            {
                _dbContext.Groups.Add(g);
                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<Group>(g, RepositoryActionStatus.Created);
                }
                else
                {
                    //return new RepositoryActionResult<Group>(g, RepositoryActionStatus.NothingModified, null);
                }
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Group>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void AddHike(Hike h)
        {
            try
            {
                _dbContext.Hikes.Add(h);
                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<Hike>(h, RepositoryActionStatus.Created);
                }
                else
                {
                    //return new RepositoryActionResult<Hike>(h, RepositoryActionStatus.NothingModified, null);
                }
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Hike>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void AddUser(User u)
        {
            try
            {
                _dbContext.Users.Add(u);
                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<User>(u, RepositoryActionStatus.Created);
                }
                else
                {
                    //return new RepositoryActionResult<User>(u, RepositoryActionStatus.NothingModified, null);
                }
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<User>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void AddTrail(Trail t)
        {
            try
            {
                _dbContext.Trails.Add(t);
                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<Trail>(t, RepositoryActionStatus.Created);
                }
                else
                {
                    //return new RepositoryActionResult<Trail>(t, RepositoryActionStatus.NothingModified, null);
                }
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Trail>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void UpdateGroup(Group g)
        {
            try
            {
                // you can only update when an expensegroup already exists for this id

                var existingGroup = _dbContext.Groups.FirstOrDefault(grp => grp.Id == g.Id);

                if (existingGroup == null)
                {
                    //return new RepositoryActionResult<Group>(g, RepositoryActionStatus.NotFound);
                }

                // change the original entity status to detached; otherwise, we get an error on attach
                // as the entity is already in the dbSet

                // set original entity state to detached
                _dbContext.Entry(existingGroup).State = EntityState.Detached;

                // attach & save
                _dbContext.Groups.Attach(g);

                // set the updated entity state to modified, so it gets updated.
                _dbContext.Entry(g).State = EntityState.Modified;


                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<Group>(g, RepositoryActionStatus.Updated);
                }
                else
                {
                    //return new RepositoryActionResult<Group>(g, RepositoryActionStatus.NothingModified, null);
                }

            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Group>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void UpdateHike(Hike h)
        {
            try
            {
                // you can only update when trail already exists for this id

                var existingHike = _dbContext.Hikes.FirstOrDefault(hike => hike.Id == h.Id);

                if (existingHike == null)
                {
                    //return new RepositoryActionResult<User>(g, RepositoryActionStatus.NotFound);
                }

                // change the original entity status to detached; otherwise, we get an error on attach
                // as the entity is already in the dbSet

                // set original entity state to detached
                _dbContext.Entry(existingHike).State = EntityState.Detached;

                // attach & save
                _dbContext.Hikes.Attach(h);

                // set the updated entity state to modified, so it gets updated.
                _dbContext.Entry(h).State = EntityState.Modified;


                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<Hike>(h, RepositoryActionStatus.Updated);
                }
                else
                {
                    //return new RepositoryActionResult<Hike>(h, RepositoryActionStatus.NothingModified, null);
                }

            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Hike>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void UpdateUser(User h)
        {
            try
            {
                // you can only update user already exists for this id

                var existingUser = _dbContext.Users.FirstOrDefault(usr => usr.Id == h.Id);

                if (existingUser == null)
                {
                    //return new RepositoryActionResult<User>(g, RepositoryActionStatus.NotFound);
                }

                // change the original entity status to detached; otherwise, we get an error on attach
                // as the entity is already in the dbSet

                // set original entity state to detached
                _dbContext.Entry(existingUser).State = EntityState.Detached;

                // attach & save
                _dbContext.Users.Attach(h);

                // set the updated entity state to modified, so it gets updated.
                _dbContext.Entry(h).State = EntityState.Modified;


                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<User>(u, RepositoryActionStatus.Updated);
                }
                else
                {
                    //return new RepositoryActionResult<User>(u, RepositoryActionStatus.NothingModified, null);
                }

            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<User>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void UpdateTrail(Trail t)
        {
            try
            {
                // you can only update when trail already exists for this id

                var existingTrail = _dbContext.Trails.FirstOrDefault(trail => trail.Id == t.Id);

                if (existingTrail == null)
                {
                    //return new RepositoryActionResult<User>(g, RepositoryActionStatus.NotFound);
                }

                // change the original entity status to detached; otherwise, we get an error on attach
                // as the entity is already in the dbSet

                // set original entity state to detached
                _dbContext.Entry(existingTrail).State = EntityState.Detached;

                // attach & save
                _dbContext.Trails.Attach(t);

                // set the updated entity state to modified, so it gets updated.
                _dbContext.Entry(t).State = EntityState.Modified;


                var result = _dbContext.SaveChanges();
                if (result > 0)
                {
                    //return new RepositoryActionResult<Trail>(t, RepositoryActionStatus.Updated);
                }
                else
                {
                    //return new RepositoryActionResult<Trail>(t, RepositoryActionStatus.NothingModified, null);
                }

            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<User>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void DeleteGroup(int id)
        {
            try
            {

                var grp = _dbContext.Groups.Where(g => g.Id == id).FirstOrDefault();
                if (grp != null)
                {
                    _dbContext.Groups.Remove(grp);

                    _dbContext.SaveChanges();
                    //return new RepositoryActionResult<Group>(null, RepositoryActionStatus.Deleted);
                }
                //return new RepositoryActionResult<Group>(null, RepositoryActionStatus.NotFound);
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Group>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void DeleteHike(int id)
        {
            try
            {
                var hike = _dbContext.Hikes.Where(h => h.Id == id).FirstOrDefault();
                if (hike != null)
                {
                    _dbContext.Hikes.Remove(hike);

                    _dbContext.SaveChanges();
                    //return new RepositoryActionResult<Hike>(null, RepositoryActionStatus.Deleted);
                }
                //return new RepositoryActionResult<Hike>(null, RepositoryActionStatus.NotFound);
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Hike>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                var user = _dbContext.Users.Where(u => u.Id == id).FirstOrDefault();
                if (user != null)
                {
                    _dbContext.Users.Remove(user);

                    _dbContext.SaveChanges();
                    //return new RepositoryActionResult<User>(null, RepositoryActionStatus.Deleted);
                }
                //return new RepositoryActionResult<User>(null, RepositoryActionStatus.NotFound);
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<User>(null, RepositoryActionStatus.Error, ex);
            }
        }

        public void DeleteTrail(int id)
        {
            try
            {
                var trail = _dbContext.Trails.Where(t => t.Id == id).FirstOrDefault();
                if (trail != null)
                {
                    _dbContext.Trails.Remove(trail);

                    _dbContext.SaveChanges();
                    //return new RepositoryActionResult<Trail>(null, RepositoryActionStatus.Deleted);
                }
                //return new RepositoryActionResult<Trail>(null, RepositoryActionStatus.NotFound);
            }
            catch (Exception ex)
            {
                //return new RepositoryActionResult<Trail>(null, RepositoryActionStatus.Error, ex);
            }
        }
    }
}