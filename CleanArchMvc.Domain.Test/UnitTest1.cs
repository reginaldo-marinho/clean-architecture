using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanArchMvc.Domain;
using FluentAssertions;


namespace CleanArchMvc.Domain.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Action action = () => new Category(0,"Doces");
        action.Should().Throw<DomainExeptionValidation>();
    }
}