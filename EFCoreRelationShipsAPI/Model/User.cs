namespace EFCoreRelationShipsAPI.Model
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public List<Characters> Characters { get; set; }
    }
}
