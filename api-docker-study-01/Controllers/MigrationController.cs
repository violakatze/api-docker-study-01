using ApiDockerStudy.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiDockerStudy.Controllers;

/// <summary>
/// MigrationController
/// </summary>
/// <param name="repository"></param>
[ApiController]
[Route("api/[controller]/[action]")]
public class MigrationController(IMigrationRepository repository) : ControllerBase
{
    /// <summary>
    /// migration実行
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public Task Migrate() => repository.Migrate();
}
