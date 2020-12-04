using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Interfaces;
using App.Core.UseCases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Unity;
using Web.Models;
using App.Core.Entities;
using App.Infrastructure;
using App.Infrastructure.Datos;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        static ManageOperations<Producto> ManageOperationsProducto;

        public IActionResult Index()
        {
            InitializeContainer();
            var entity = new Producto
            {
                NumProveedor = 12,
                precio = 1500,
                Stock = 100,
                Date = DateTime.Now,
                DateUpdate = DateTime.Now,
                Estado = true
            };
            var obj = ManageOperationsProducto.Create(entity);
            return View(obj);
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

        static void InitializeContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IOperations<Producto>, ManageOperations<Producto>>();
            container.RegisterType<IRepository<Producto>, Repository<Producto>>();
            ManageOperationsProducto = container.Resolve<ManageOperations<Producto>>();
        }
    }
}
