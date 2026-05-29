using Microsoft.EntityFrameworkCore;
using RoadmapService.Domain.Entities;

namespace RoadmapService.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Roadmap> Roadmaps => Set<Roadmap>(
    );
}