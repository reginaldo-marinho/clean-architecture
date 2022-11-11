using System.ComponentModel.DataAnnotations;
public  class CategoryDTO
{  
    public int Id { get; protected set; }

    [Required(ErrorMessage = "The name is requerid")]
    [MinLength(3)]
    [MaxLength(100)]
    public string Name { get; set; } = "";
    
}