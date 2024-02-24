namespace VentasAPI.MODELS
{
    public class PedidoProducto
    {
        public int ID { get; set; }
        public int PedidoID { get; set; }
        public int ProductoID { get; set; }

        //Propiedad de Navegación
        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
    }
}
