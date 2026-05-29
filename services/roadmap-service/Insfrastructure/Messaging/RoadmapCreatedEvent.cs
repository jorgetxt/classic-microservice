namespace RoadmapService.Infrastructure.Messaging;

public record RoadmapCreatedEvent(Guid Id, string Title, string Description);