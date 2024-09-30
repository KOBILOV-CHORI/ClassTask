using Domain.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCommandsController : ControllerBase
    {
        private readonly IGetCommands _getCommandsService;

        public GetCommandsController(IGetCommands getCommandsService)
        {
            _getCommandsService = getCommandsService;
        }

        // 1. Получение всех книг с авторами и категориями
        [HttpGet("GetBooksWithAuthorCategory")]
        public async Task<IActionResult> GetBooksWithAuthorCategoryAsync()
        {
            var result = await _getCommandsService.GetBooksWithAuthorCategoryAsync();
            return Ok(result);
        }

        // 2. Получение книг, опубликованных в определенный период
        [HttpGet("GetBooksByPublicationPeriod")]
        public async Task<IActionResult> GetBooksByPublicationPeriodAsync([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var result = await _getCommandsService.GetBooksByPublicationPeriodAsync(startDate, endDate);
            return Ok(result);
        }

        // 3. Поиск книг по названию, автору или категории
        [HttpGet("SearchBooks")]
        public async Task<IActionResult> SearchBooksAsync([FromQuery] string? title, [FromQuery] string? authorName, [FromQuery] string? categoryName)
        {
            var result = await _getCommandsService.SearchBooksAsync(title, authorName, categoryName);
            return Ok(result);
        }

        // 4. Получение арендованных книг пользователем
        [HttpGet("GetUserRentedBooks/{userId}")]
        public async Task<IActionResult> GetUserRentedBooksAsync(Guid userId)
        {
            var result = await _getCommandsService.GetUserRentedBooksAsync(userId);
            return Ok(result);
        }
    }
}
