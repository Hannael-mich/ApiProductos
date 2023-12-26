using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProductos.Entidades;
using WebApiProductos.Models;

namespace WebApiProductos.Controllers
{
    public class ProductosController : ApiController
    {
        // GET: api/Productos

        Generacion23Entities db = new Generacion23Entities();

        public List<ProductoExt> Get()
        {
            List<Productos> ls = db.Productos.Include("Marcas").ToList();
            List<ProductoExt> lsExt = new List<ProductoExt>();

            foreach (Productos p in ls)
            {
                ProductoExt px = new ProductoExt();
                MarcasExt mx = new MarcasExt();
                px.id=p.id;
                px.Nombre=p.Nombre;
                px.FechaCaducidad = p.FechaCaducidad;
                px.Departamentoid = p.Departamentoid;
                px.Marcaid = p.Marcaid;

                mx.idM = p.Marcas.idM;
                mx.NombreM = p.Marcas.NombreM;
                mx.Estatus = p.Marcas.Estatus;

                px.Marcas = mx;

                lsExt.Add(px);
            }
            return lsExt;
        }

        // GET: api/Productos/5
        public ProductoExt Get(int id)
        {
            Productos p = db.Productos.Include("Marcas").Where(x => x.id == id).FirstOrDefault();

            ProductoExt px = new ProductoExt();
            MarcasExt mx = new MarcasExt();
            px.id = p.id;
            px.Nombre = p.Nombre;
            px.FechaCaducidad = p.FechaCaducidad;
            px.Departamentoid = p.Departamentoid;
            px.Marcaid = p.Marcaid;

            mx.idM = p.Marcas.idM;
            mx.NombreM = p.Marcas.NombreM;
            mx.Estatus = p.Marcas.Estatus;

            px.Marcas = mx;

            return px;
        }

        // POST: api/Productos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Productos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Productos/5
        public void Delete(int id)
        {
        }
    }
}
