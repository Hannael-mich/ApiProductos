using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiProductos.Models;

namespace WebApiProductos.Entidades
{
    public class ProductoExt
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public Nullable<System.DateTime> FechaCaducidad { get; set; }
        public Nullable<int> Marcaid { get; set; }
        public Nullable<int> Departamentoid { get; set; }

        public MarcasExt Marcas { get; set; }
    }
}