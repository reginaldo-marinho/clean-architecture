namespace CleanArchMvc.Domain;
public sealed class Product : Entity
{
    public Product (){}
    public Product (int id, string name, string descrition, decimal price, string img, int categoryId){
        DomainExeptionValidation.When(id < 0,"invalid id");
        this.Id = id;
        DomainValidation(name, descrition, price, img);
        DomainExeptionValidation.When(categoryId < 0,"invalid categoryId");
        this.CategoryId = categoryId;   
    }

    public Product (string name, string descrition, decimal price, string img){
        DomainValidation(name, descrition, price, img);
    }


    public string Name { get; private set; } = "";
    public string Descrition { get; private set; } = "";
    public decimal Price { get; private set; }
    public string Image { get; private set; } = "";
    public int CategoryId { get;  set; }
    public Category Category { get;  set; }

    private void DomainValidation(string name, string descrition, decimal price, string img){
        DomainExeptionValidation.When(string.IsNullOrEmpty(name),"invalid name");
        DomainExeptionValidation.When(name.Length > 50,"invalid name, lengt > 50");
        DomainExeptionValidation.When(price < 0,"invalid price");
        
        this.Name = name;
        this.Descrition = descrition;
        this.Price = price;
        this.Image = img;
    }

}