using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6Movies.Models;

namespace Mission6Movies.Controllers;

public class HomeController : Controller
{
    private MovieContext _context;
    public HomeController(MovieContext movies)// Constructor
    {
        _context = movies;
    } 

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddMovie(Application response)
    {
        return View();
    }
}