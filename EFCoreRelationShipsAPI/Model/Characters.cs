using System.Text.Json.Serialization;

namespace EFCoreRelationShipsAPI.Model
{
    public class Characters
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RpgClass { get; set; } = " knight";
        [JsonIgnore]
        public User User { get; set; }
        public int UserId { get; set; }
        public Weapon Weapon { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
