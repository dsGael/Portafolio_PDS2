using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos= ObtenerProyectos().Take(3).ToList();
            var modelo=new HomeIndexVIewModel() {Proyectos= proyectos};
            return View(modelo);
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
    

    private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-commerce realizado en ASP.NET core",
                    Link = "https://amazon.com",
                    ImagenURL = "./imagenes/amazon.png "

                },
                new Proyecto{
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "./imagenes/nyt.png"
                },
                new Proyecto{
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "./imagenes/reddit.png"
                },
                new Proyecto{
                    Titulo = "Steam",
                    Descripcion = "Tienda en lianea para omprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "./imagenes/steam.png"
                }

            };

        }
    }
}
