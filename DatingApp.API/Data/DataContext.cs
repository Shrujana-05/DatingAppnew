using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;
using Microsoft.EntityFrameworkCore.Design;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options): base(options){}


       public DbSet<Value> Values { get; set; }
    }
}   
