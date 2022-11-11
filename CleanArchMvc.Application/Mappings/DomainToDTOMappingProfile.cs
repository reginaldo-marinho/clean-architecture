using AutoMapper;
using CleanArchMvc.Domain;
public class DomainToDTOMappingProfile : Profile  
{
 public DomainToDTOMappingProfile()
 {
    CreateMap<Category,CategoryDTO>().ReverseMap();
    CreateMap<Product,ProductDTO>().ReverseMap();
 }
}