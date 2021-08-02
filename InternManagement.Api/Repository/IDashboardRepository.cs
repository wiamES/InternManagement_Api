using System.Collections.Generic;
using System.Threading.Tasks;
using InternManagement.Api.Models;

namespace InternManagement.Api.Repository
{
  public interface IDashboardRepository
  {
    Task<IEnumerable<Intern>> GetLatestInternsAsync();

  }
}