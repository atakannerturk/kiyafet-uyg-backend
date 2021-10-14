using kiyafet_uyg_backend.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kiyafet_uyg_backend.Data
{
    public class UsersRepository : IUsersRepository
    {
        private ApiDbContext context;
        public UsersRepository(ApiDbContext _context)
        {
            context = _context;
        }

        public void AddUser(SystemUsers systemUsers)
        {
            context.SystemUsers.Add(systemUsers);
            context.SaveChanges();
        }

        public void DeleteUser(int Id)
        {
            var Deleted = context.SystemUsers.FirstOrDefault(p => p.Id == Id);
            context.Remove(Deleted);
            context.SaveChanges();

        }

        public IEnumerable<SystemUsers> GetUser(int Id)
        {
            return context.SystemUsers;
        }

        public SystemUsers GetUserById(int Id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(SystemUsers systemUsers)
        {
            throw new NotImplementedException();
        }
    }
}
