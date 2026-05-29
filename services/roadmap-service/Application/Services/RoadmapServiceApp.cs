using RoadmapService.Domain.Entities;
using RoadmapService.Domain.Interfaces;
using RoadmapService.Application.DTOs;

namespace RoadmapService.Application.Services;

public class RoadmapServiceApp
{
    private readonly IRoadmapRepository _repo;

    public RoadmapServiceApp(IRoadmapRepository repo)
    {
        _repo = repo;
    }

    public async Task<Roadmap> CreateAsync(CreateRoadmapDto dto)
    {
        var roadmap = new Roadmap(dto.Title, dto.Description);

        await _repo.AddAsync(roadmap);

        return roadmap;
    }

    public async Task<List<Roadmap>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }
}