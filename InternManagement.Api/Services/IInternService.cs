using System.Collections.Generic;
using System.Threading.Tasks;
using InternManagement.Api.Dtos;

namespace InternManagement.Api.Services
{
    public interface IInternService
    {
        Task<InternDto> AddInternAsync(InternDto dto);
        Task<InternDto> GetInternByIdAsync(int id);

        Task<IEnumerable<InternListItemDto>> GetInternsAsync();
        Task<DecisionDto> PrintDecisionAsync(int id);
        Task<AttestationDto> PrintAttestationAsync(int id);
        Task<AnnulationDto> PrintAnnulationAsync(int id);

        Task<bool> SetDecisionAsync(DecisionFormDto dto);
    }
}