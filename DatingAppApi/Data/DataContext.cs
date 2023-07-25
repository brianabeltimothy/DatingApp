using DatingAppApi.Entities;
using Microsoft.EntityFrameworkCore;

// this class acts as getway between the app and the database, it facilitates communication and interaction between the code and the database
namespace DatingAppApi.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    // for connection string to the database

    public DbSet<AppUser> Users { get; set; } 
    // to CRUD on the "Users" table 
    // a DbSet<T> is a class for ORM, to get the records of a table "T"
    // Users is the name of the property
  }
}