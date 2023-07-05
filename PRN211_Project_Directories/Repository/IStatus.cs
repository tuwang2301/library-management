using PRN211_Project_LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Repository
{
    public interface IStatus
    {
        /// <summary>
        /// Get all statuses
        /// </summary>
        /// <returns></returns>
        public List<Status> GetAllStatuses();

        /// <summary>
        /// Get status by username, password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Status GetStatus(int statusId);

        public int GetLastID();

        public void AddStatus(Status status);

        public void UpdateStatus(Status status);

        public void DeleteStatus(Status status);

    }
}
