namespace Infrastructure;

public class SqlCommands
{

    public const string ConnectionString =
        "Server=localhost;Port=5432;Database=library_db;User Id=postgres;Password=01062007;";

    public const string AddAuthor = "insert into authors (firstname, lastname, dateofbirth, biography, createdat) values(@firstname, @lastname, @dateofbirth, @biography, @createdat)";
    public const string DeleteAuthor = "delete from authors where id = @id";
    public const string GetAuthorById = "select * from authors where id = @id";
    public const string GetAllAuthors = "select * from authors";
    public const string UpdateAuthor = "update authors set firstname = @firstname, lastname = @lastname, dateofbirth = @dateofbirth, biography = @biography, createdat = @createdat where id = @id";

    public const string AddCategory = "insert into categories (name, createdat) values (@name, @createdat)";
    public const string DeleteCategory = "delete from categories where id = @id";
    public const string GetCategoryById = "select * from categories where id = @id";
    public const string UpdateCategory = "update categories set name = @name, createdat = @createdat where id = @id";
    public const string GetAllCategories = "select * from categories";

    public const string AddBook =  "insert into books (title, description, isbn, publisheddate, authorid, categoryid,createdat) values (@title, @description, @isbn, @publisheddate, @authorid, @categoryid, @createdat)";
    public const string DeleteBook = "delete from books where id = @id";
    public const string GetBookById = "select * from books where id = @id";
    public const string GetAllBooks = "select * from books";
    public const string UpdateBook = "update books set title = @title, description = @description, isbn = @isbn, publisheddate = @publisheddate, authorid = @authorid, categoryid = @categoryid, createdat = @createdat where id = @id";
    public const string AddUser = "insert into users (username, email, passwordhash, createdat) values (@username, @email, @passwordhash, @createdat)";
    public const string DeleteUser = "delete from users where id = @id";
    public const string UpdateUser = "update users set username = @username, email = @email, passwordhash = @passwordhash, createdat = @createdat where id = @id";
    public const string GetAllUsers = "select * from users";
    public const string GetUserById = "select * from users where id = @id";

    public const string GetAllBookRentals = "select * from bookrentals";
    public const string GetBookRentalById = "select * from bookrentals where id = @id";
    public const string AddBookRental = "insert into bookrentals (bookid, userid, rentaldate, returndate, createdat) values (@bookid, @userid, @rentaldate, @returndate, @createdat)";
    public const string DeleteBookRental = "delete from bookrentals where id = @id";
    public const string UpdateBookRental = "update from bookrentals set bookid = @bookid, userid = @userid, rentaldate = @rentaldate, createdat = @createdat, returndate = @returndate where id = @id";
    public const string GetBooksByPublicationPeriod = "select * from books where publishedDate BETWEEN @StartDate AND @EndDate";
    public const string SearchBooks = "SELECT b.Id as Id, b.Title as Title, b.Description as Description, b.ISBN as ISBN, b.PublishedDate as PublishedDate, b.AuthorId as AuthorId, b.CategoryId as CategoryId, b.CreatedAt as CreatedAt FROM Books b JOIN Authors a ON b.AuthorId = a.Id JOIN Categories c ON b.CategoryId = c.Id WHERE (@AuthorName IS NULL OR (a.FirstName ILIKE '%' || @AuthorName || '%' OR a.LastName ILIKE '%' || @AuthorName || '%')) AND(@CategoryName IS NULL OR c.Name ILIKE '%' || @CategoryName || '%')";
    public const string GetUserRentedBooks = "SELECT br.Id AS RentalId, b.Id AS BookId, b.Title, b.Description, b.ISBN, b.PublishedDate, b.CreatedAt AS BookCreatedAt,br.RentalDate, br.ReturnDate, br.CreatedAt AS RentalCreatedAt FROM BookRentals br JOIN Books b ON br.BookId = b.Id WHERE br.UserId = @UserId";
}
