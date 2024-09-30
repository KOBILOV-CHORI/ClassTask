using Domain.Models;

namespace Infrastructure.Services;

public interface IGetCommands
{
    Task<IEnumerable<Domain.Models.BookWithAuthorCategory>> GetBooksWithAuthorCategoryAsync();
    Task<IEnumerable<Domain.Models.Book>> GetBooksByPublicationPeriodAsync(DateTime startDate, DateTime endDate);
    Task<IEnumerable<Domain.Models.Book>> SearchBooksAsync(string? title, string? authorName, string? categoryName);
    Task<IEnumerable<RentedBook>> GetUserRentedBooksAsync(Guid userId);
}
