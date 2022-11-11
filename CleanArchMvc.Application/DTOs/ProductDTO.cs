using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CleanArchMvc.Domain;

public  class ProductDTO
{  
    public int Id { get; protected set; }

    [Required(ErrorMessage = "The Name is Requerid")]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("Name")]
    public string? Name { get; set;}
    
    [Required(ErrorMessage = "The Descrition is Requerid")]
    [MinLength(5)]
    [MaxLength(200)]
    [DisplayName("Descrition")]
    public string Descrition { get;  set; } = "";

    [Required(ErrorMessage = "The Price is Requerid")]
    [Column(TypeName = "decimal(18,2)")]
    [DataType(DataType.Currency)]
    [DisplayName("Price")]
    public decimal Price { get;  set; }

    [DisplayName("Image")]
    public string? Image { get;  set; }
    public int CategoryId { get; set; }
    public Category? Category { get;  set; }
    
}