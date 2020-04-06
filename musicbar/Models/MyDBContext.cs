using System.Data.Entity;

namespace musicbar.Models
{
  public class MyDBContext : DbContext
  {
    public DbSet<Demo> demo { get; set; }
    public MyDBContext()
    {

    }
   
  }
}