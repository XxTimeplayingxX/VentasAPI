using System.Reflection.PortableExecutable;

namespace VentasAPI.MODELS
{
    public class ClienteCiudad
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public int CiudadID { get; set; }

        //Propiedad de navegación
        public Cliente Cliente { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
