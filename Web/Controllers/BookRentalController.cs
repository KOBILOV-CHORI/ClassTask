using Domain.Models;
using Infrastructure.Services.BookRental;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("BookRental")]
[ApiController]
public class BookRentalController : ControllerBase
{
    private readonly IBookRentalService _bookRentalService;

    public BookRentalController(IBookRentalService BookRentalService)
    {
        _bookRentalService = BookRentalService;
    }
    [HttpPost("BookRental")]
    public async Task<bool> AddBookRental(BookRental bookRental)
    {
        var result = await _bookRentalService.AddBookRentalAsync(bookRental);
        return result;
    }
    [HttpPut("BookRental")]
    public async Task<bool> UpdateBookRental(BookRental bookRental)
    {
        var result = await _bookRentalService.UpdateBookRentalAsync(bookRental);
        return result;
    }
    [HttpDelete("BookRental")]
    public async Task<bool> DeleteBookRental(Guid id)
    {
        var result = await _bookRentalService.DeleteBookRentalAsync(id);
        return result;
    }
    [HttpGet("BookRental")]
    public async Task<BookRental?> GetBookRentalById(Guid id)
    {
        var result = await _bookRentalService.GetBookRentalByIdAsync(id);
        return result;
    }
    [HttpGet("GetBookRentals")]
    public async Task<IEnumerable<BookRental>> GetBookRentals()
    {
        var result = await _bookRentalService.GetBookRentalsAsync();
        return result;
    }
}