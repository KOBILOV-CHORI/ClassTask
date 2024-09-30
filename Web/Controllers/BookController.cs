using Domain.Models;
using Infrastructure.Services.Book;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("Book")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService BookService)
    {
        _bookService = BookService;
    }
    [HttpPost("Book")]
    public async Task<bool> AddBook(Book book)
    {
        var result = await _bookService.AddBookAsync(book);
        return result;
    }
    [HttpPut("Book")]
    public async Task<bool> UpdateBook(Book book)
    {
        var result = await _bookService.UpdateBookAsync(book);
        return result;
    }
    [HttpDelete("Book")]
    public async Task<bool> DeleteBook(Guid id)
    {
        var result = await _bookService.DeleteBookAsync(id);
        return result;
    }
    [HttpGet("Book")]
    public async Task<Book?> GetBookById(Guid id)
    {
        var result = await _bookService.GetBookByIdAsync(id);
        return result;
    }
    [HttpGet("GetBooks")]
    public async Task<IEnumerable<Book>> GetBooks()
    {
        var result = await _bookService.GetBooksAsync();
        return result;
    }
}