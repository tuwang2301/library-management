using PRN211_Project_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Repository
{
    public interface IUserProfile
    {
        /// <summary>
        /// Get all userProfiles
        /// </summary>
        /// <returns></returns>
        public List<UserProfile> GetAllUserProfiles();

        /// <summary>
        /// Get userProfile by username, password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public UserProfile GetUserProfile(int accountId);

        public void AddUserProfile(UserProfile userProfile);

        public void UpdateUserProfile(UserProfile userProfile);

        public void DeleteUserProfile(UserProfile userProfile);

    }
}
