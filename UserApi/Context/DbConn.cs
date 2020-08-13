using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Context
{
    public class DbConn : DbContext
    {

        public DbConn(DbContextOptions<DbConn> options) : base(options) { }

        public DbSet<UserModel> User { get; set; }
    }
}
