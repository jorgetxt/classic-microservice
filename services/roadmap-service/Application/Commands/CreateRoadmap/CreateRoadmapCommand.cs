public record CreateRoadmapCommand(
    string Title,
    string Description,
    Guid UserId
);