public class ProductServices : IProductServices
{
    
    public ProductServices ()
    {

    }
    public Task<ProductDTO> Create(ProductDTO category)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDTO>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> Remove(ProductDTO category)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> Update(ProductDTO category)
    {
        throw new NotImplementedException();
    }
}