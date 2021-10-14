using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static kiyafet_uyg_backend.Enums.Enumaration;

namespace kiyafet_uyg_backend.Entity
{
    public class SystemUsers
    {
        [Key]
        public int Id { get; set; }
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string NameSurName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLogin { get; set; }
        public UserState UserState { get; set; }
        public bool IsDeleted { get; set; }

        public SystemUsers()
        {
            CreateDate = DateTime.Now;
        }

        public bool Login()
        {
            return true;
        }

        public bool Logout()
        {
            return true;
        }

        public bool Activate()
        {
            return true;
        }

        public int Save()
        {

            return 1;
        }

        public bool Delete()
        {
            return true;
        }

        /// <summary>
        /// Returns list of users 
        /// </summary>
        /// <param name="filter">Filter keyword</param>
        /// <returns>Returns a generic list of users filtered by parameter</returns>
        public List<SystemUsers> GetList(string filter)
        {

            return new List<SystemUsers>();

        }

    }
}

