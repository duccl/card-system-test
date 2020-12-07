namespace acme_flight_system.Models
{
    class VooModel
    {
        public int ID_VOO { get; set; }
        public System.DateTime Data { get; set; }
        public double Custo { get; set; }
        public int Distancia { get; set; }
        public int Nivel_dor { get; set; }
        public char Captura_passaro { get; set; }
    }
}
