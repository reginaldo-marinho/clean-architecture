public interface IProductServices 
{
   
    Task<IEnumerable<ProductDTO>> GetProductsAsync();
    Task<ProductDTO> GetById(int? id);
    Task<ProductDTO> Create(ProductDTO category);
    Task<ProductDTO> Update(ProductDTO category);
    Task<ProductDTO> Remove(ProductDTO category);

}