namespace CleanArchMvc.Domain;
public sealed class Product : Entity
{
    public Product (int id, string name, string descrition, decimal price, string img){
        DomainValidation( id, name, descrition, price, img);
    }

    public Product (string name, string descrition, decimal price, string img){
        DomainValidation(0, name, descrition, price, img);
    }


    public string Name { get; private set; } = "";
    public string Descrition { get; private set; } = "";
    public decimal Price { get; private set; }
    public string Image { get; private set; } = "";
    public int CategoryId { get;  set; }
    public string CategoryName { get;  set; } = "";

    private void DomainValidation(int id, string name, string descrition, decimal price, string img){
        DomainExeptionValidation.When(id < 0,"invalid id");
        DomainExeptionValidation.When(string.IsNullOrEmpty(name),"invalid name");
        DomainExeptionValidation.When(name.Length > 50,"invalid name, lengt > 50");
        DomainExeptionValidation.When(price < 0,"invalid price");
        
        this.Id = id;
        this.Name = name;
        this.Descrition = descrition;
        this.Price = price;
        this.Image = img;
    }

}