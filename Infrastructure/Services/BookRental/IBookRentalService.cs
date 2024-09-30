namespace Infrastructure.Services.BookRental;

public interface IBookRentalService
{
    Task<bool> AddBookRentalAsync(Domain.Models.BookRental bookRental);
    Task<bool> UpdateBookRentalAsync(Domain.Models.BookRental bookRental);
    Task<bool> DeleteBookRentalAsync(Guid id);
    Task<Domain.Models.BookRental?> GetBookRentalByIdAsync(Guid id);
    Task<IEnumerable<Domain.Models.BookRental>> GetBookRentalsAsync();

}
