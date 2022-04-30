using Microsoft.EntityFrameworkCore;
using ProjectOne.Application.Interfaces.Contexts;
using ProjectOne.Domian.Entites.Users;

namespace ProjectOne.Persistence.Contexts
{
    public class DataBaseContext : DbContext,IDatBaseContext
    {
        public DataBaseContext
            (DbContextOptions
            <DataBaseContext>
            options)
            : base
            (options)
        { }

        public DbSet<User>Users  { get; set; }
        public DbSet<Role>Roles  { get; set; }
        public DbSet<UserInRole>UserInRoles  { get; set; }


    }
}