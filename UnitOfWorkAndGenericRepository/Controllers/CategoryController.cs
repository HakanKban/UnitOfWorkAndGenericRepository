using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfWorkAndGenericRepository.Entity;
using UnitOfWorkAndGenericRepository.UOW;

namespace UnitOfWorkAndGenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<Category> AddCategory(Category category)
        {
            await _unitOfWork.CategoryRepository.CreateAsync(category);
            return category;
        }
    }
}
