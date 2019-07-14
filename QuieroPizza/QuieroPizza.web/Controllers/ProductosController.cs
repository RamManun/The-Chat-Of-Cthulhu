using QuieroPizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var Producto = new ProductoModel();
            Producto.Id = 1;
            Producto.Descripcion = "Pizza Gigante";
                
            var Producto1 = new ProductoModel();
            Producto1.Id = 2;
            Producto1.Descripcion = "Pizza Mediana";

            var Producto2 = new ProductoModel();
            Producto2.Id = 3;
            Producto2.Descripcion = "Pizza Pequeña";

            var listadeproductos = new List<ProductoModel>();
            listadeproductos.Add(Producto);
            listadeproductos.Add(Producto1);
            listadeproductos.Add(Producto2);
            return View(listadeproductos);
        }
    }
}