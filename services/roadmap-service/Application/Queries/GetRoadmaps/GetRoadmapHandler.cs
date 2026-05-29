// using RoadmapService.Infrastructure.Data;
using RoadmapService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using RoadmapService.Infrastructure.Data;


namespace RoadmapService.Application.Queries.GetRoadmaps;

public class GetRoadmapsHandler
{
    private readonly AppDbContext _context;

    public GetRoadmapsHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Roadmap>> Handle()
    {
        return await _context.Roadmaps.ToListAsync();
    }
}