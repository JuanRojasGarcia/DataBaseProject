using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Restaurant
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SP_Insertar_Producto",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SP_Insertar", action = "SP_Insertar_Producto", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SP_Cancelar_Pedido",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SP_Cancelar_Pedido", action = "SP_Cancelar_Pedido", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SP_Modificar",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SP_Modificar", action = "SP_Modificar_Ingrediente", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SP_OrdenxEstado",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SP_OrdenxEstado", action = "SP_Orden_Estado", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SP_Nuevo_Pedido",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SP_Nuevo_Pedido", action = "SP_Alta_Pedido", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "SP_Ventas_Rango",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "SP_Ventas", action = "SP_Ventas_Rango", id = UrlParameter.Optional }
            );
        }
    }
}
