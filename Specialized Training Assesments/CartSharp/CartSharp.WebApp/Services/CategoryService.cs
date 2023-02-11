using CartSharp.WebApp.Dto;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace CartSharp.WebApp.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public CategoryViewDto Create(CategoryCreateDto dto) 
        { 
            var category = new Category
            {
                Name = dto.Name,
                Description = dto.Description
            };

            _db.Categories.Add(category);
            _db.SaveChanges();

            return new CategoryViewDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            };
        }
    }
}
