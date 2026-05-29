namespace RoadmapService.Domain.Entities;

public class Roadmap
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; private set; }
    public string Description { get; private set; }

    public Roadmap(string title, string description)
    {
        Title = title;
        Description = description;
    }

    
    public static Roadmap Create(string title, string description)
    {
        return new Roadmap(title, description);
    }
}