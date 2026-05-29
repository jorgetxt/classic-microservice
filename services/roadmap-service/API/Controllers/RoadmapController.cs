using Microsoft.AspNetCore.Mvc;
using RoadmapService.Application.DTOs;
using RoadmapService.Application.Services;
using RoadmapService.Infrastructure.Messaging;
using Microsoft.AspNetCore.Authorization;
using RoadmapService.Application.Queries.GetRoadmaps;


namespace RoadmapService.API.Controllers;

// [ApiController]
// [Route("api/roadmaps")]

[ApiController]
[Route("api/[controller]")]
[Authorize]

public class RoadmapController : ControllerBase
{
    private readonly RoadmapServiceApp _service;
    private readonly RoadmapPublisher _publisher;

    private readonly CreateRoadmapHandler _createHandler;
    private readonly GetRoadmapsHandler _getHandler;

    public RoadmapController(RoadmapServiceApp service, RoadmapPublisher publisher, CreateRoadmapHandler createHandler, GetRoadmapsHandler getHandler)
    {
        _service = service;
        _publisher = publisher;
        _createHandler = createHandler;
        _getHandler = getHandler;
    }
    
      [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateRoadmapCommand command)
    {
        var userId = Guid.Parse(User.FindFirst("sub")!.Value);

        var id = await _createHandler.Handle(
            command with { UserId = userId }
        );

        return Ok(new { id });
    }

    
    [HttpGet]
    public async Task<IActionResult> Get()
    {

         var data = await _getHandler.Handle();
        return Ok(data);
    }

        // if service layer is used directly
//     [HttpPost]
//     public async Task<IActionResult> Create(CreateRoadmapDto dto)
//     {
//         var roadmap = await _service.CreateAsync(dto);

//         await _publisher.PublishCreated(roadmap.Id, roadmap.Title, roadmap.Description);

//         return Ok(roadmap);
//     }

//     [HttpGet]
//     public async Task<IActionResult> Get()
//     {

//         var data = await _service.GetAllAsync();
//         return Ok(data);
//     }

 }