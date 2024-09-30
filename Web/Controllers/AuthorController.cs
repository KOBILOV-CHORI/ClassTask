using Domain.Models;
using Infrastructure.Services.Author;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("Author")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService AuthorService)
    {
        _authorService = AuthorService;
    }
    [HttpPost("Author")]
    public async Task<bool> AddAuthor(Author author)
    {
        var result = await _authorService.AddAuthorAsync(author);
        return result;
    }
    [HttpPut("Author")]
    public async Task<bool> UpdateAuthor(Author author)
    {
        var result = await _authorService.UpdateAuthorAsync(author);
        return result;
    }
    [HttpDelete("Author")]
    public async Task<bool> DeleteAuthor(Guid id)
    {
        var result = await _authorService.DeleteAuthorAsync(id);
        return result;
    }
    [HttpGet("Author")]
    public async Task<Author?> GetAuthorById(Guid id)
    {
        var result = await _authorService.GetAuthorByIdAsync(id);
        return result;
    }
    [HttpGet("GetAuthors")]
    public async Task<IEnumerable<Author>> GetAuthors()
    {
        var result = await _authorService.GetAuthorsAsync();
        return result;
    }
}