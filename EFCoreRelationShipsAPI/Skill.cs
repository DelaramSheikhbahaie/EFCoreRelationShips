using System.Text.Json.Serialization;

namespace EFCoreRelationShipsAPI
{
    public class Skill
    {
        public int Id { get; set; } 
        public string Name { get; set; } = String.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public List<Characters> Character { get; set; }
}
}
