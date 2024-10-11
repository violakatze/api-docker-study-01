using ApiDockerStudy.Entities;
using ApiDockerStudy.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiDockerStudy.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BookController(IBookRepository repository) : ControllerBase
{
    /// <summary>
    /// 全件取得
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IAsyncEnumerable<Book> Get() => repository.Get();

    /// <summary>
    /// 登録
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <returns></returns>
    [HttpPost]
    public Task Add(string title, string author) => repository.Add(title, author);
}
