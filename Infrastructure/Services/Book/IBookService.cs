namespace Infrastructure.Services.Book;

public interface IBookService
{
    Task<bool> AddBookAsync(Domain.Models.Book Book);
    Task<bool> UpdateBookAsync(Domain.Models.Book Book);
    Task<bool> DeleteBookAsync(Guid id);
    Task<Domain.Models.Book?> GetBookByIdAsync(Guid id);
    Task<IEnumerable<Domain.Models.Book>> GetBooksAsync();

}
