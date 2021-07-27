using Microsoft.EntityFrameworkCore;

namespace InternManagement.Api.Models
{
  public class InternContext : DbContext
  {
    public InternContext(DbContextOptions<InternContext> options) : base(options)
    {

    }

    public DbSet<Intern> Interns { get; set; }
  }
}