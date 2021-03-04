using AutoMapper;
using GL.FC.Data;
using GL.FC.Data.Database;
using GL.FC.Shared;

namespace GL.FC.Services
{
    public class CategoryService : BaseService<CategoryModel, CategoryEntity>, ICategoryService
    {
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper) : base(categoryRepository, mapper)
        {


        }
    }
}
