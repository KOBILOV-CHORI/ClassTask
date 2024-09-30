namespace Infrastructure.Services.User;

public interface IUserService
{
    Task<bool> AddUserAsync(Domain.Models.User user);
    Task<bool> UpdateUserAsync(Domain.Models.User user);
    Task<bool> DeleteUserAsync(Guid id);
    Task<Domain.Models.User?> GetUserByIdAsync(Guid id);
    Task<IEnumerable<Domain.Models.User>> GetUsersAsync();

}
