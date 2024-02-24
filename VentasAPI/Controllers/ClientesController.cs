using Microsoft.AspNetCore.Mvc;
using VentasAPI.DATA;
using VentasAPI.MODELS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VentasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase 
    {
        private readonly VentaDbContext ventaDbContext;

        public ClientesController(VentaDbContext ventaDbContext)
        {
            this.ventaDbContext = ventaDbContext;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return ventaDbContext.Clientes.ToList();
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public Cliente Get(Cliente id)
        {

            return ventaDbContext.Clientes.Find(id);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public IActionResult Post([FromBody] Cliente value)
        {
            ventaDbContext.Clientes.Add(value);
            return Ok();
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Cliente value)
        {
            var existingCustomer = ventaDbContext.Clientes.Find(id);
            existingCustomer.Nombre = value.Nombre;
            existingCustomer.Ciudad = value.Ciudad;

            ventaDbContext.SaveChanges();
            return Ok();

        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var customerToDelete = ventaDbContext.Clientes.Find(id);
            ventaDbContext.Remove(customerToDelete);
            ventaDbContext.SaveChanges();
            return Ok();    
        }
    }
}
