using kiyafet_uyg_backend.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kiyafet_uyg_backend.Data
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }  //connectionString bilgisini dışardan alıyoruz.
        public DbSet<SystemUsers> SystemUsers { get; set; }
        public DbSet<Post> posts { get; set; }
       

    }
}
