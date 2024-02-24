namespace VentasAPI.MODELS
{
    public class Pedido
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public DateTime Fecha { get; set; }

        public Cliente Cliente{ get; set; }
    }
}
