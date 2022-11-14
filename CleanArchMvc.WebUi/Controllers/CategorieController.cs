using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CleanArchMvc.WebUi.Models;

namespace CleanArchMvc.WebUi.Controllers;

public class CategorieController : Controller
{
    private readonly ICategoryServices _categoryServices;
    public CategorieController(ICategoryServices categoryServices)
    {
        _categoryServices = categoryServices;
    }

    [HttpGet]
    public async  Task<IActionResult> Index()
    {
        var categories  = await _categoryServices.GetCategoriesAsync();
        return View(categories);
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
