using System.Collections.Generic;
using System;
namespace CleanArchMvc.Domain;
public sealed class Category:Entity
{
    public string Name { get; private set; } = "";

    public Category(string name){
        ValidateNameDomain(name);
    }
    public void UpdatenName(string name){
        ValidateNameDomain(name);
    }
    public Category(int id, string name){
        DomainExeptionValidation.When(id < 1 ,"Invalid Id");
        ValidateNameDomain(name);
    }
    public ICollection<Product> Products {get;set;}

    private void ValidateNameDomain(string name){
        DomainExeptionValidation.When(String.IsNullOrEmpty(name),"Invalid Name");
        DomainExeptionValidation.When(name.Length < 3 ,"Invalid Name to short, minimun 3 caracteres");
        this.Name = name;

    }
}
