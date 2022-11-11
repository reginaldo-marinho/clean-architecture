public interface ICategoryServices 
{
    Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
    Task<CategoryDTO> GetById(int? id);
    Task<CategoryDTO> Create(CategoryDTO category);
    Task<CategoryDTO> Update(CategoryDTO category);
    Task<CategoryDTO> Remove(CategoryDTO category);

}