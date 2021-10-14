using kiyafet_uyg_backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kiyafet_uyg_backend.Data
{
    public interface IUsersRepository
    {
        public void AddUser(SystemUsers systemUsers);
        public void DeleteUser(int Id);
        public void UpdateUser(SystemUsers systemUsers);
        public IEnumerable<SystemUsers> GetUser(int Id);
        public SystemUsers GetUserById(int Id);
    }
}
