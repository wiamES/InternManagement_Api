using System.Collections.Generic;
using System.Threading.Tasks;
using InternManagement.Api.Models;

namespace InternManagement.Api.Repository
{
  public interface IInternRepository
  {
    Task<Intern> AddInternAsync(Intern model);
    Task<bool> InternExistsAsync(int id);
    Task<Intern> GetInternAsync(int id);
    Task<IEnumerable<Intern>> GetInternsAsync();
    Task<bool> SetDecisionForIntern(int id, Decision decision);
  }
}