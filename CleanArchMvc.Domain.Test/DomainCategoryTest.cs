using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanArchMvc.Domain;
using FluentAssertions;


namespace CleanArchMvc.Domain.Test;

[TestClass]
public class DomainCategoryTest
{
    [TestMethod]
    public void CategorySetDomainExeptionValidationInIdZero()
    {
        Action action = () => new Category(0,"Doces");
        action.Should().Throw<DomainExeptionValidation>();
    }
    [TestMethod]
    public void CategoryIdWithValue()
    {
        Action action = () => new Category(1,"Doces");
        action.Should().NotThrow<DomainExeptionValidation>();
    }
    
}