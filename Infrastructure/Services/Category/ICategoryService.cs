namespace Infrastructure.Services.Category;

public interface ICategoryService
{
    Task<bool> AddCategoryAsync(Domain.Models.Category category);
    Task<bool> UpdateCategoryAsync(Domain.Models.Category category);
    Task<bool> DeleteCategoryAsync(Guid id);
    Task<Domain.Models.Category?> GetCategoryByIdAsync(Guid id);
    Task<IEnumerable<Domain.Models.Category>> GetCategoriesAsync();

}
