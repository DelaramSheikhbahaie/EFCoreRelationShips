using System.Text.Json.Serialization;

namespace EFCoreRelationShipsAPI.Model
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public List<Characters> Character { get; set; }
    }
}
