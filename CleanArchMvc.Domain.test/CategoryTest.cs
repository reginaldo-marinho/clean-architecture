using FluentAssertions;
using CleanArchMvc.Domain;

namespace CleanArchMvc.test;


[TestClass]
public class CategoryTest
{
    [TestMethod]
    public void ValidateIdGreaterThanZero()
    {
        Action action = () => new CategoryTest(1,"Bebidas");

    }
}