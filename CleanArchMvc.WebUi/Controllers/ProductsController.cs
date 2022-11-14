using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CleanArchMvc.WebUi.Models;

namespace CleanArchMvc.WebUi.Controllers;

public class ProductsController : Controller
{
    private readonly IProductServices _productServices;
    public ProductsController(IProductServices productServices)
    {
        _productServices = productServices;
    }
    [HttpGet]
    public async  Task<IActionResult> Index()
    {
        var products  = await _productServices.GetProductsAsync();
        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
