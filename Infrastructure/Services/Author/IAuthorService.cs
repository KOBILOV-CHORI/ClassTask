namespace Infrastructure.Services.Author;

public interface IAuthorService
{
    Task<bool> AddAuthorAsync(Domain.Models.Author author);
    Task<bool> UpdateAuthorAsync(Domain.Models.Author author);
    Task<bool> DeleteAuthorAsync(Guid id);
    Task<Domain.Models.Author?> GetAuthorByIdAsync(Guid id);
    Task<IEnumerable<Domain.Models.Author>> GetAuthorsAsync();

}
