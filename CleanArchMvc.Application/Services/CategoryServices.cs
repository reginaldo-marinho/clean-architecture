using AutoMapper;
using CleanArchMvc.Domain;
public class CategoryServices : ICategoryServices
{

    private ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryServices (ICategoryRepository categoryRepository, IMapper mapper)
    {
        this._categoryRepository = categoryRepository;
        this._mapper = mapper;
    }
    public async Task Create(CategoryDTO category)
    {
          var categoriesEntity =  _mapper.Map<Category>(category);
          await _categoryRepository.Create(categoriesEntity);
    }

    public async Task<CategoryDTO> GetById(int? id)
    {
        var categoriesEntity = await _categoryRepository.GetById(id);
        return _mapper.Map<CategoryDTO>(categoriesEntity);
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
    {
        var categoriesEntity = await _categoryRepository.GetCategoriesAsync();

        return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
    }

    public async Task Remove(CategoryDTO category)
    {
        var categoriesEntity =  _mapper.Map<Category>(category);
        await _categoryRepository.Remove(categoriesEntity);

    }

    public async Task Update(CategoryDTO category)
    {
        var categoriesEntity =  _mapper.Map<Category>(category);
        await _categoryRepository.Update(categoriesEntity);
    }
}