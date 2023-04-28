namespace Persona5RoyalFusionCalculator.Models
{
    public class FusionModel
    {
        public int ID { get; set; }
        public int GameID { get; set; }
        public int Persona1 { get; set; }
        public int Persona2 { get; set; }
        public int? Persona3 { get; set; }
        public int Result { get; set; }
    }
}
