using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using VentasAPI.MODELS;

namespace VentasAPI.DATA
{
    public class VentaDbContext : DbContext
    {
        public VentaDbContext(DbContextOptions<VentaDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteCiudad> ClienteCiudades { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<PedidoProducto> PedidoProductos { get; set; }
    }
}
