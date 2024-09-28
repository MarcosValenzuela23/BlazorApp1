namespace BlazorApp1.Layout.Models
{
    public class Accidente
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoEconomico { get; set; }
        public int NumeroMuertos { get; set; }
        public int NumeroHeridos { get; set; }
        public int CantidadVehiculos { get; set; }
    }

}
