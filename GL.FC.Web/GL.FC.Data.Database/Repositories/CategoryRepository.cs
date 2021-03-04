namespace GL.FC.Data.Database
{
    public class CategoryRepository : Repository<CategoryEntity>, ICategoryRepository
    {
        public CategoryRepository(DataContext context) : base(context)
        {


        }
    }
}
