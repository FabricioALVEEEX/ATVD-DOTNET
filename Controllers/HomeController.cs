using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCDOTNET.Models;
using System.Collections;
using System.Collections.Generic;
namespace MVCDOTNET.Controllers;



    class Comida
        {            ArrayList comidas = new ArrayList();
            public void AdicionarComida(Restaurante comida)
            {
                comidas.Add(comida);
            }
            public void RemoverComida(Restaurante comida)
            {
                comidas.Remove(comida);
            }
            public void ListarComidas()
            {
                foreach (Restaurante comida in comidas)
                {
                    Console.WriteLine($"Id: {comida.Id}, Nome: {comida.Nome}, Preco: {comida.Preco}");
                }
                if (comidas.Count == 0)
                {
                    Console.WriteLine("Nenhuma comida foi encontrada.");
                } else
                {
                    Console.WriteLine("Comidas disponíveis:");
                    foreach (Restaurante comida in comidas)
                    {
                        Console.WriteLine($"Id: {comida.Id}, Nome: {comida.Nome}, Preco: {comida.Preco}");
                    }
                }
            }
        }
    

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
