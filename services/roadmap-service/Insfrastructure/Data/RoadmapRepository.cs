using Microsoft.EntityFrameworkCore;
using RoadmapService.Domain.Entities;
using RoadmapService.Domain.Interfaces;

namespace RoadmapService.Infrastructure.Data;

public class RoadmapRepository : IRoadmapRepository
{
    private readonly AppDbContext _context;

    public RoadmapRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Roadmap roadmap)
    {
        _context.Roadmaps.Add(roadmap);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Roadmap>> GetAllAsync()
    {
        return await _context.Roadmaps.ToListAsync();
    }
}