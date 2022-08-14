using System.Text.Json.Serialization;

namespace EFCoreRelationShipsAPI.Model
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; } = 10;
        [JsonIgnore]
        public Characters Character { get; set; }
        public int CharacterId { get; set; }

    }
}
