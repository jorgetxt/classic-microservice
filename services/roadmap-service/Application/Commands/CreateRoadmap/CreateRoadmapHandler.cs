using MassTransit;
using RoadmapService.Domain.Entities;
using RoadmapService.Infrastructure.Messaging;
using RoadmapService.Infrastructure.Data;


public class CreateRoadmapHandler
{
    private readonly AppDbContext _context;
    private readonly IPublishEndpoint _publish;

    public CreateRoadmapHandler(
        AppDbContext context,
        IPublishEndpoint publish)
    {
        _context = context;
        _publish = publish;
    }

    public async Task<Guid> Handle(CreateRoadmapCommand command)
    {
        var roadmap = Roadmap.Create(
            command.Title,
            command.Description
        );

        _context.Roadmaps.Add(roadmap);
        await _context.SaveChangesAsync();

        await _publish.Publish(new RoadmapCreatedEvent(
            roadmap.Id,
            roadmap.Title,
            roadmap.Description
        ));

        return roadmap.Id;
    }
}