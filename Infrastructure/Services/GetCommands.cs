using Dapper;
using Domain.Models;
using Npgsql;

namespace Infrastructure.Services;

public class GetCommands : IGetCommands
{
    public async Task<IEnumerable<Domain.Models.BookWithAuthorCategory>> GetBooksWithAuthorCategoryAsync()
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                await connection.OpenAsync();
                var books = await connection.QueryAsync<Domain.Models.Book>(SqlCommands.GetAllBooks);
                List<BookWithAuthorCategory> booksWithAuthorCategories = new List<BookWithAuthorCategory>();
                foreach (var book in books)
                {
                    BookWithAuthorCategory bookWithAuthorCategory = new BookWithAuthorCategory();
                    bookWithAuthorCategory.Id = book.Id;
                    bookWithAuthorCategory.AuthorId = book.AuthorId;
                    bookWithAuthorCategory.CategoryId = book.CategoryId;
                    bookWithAuthorCategory.CreatedAt = book.CreatedAt;
                    bookWithAuthorCategory.Title = book.Title;
                    bookWithAuthorCategory.Description = book.Description;
                    bookWithAuthorCategory.PublishedDate = book.PublishedDate;
                    bookWithAuthorCategory.ISBN = book.ISBN;
                    bookWithAuthorCategory.Author = await connection.QueryFirstOrDefaultAsync<Domain.Models.Author>(SqlCommands.GetAuthorById, new { Id = book.AuthorId });
                    bookWithAuthorCategory.Category = await connection.QueryFirstOrDefaultAsync<Domain.Models.Category>(SqlCommands.GetCategoryById, new { Id = book.CategoryId });
                    booksWithAuthorCategories.Add(bookWithAuthorCategory);
                }
                return booksWithAuthorCategories;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public async Task<IEnumerable<Domain.Models.Book>> GetBooksByPublicationPeriodAsync(DateTime startDate, DateTime endDate)
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<Domain.Models.Book>(SqlCommands.GetBooksByPublicationPeriod, new { StartDate = startDate, EndDate = endDate });
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
    }
    public async Task<IEnumerable<Domain.Models.Book>> SearchBooksAsync(string? title, string? authorName, string? categoryName)
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<Domain.Models.Book>(SqlCommands.SearchBooks, new { Title = title, AuthorName = authorName, CategoryName = categoryName });
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    public async Task<IEnumerable<RentedBook>> GetUserRentedBooksAsync(Guid userId)
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(SqlCommands.ConnectionString))
            {
                await connection.OpenAsync();
                return await connection.QueryAsync<RentedBook>(SqlCommands.GetUserRentedBooks, new { UserId = userId });
            }
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            throw;
        }
    }
}
