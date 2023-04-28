namespace Persona5RoyalFusionCalculator.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ArcanaID { get; set; }
        public int GameID { get; set; }
        public int Level { get; set; }
        public int? Cost { get; set; }
        public bool? Catchable { get; set; }
    }
}
