using Microsoft.AspNetCore.Mvc;
using TimeCapsule.Services;

namespace TimeCapsule.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskTypeController : ControllerBase
{
    private readonly ITaskTypeService _taskTypeService;

    public TaskTypeController(ITaskTypeService taskStopwatchService)
    {
        _taskTypeService = taskStopwatchService;
    }
    
    [HttpGet]
    public IActionResult GetTaskTypes()
    {
        var taskTypes = _taskTypeService.GetTaskTypes();
        return Ok(taskTypes);
    }
}