using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Services
{
    public class UserProfileServices : IUserProfile
    {
        public void AddUserProfile(UserProfile userProfile)
        {
            using(var con = new LibraryManagementContext())
            {
                con.UserProfiles.Add(userProfile);
                con.SaveChanges();
            }
        }

        public void DeleteUserProfile(UserProfile userProfile)
        {
            using (var con = new LibraryManagementContext())
            {
                con.UserProfiles.Remove(userProfile);
                con.SaveChanges();
            }
        }

        public List<UserProfile> GetAllUserProfiles()
        {
            List<UserProfile> users = new List<UserProfile>();
            using (var con = new LibraryManagementContext())
            {
                users = con.UserProfiles.ToList();
            }
            return users;
        }

        public UserProfile GetUserProfile(int accountId)
        {
            UserProfile user = new UserProfile();
            using (var con = new LibraryManagementContext())
            {
                user = con.UserProfiles.Where((x) => x.AccountId == accountId).FirstOrDefault();
            }
            return user;
        }

        public void UpdateUserProfile(UserProfile userProfile)
        {
            using (var con = new LibraryManagementContext())
            {
                con.UserProfiles.Update(userProfile);
                con.SaveChanges();
            }
        }
    }
}
