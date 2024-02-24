using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using VentasAPI.DATA;
using VentasAPI.MODELS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly VentaDbContext ventaDbContext;

        public ProductoController(VentaDbContext ventaDbContext)
        {
            this.ventaDbContext = ventaDbContext;
        }
        // GET: api/<ProductoController>
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            return ventaDbContext.Productos.ToList();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public Producto Get(int id)
        {
            return ventaDbContext.Productos.Find(id);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public IActionResult Post([FromBody] Producto value)
        {
            ventaDbContext.Productos.Add(value);
            return Ok();
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto value)
        {
            var existingProduct = ventaDbContext.Productos.Find(id);
            existingProduct.Nombre = value.Nombre;
            existingProduct.Descripcion = value.Descripcion;

            ventaDbContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var productToDelete = ventaDbContext.Productos.Find(id);
            ventaDbContext.Productos.Remove(productToDelete);
            ventaDbContext.SaveChanges();

            return Ok();
        }
    }
}
