using PRN211_Project_LibraryManagement.Models;
using PRN211_Project_LibraryManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_Project_LibraryManagement.Services
{
    public class StatusServices : IStatus
    {
        public void AddStatus(Status status)
        {
            using(var con = new LibraryManagementContext())
            {
                con.Statuses.Add(status);
                con.SaveChanges();
            }
        }

        public void DeleteStatus(Status status)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Statuses.Remove(status);
                con.SaveChanges();
            }
        }

        public List<Status> GetAllStatuses()
        {
            List<Status> list = new List<Status>();
            using (var con = new LibraryManagementContext())
            {
                list = con.Statuses.ToList();
            }
            return list;
        }

        public int GetLastID()
        {
            using (var con = new LibraryManagementContext())
            {
                var last = con.Statuses.OrderByDescending(a => a.StatusId).FirstOrDefault();
                if (last != null)
                {
                    return last.StatusId;
                }
                return 0; // hoặc giá trị mặc định khác tùy vào yêu cầu của bạn
            }
        }

        public Status GetStatus(int statusId)
        {
            Status status = new Status();
            using (var con = new LibraryManagementContext())
            {
                status = con.Statuses.Where(x => x.StatusId == statusId).FirstOrDefault(); 
            }
            return status;
        }

        public void UpdateStatus(Status status)
        {
            using (var con = new LibraryManagementContext())
            {
                con.Statuses.Update(status);
                con.SaveChanges();
            }
        }
    }
}
