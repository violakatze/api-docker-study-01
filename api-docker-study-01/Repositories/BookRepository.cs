using ApiDockerStudy.Contexts;
using ApiDockerStudy.Entities;

namespace ApiDockerStudy.Repositories;

/// <summary>
/// BookRepository
/// </summary>
public interface IBookRepository
{
    IAsyncEnumerable<Book> Get();

    Task Add(string title, string author);
}

/// <summary>
/// BookRepository
/// </summary>
public class BookRepository(AppDbContext context, ILogger<BookRepository> logger) : IBookRepository
{
    /// <summary>
    /// 全件取得
    /// </summary>
    /// <returns></returns>
    public IAsyncEnumerable<Book> Get() => context.Books.AsAsyncEnumerable();

    /// <summary>
    /// 登録
    /// </summary>
    /// <param name="title"></param>
    /// <param name="author"></param>
    /// <remarks>文字列の長さチェックをしてない</remarks>
    /// <returns></returns>
    public async Task Add(string title, string author)
    {
        context.Books.Add(new()
        {
            Title = title,
            Author = author
        });

        logger.LogInformation($"add title:{title} author:{author}");
        await context.SaveChangesAsync();
    }
}
