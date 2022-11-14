using AutoMapper;
using CleanArchMvc.Domain;
public class ProductServices : IProductServices
{
    
    private IProductRepository _productRepository;
    private  IMapper _autoMapper;

    public ProductServices (IProductRepository productRepository, IMapper autoMapper)
    {
        this._productRepository = productRepository;
        this._autoMapper = autoMapper;
    }
    public async Task<ProductDTO> Create(ProductDTO category)
    {
        var produtEntity = _autoMapper.Map<Product>(category);
        await this._productRepository.Create(produtEntity);
        return category;
    }
    public async Task<ProductDTO> GetById(int? id)
    {
        var produtEntity = await this._productRepository.GetById(id);
        return _autoMapper.Map<ProductDTO>(produtEntity);
    }
    public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
    {
        var produtEntity = await this._productRepository.GetProductsAsync();
        return _autoMapper.Map<IEnumerable<ProductDTO>>(produtEntity);

    }
    public async Task<ProductDTO> Remove(ProductDTO category)
    {
        var produtEntity = _autoMapper.Map<Product>(category);
        await this._productRepository.Remove(produtEntity);
        return category;
    }
    public async Task<ProductDTO> Update(ProductDTO category)
    {
         var produtEntity = _autoMapper.Map<Product>(category);
        await this._productRepository.Update(produtEntity);
        return category;
    }
}