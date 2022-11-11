public interface ICategoryServices 
{
    Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
    Task<CategoryDTO> GetById(int? id);
    Task Create(CategoryDTO category);
    Task Update(CategoryDTO category);
    Task Remove(CategoryDTO category);

}