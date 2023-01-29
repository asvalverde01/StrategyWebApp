using Microsoft.AspNetCore.Mvc;
using StrategyWebApp.Context;
using StrategyWebApp.Models;
using StrategyWebApp.Strategies;
using System.Diagnostics;

namespace StrategyWebApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int value, string strategy)
        {
            Context<int, double> context;
            if (strategy == "A")
            {
                context = new Context<int, double>(new ConcreteStrategyA());
                ViewData["Result"] = context.ExecuteStrategy(value);
            }
            else
            {
                context = new Context<int, double>(new ConcreteStrategyB());
                ViewData["Result"] = context.ExecuteStrategy(value);
            }
            return View();
        }
    }

}