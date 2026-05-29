using RoadmapService.Domain.Entities;

namespace RoadmapService.Domain.Interfaces;

public interface IRoadmapRepository
{
    Task AddAsync(Roadmap roadmap);
    Task<List<Roadmap>> GetAllAsync();
}