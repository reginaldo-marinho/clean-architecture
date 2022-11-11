using CleanArchMvc.Domain;
using Microsoft.EntityFrameworkCore;
using CleanArchMvc.Domain.Context;
namespace CleanArchMvc.Domain.Repositories;

public class  ProductRepository : IProductRepository
{

    private ApplicationDbContext _productContext;    
    public ProductRepository(ApplicationDbContext context){
        this._productContext = context;
    }
    public async Task<Product> Create(Product product)
    {
        this._productContext.Add(product);
        await this._productContext.SaveChangesAsync();
        return product;
    }
    public async Task<Product> GetById(int? id)
    {
        return await this._productContext.Products.FindAsync(id);   
    }
    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
       return await this._productContext.Products.ToListAsync();
    }
    public async Task<Product> Remove(Product product)
    {
        this._productContext.Remove(product);
        await this._productContext.SaveChangesAsync();
        return product;
    }
    public async Task<Product> Update(Product product)
    {
        this._productContext.Update(product);
        await this._productContext.SaveChangesAsync();
        return product;
    }
}