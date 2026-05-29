using MassTransit;

namespace RoadmapService.Infrastructure.Messaging;

public class RoadmapPublisher
{
    private readonly IPublishEndpoint _publish;

    public RoadmapPublisher(IPublishEndpoint publish)
    {
        _publish = publish;
    }

    public async Task PublishCreated(Guid id, string title, string description)
    {
        await _publish.Publish(new RoadmapCreatedEvent(id, title, description));
    }
}