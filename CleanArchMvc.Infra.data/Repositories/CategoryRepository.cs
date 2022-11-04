using CleanArchMvc.Domain;
using Microsoft.EntityFrameworkCore;
public class  CategoryRepository : ICategoryRepository
{

    private AplicationDbContext _categoryContext;    
    public CategoryRepository(AplicationDbContext context){
        this._categoryContext = context;
    }
    public async Task<Category> Create(Category category)
    {
        this._categoryContext.Add(category);
        await this._categoryContext.SaveChangesAsync();
        return category;
    }
    public async Task<Category> GetById(int? id)
    {
        return await this._categoryContext.Categories.FindAsync(id);   
    }
    public async Task<IQueryable<Category>> GetCategoriesAsync()
    {
        return  await this._categoryContext.Categories.ToListAsync();
    }
    public async Task<Category> Remove(Category category)
    {
        this._categoryContext.Remove(category);
        await this._categoryContext.SaveChangesAsync();
        return category;
    }
    public async Task<Category> Update(Category category)
    {
        this._categoryContext.Update(category);
        await this._categoryContext.SaveChangesAsync();
        return category;
    }
}